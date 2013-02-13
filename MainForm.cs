using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoAdmin.Properties;
using MongoDB.Driver;

namespace MongoAdmin
{
    public partial class MainForm : Form
    {
        public List<MongoServer> MongoServers { get; set; }

        MongoServer _SelectedServer = null;
        MongoCollection _SelectedCollection = null;
        MongoDatabase _SelectedDatabase;


        public MainForm()
        {
            MongoServers = new List<MongoServer>();
            InitializeComponent();

            //parse servers in list
            if(!String.IsNullOrEmpty(Properties.Settings.Default.PreviouslyOpenedServers))
            {
                var servers = Settings.Default.PreviouslyOpenedServers.Split(',');

                foreach (var server in servers)
                {
                    AddServer(server);
                }
            }
        }

        public void RefreshServerList()
        {
            ServerBrowser.Nodes.Clear();
            foreach (var server in MongoServers)
            {
                var serverRoot = ServerBrowser.Nodes.Add(server.Settings.Server.Host, server.Settings.Server.Host, 0, 0);
                serverRoot.Tag = server;
                var databases = server.GetDatabaseNames();
                foreach (var db in databases)
                {
                    var databaseRoot = serverRoot.Nodes.Add(db, db, 1, 1);
                    
                    var database = server.GetDatabase(db);
                    databaseRoot.Tag = database;

                    var collections = database.GetCollectionNames();
                    foreach (var collection in collections)
                    {
                        var cnode = databaseRoot.Nodes.Add(collection, collection, 2, 3);
                        cnode.Tag = database.GetCollection(collection);
                    }
                }
            }

        }

        private void OnDatabaseTreeAfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateSelectedServer(e);
        }

        public void AddServer(string hostname)
        {
            //check for duplicates
            if(MongoServers.Any(x => x.Primary.Address.Host == hostname))
                return;;
            
            try
            {
                var server = new MongoServer(new MongoServerSettings { Server = new MongoServerAddress(hostname) });

            
                server.Ping();
                
                this.MongoServers.Add(server);
                this.RefreshServerList();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("OH NO: " + e.Message);
            }
        }

        private void UpdateSelectedServer(TreeViewEventArgs e)
        {
            var obj = e.Node.Tag;
            
            if(obj is MongoServer)
            {
                _SelectedServer = obj as MongoServer;
                _SelectedCollection = null;
                _SelectedDatabase = null;
                _PropertyGrid.SelectedObject = null;
                disconnectToolStripMenuItem.Visible = true;
                dropToolStripMenuItem.Visible = false;
            }
            else if(obj is MongoDatabase)
            {
                _SelectedServer = (obj as MongoDatabase).Server;
                _SelectedDatabase = obj as MongoDatabase;
                _SelectedCollection = null;
                _PropertyGrid.SelectedObject = _SelectedDatabase.GetStats();
                disconnectToolStripMenuItem.Visible = false;
                dropToolStripMenuItem.Visible = true;
                
            }
            else if(e.Node.Tag is MongoCollection)
            {
                var c = (obj as MongoCollection);
                _SelectedServer = c.Database.Server;
                _SelectedDatabase = c.Database;
                _SelectedCollection = c;
                _PropertyGrid.SelectedObject = _SelectedCollection.GetStats();
                disconnectToolStripMenuItem.Visible = false;
                dropToolStripMenuItem.Visible = true;
            }
            else
            {
                _SelectedServer = null;
                _SelectedDatabase = null;
                _SelectedCollection = null;
                _PropertyGrid.SelectedObject = null;
                dropToolStripMenuItem.Visible = true;
                disconnectToolStripMenuItem.Visible = false;
            }

            

            _newQueryBtn.Enabled = _SelectedServer != null;
        }

        int queryNumber = 1;
        private void OnNewQuery(object sender, EventArgs e)
        {
            
            //Establish DB connection
            queryNumber ++;
            var page = new TabPage("Query #" + queryNumber);
            var qv = new QueryView(_SelectedServer, _SelectedDatabase, _SelectedCollection);
            qv.Dock = DockStyle.Fill;
            page.Controls.Add(qv);
            _queryTabControl.TabPages.Add(page);
            
        }

        private void OnAddServer(object sender, EventArgs e)
        {
            new AddServerForm(this).ShowDialog(this);
        }

        private void OnRefreshDBClick(object sender, EventArgs e)
        {
            this.RefreshServerList();
        }

        private void OnDinosaur(object sender, EventArgs e)
        {
            var settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost");

            

            try
            {
                var server = new MongoServer(settings);

                server.Ping(); //explode if dinosaur has been made sad
                
                AddServer("localhost");
                var page = new TabPage("Query #" + queryNumber);
                var qv = new QueryView(server, null, null);
                qv.Dock = DockStyle.Fill;
                page.Controls.Add(qv);
                _queryTabControl.TabPages.Add(page);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(ServerBrowser.SelectedNode.Tag is MongoCollection)
            {
                ServerBrowser.Nodes.Remove(ServerBrowser.SelectedNode.Parent.Parent);
            }
            else if(ServerBrowser.SelectedNode.Tag is MongoDatabase)
            {
                ServerBrowser.Nodes.Remove(ServerBrowser.SelectedNode.Parent);
            }
            else if(ServerBrowser.SelectedNode.Tag is MongoServer)
            {
                ServerBrowser.Nodes.Remove(ServerBrowser.SelectedNode);
            }
        }

        private void newQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNewQuery(sender, e);
        }

        private void ServerBrowser_DoubleClick(object sender, EventArgs e)
        {
            if(ServerBrowser.SelectedNode.Tag is MongoCollection)
                OnNewQuery(sender, e);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_queryTabControl.SelectedTab != null)
                _queryTabControl.TabPages.Remove(_queryTabControl.SelectedTab);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                Settings.Default.PreviouslyOpenedServers = String.Join(
                    ",", MongoServers.Where(x => x != null).Select(x => x.Primary.Address.Host)
                );

                Settings.Default.Save();
            }
            catch (Exception)
            {
                // this seems like a bad idea, but throwing an
                // exception on form close is REALLY ANNOYING (because
                // it won't let you close the form). So like, do
                // some logging and stuff at some point.
            }

        }

        private void OnDropSelected(object sender, EventArgs e)
        {
            var selected = ServerBrowser.SelectedNode;

            if(selected.Tag is MongoCollection)
            {
                var collection = (selected.Tag as MongoCollection);
                
                var result = MessageBox.Show("Are you sure you want to delete " + collection.FullName + "?", "Delete " + collection.Name, MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    collection.Drop();
                    selected.Remove();
                }
                
            }
            else if(selected.Tag is MongoDatabase)
            {
                var db = (selected.Tag as MongoDatabase);
                
                var result = MessageBox.Show("Are you sure you want to delete " + db.Name + "?", "Delete " + db.Name, MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    db.Drop();
                    selected.Remove();
                }
                
            }
        }

        private void ServerBrowser_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ServerBrowser_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                OnDropSelected(sender, e);
            }

            if(e.KeyCode == Keys.Enter)
            {
                OnNewQuery(sender, e);
            }
        }
    }
}
