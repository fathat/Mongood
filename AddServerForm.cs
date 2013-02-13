using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;

namespace MongoAdmin
{
    public partial class AddServerForm : Form
    {
        private MainForm MainForm { get; set; }

        public AddServerForm(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hostname = Hostname.Text;
            this.Close();
            MainForm.AddServer(hostname);
        }

        private void Hostname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var hostname = Hostname.Text;
                this.Close();
                MainForm.AddServer(hostname);
            }
        }

        
    }
}
