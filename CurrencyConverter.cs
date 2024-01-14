using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomponentovaTvorba
{
    public class CurrencyConverter
    {
        Dictionary<string, string> symbols;
        public Dictionary<string, string> GetSymbols()
        {
            if (symbols == null)
            {
                symbols = new Dictionary<string, string>();
                string responseContent = getResponseString("fixer/symbols");

                Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);
                if ((bool)responseData["success"])
                {
                    var tempSymbols = (JObject)responseData["symbols"];
                    symbols = tempSymbols.ToObject<Dictionary<string, string>>();
                }
            }
            return symbols;
        }


        private string getResponseString(string relativeURI)
        {
            var client = new RestClient("https://api.apilayer.com/");
            

            var request = new RestRequest(relativeURI, Method.Get);
            request.AddHeader("apikey", "********************************"); // Přidání API klíče do hlavičky žádosti
                                         
            RestResponse response = client.Execute(request); // Volání serveru
            return response.Content;
        }

        // Metoda pro převod měn
        internal double Convert(string fromCurrency, string toCurrency, double currencyAmount)
        {
            // Získání odpovědi ze serveru pro převod měn
            string responseContent = getResponseString($"fixer/convert?to={toCurrency}&from={fromCurrency}&amount={currencyAmount}");

            Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);

            /* Pokud je operace úspěšná, vrácení výsledku převodu */
            if ((bool)responseData["success"])
            {
                return (double)responseData["result"];
            }
            else
            {
                return - 1; // V případě neúspěchu vrácení hodnoty -1
            }
        }
    }
}
