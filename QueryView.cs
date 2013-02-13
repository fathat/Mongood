using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoAdmin
{
    public partial class QueryView : UserControl
    {
        MongoServer _server;

        public QueryView(MongoServer mongoServer, MongoDatabase db, MongoCollection collection)
        {

            InitializeComponent();
            _server = mongoServer;
            
            dbCombo.Items.Clear();
            dbCombo.Items.AddRange(_server.GetDatabaseNames().ToArray());

            _ServerLabel.Text = _server.Primary.Address.Host;

            if(db != null)
            {
                dbCombo.Text = db.Name;
            }

            if(collection != null)
            {
                this.jsEdit.Text = "db." + collection.Name + ".find({}).limit(20)";

                ProcessJSCommand();
            }

            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.F5)
            {
                OnRun(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        public void ClearResult()
        {
            resultText.Text = "";
        }
        public void WriteLine(string text)
        {
            resultText.Text += text + "\n";
        }

        private void OnRun(object sender, EventArgs e)
        {
            try
            {
                var db = _server[dbCombo.Text];

                if(jsEdit.Text.StartsWith("show"))
                {
                    ProcessShowCommand();
                }
                else if(jsEdit.Text.StartsWith("use"))
                {
                    ProcessUseCommand();
                }
                else 
                {
                    ProcessJSCommand();
                }
                
            }
            catch (Exception exc)
            {
                resultText.Text = exc.ToString();
                
            }

        }

        private void ProcessUseCommand()
        {
            try
            {
                var command = jsEdit.Text.Trim();
                var parts = command.Split(' ');

                var dbname = parts[1];

                SwitchDB(dbname);
            }
            catch (Exception)
            {
                
            }
            

        }

        private void SwitchDB(string dbname)
        {
            dbCombo.Text = dbname;
        }

        private void ProcessJSCommand()
        {
            var command = jsEdit.Text.Trim();

            if(command.EndsWith(";"))
                command = command.Substring(0, command.Length-1);

            if(command.Contains(".find("))
            {
                if(!command.Contains(".limit("))
                    command += ".limit(100)";
                command += ".toArray()";
            }
            var db = CurrentDB;

            


            using(db.RequestStart())
            {
                var js = new BsonJavaScript(command);
                var bson = db.Eval(js);
                
                var error = db.GetLastError();
                resultText.Text = bson.ToString();
                

                if(bson.IsBsonArray)
                {
                    dataGridView.DataSource = null;
                    dataGridView.Columns.Clear();
                    dataGridView.Rows.Clear();

                    resultText.Text = JsonHelper.FormatJson(resultText.Text);
                    var array = bson.AsBsonArray;
                    
                    //set columns
                    var columns= DetermineColumns(array);
                    
                    dataGridView.ColumnCount = columns.Count;
                    for(int i=0; i<columns.Count; i++)
                        dataGridView.Columns[i].Name = columns[i];


                    //set data in columns
                    int rowIndex = 0;
                    if(array.Count == 0)
                        return;
                    dataGridView.RowCount = array.Count;
                    foreach (var row in array)
                    {
                        if(!row.IsBsonDocument)
                            continue;
                        
                        var doc = row.AsBsonDocument;

                        foreach (var field in doc)
                        {
                            dataGridView[(string)field.Name, rowIndex].Value = field.Value.ToString();
                        }

                        rowIndex++;
                    }

                }

            }
        }

        private List<string> DetermineColumns(BsonArray array)
        {
            var columns = new List<string>();
            var columnExists = new HashSet<string>();

            foreach (var row in array)
            {
                if(row.IsBsonDocument)
                {
                    var doc = row.AsBsonDocument;
                    foreach (var name in doc.Names)
                    {
                        if(!columnExists.Contains(name))
                        {
                            columns.Add(name);
                            columnExists.Add(name);
                        }
                    }
                }
            }
            return columns;
        }

        private void ProcessShowCommand()
        {
            if(jsEdit.Text.Trim().EndsWith("users"))
            {
                ClearResult();
                WriteLine("Users:");
                foreach(var user in CurrentDB.FindAllUsers())
                    WriteLine(user.ToJson());
            }
            else if(jsEdit.Text.Trim().EndsWith("collections"))
            {
                ClearResult();
                foreach (var collectionName in CurrentDB.GetCollectionNames())
                    WriteLine(collectionName);    
            }
            else if(jsEdit.Text.Trim().EndsWith("dbs"))
            {
                ClearResult();
                foreach (var collectionName in _server.GetDatabaseNames())
                    WriteLine(collectionName);    
            }
        }

        public MongoDatabase CurrentDB
        {
            get{
                return _server.GetDatabase(this.dbCombo.Text);
            }
        }

        private void ShowAutoComplete()
        {
            var currentLine = jsEdit.Lines.Current.Text.Trim();
            if(currentLine == "db.")
            {
                jsEdit.AutoComplete.List = new List<string>(CurrentDB.GetCollectionNames());
                jsEdit.AutoComplete.Show();
            }
            else if(currentLine.StartsWith("db.") && currentLine.Count(x => x == '.') == 2)
            {
                var parts = currentLine.Split('.');
                
                //show commands
                jsEdit.AutoComplete.List = ShellContext.CollectionFunctions.ToList();
                jsEdit.AutoComplete.Show();
            }
            else if(currentLine.StartsWith("show"))
            {
                jsEdit.AutoComplete.List = ShellContext.ShowArgs.ToList();
                jsEdit.AutoComplete.Show();
            }
            else if(currentLine.StartsWith("use"))
            {
                jsEdit.AutoComplete.List = _server.GetDatabaseNames().ToList();
                jsEdit.AutoComplete.Show();
            }
            else
            {
                jsEdit.AutoComplete.List = ShellContext.Globals.ToList();
            }

        }

        private void jsEdit_AutoCompleteAccepted(object sender, ScintillaNET.AutoCompleteAcceptedEventArgs e)
        {
            if(jsEdit.Lines.Current.Text.StartsWith("use"))
                SwitchDB(e.Text);
        }

        private void jsEdit_CharAdded(object sender, ScintillaNET.CharAddedEventArgs e)
        {
            if(e.Ch == '.')
            {
                ShowAutoComplete();
            }
            else if(e.Ch == ' ')
            {
                if(jsEdit.Lines.Current.Text.StartsWith("show") || jsEdit.Lines.Current.Text.StartsWith("use"))
                    ShowAutoComplete();
            }
            else if(e.Ch == '(')
            {
                jsEdit.CallTip.Show("(jsonObject)");


            }
        }
    }
}
