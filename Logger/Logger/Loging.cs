using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger
{
    public partial class Loging : Form
    {
        string tempLog;
        string tempEmne;
        
        public Loging()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Writer ToLogs = new Writer();
            ToLogs._Logger(tempLog,tempEmne);
        }

        private void Emne_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            tempEmne = ToEmne.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox loggings = (TextBox)sender;
            tempLog = loggings.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ListeAfLogs().Show();
        }
    }
}
