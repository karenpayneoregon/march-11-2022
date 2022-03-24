using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Questions.Classes
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/answers/questions/451297/read-currency-rate-details-available-from-web.html
    /// </summary>
    public class ExchangeOperations
    {
        public static readonly Dictionary<string, decimal> ExchangeRateToEuro = new();
        public static List<string> FromCurrency = new();
        public static List<string> ToCurrency = new();


        public static void LoadRatesAsync()
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            
            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
            {
                ExchangeRateToEuro.Add(node.Attributes["currency"].Value, decimal.Parse(node.Attributes["rate"].Value));
                FromCurrency.Add(node.Attributes["currency"].Value);
                ToCurrency.Add(node.Attributes["currency"].Value);
            }
        }
    }
}
