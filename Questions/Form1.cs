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
using System.Xml;
using System.Xml.Serialization;
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

        private async void button4_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                await Task.Delay(1);
                ExchangeOperations.LoadRatesAsync();
            });


            decimal amount = 4;
            decimal conversionNum = (amount / ExchangeOperations.ExchangeRateToEuro["USD"]) * 
                                    ExchangeOperations.ExchangeRateToEuro["GBP"];

            Debug.WriteLine(conversionNum.ToString("0.00"));
        }
    }

    class MyClass
    {
        private double? _Width;
        [XmlIgnore]
        public double? WidthRound
        {
            get => _Width;
            set
            {
                if (value != null) _Width = Math.Round(value.Value, 2);
            }
        }
        [XmlText]
        [XmlElement("WidthRound")]
        public string WidthRoundValue
        {
            get => WidthRound == null ? null : XmlConvert.ToString(WidthRound.Value);
            set
            {
                if (value != null)
                {
                    WidthRound = XmlConvert.ToDouble(value);
                }
                else
                {
                    WidthRound = null;
                }
            }
        }
    }
}
