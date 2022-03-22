using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Utilities.Classes;
using System.Windows.Forms;
using Questions.Classes;

namespace Questions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//public partial class Process

        private void button1_Click(object sender, EventArgs e)
        {
            UserProcess.Start("explorer.exe", 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserProcess.OpenDocumentFolder();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var p = new UserProcess { StartInfo = new ProcessStartInfo("C:\\Users\\paynek\\Documents") { UseShellExecute = true } };
            p.Start();

        }
    }
}
