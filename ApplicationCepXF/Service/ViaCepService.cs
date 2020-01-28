using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCepXF.Service.Model;
using System.Net;
using Newtonsoft.Json;

namespace ApplicationCepXF.Service
{
    public class ViaCepService
    {
        private static string url = "https://viacep.com.br/ws/{0}/json/";
        public static Adress AdressSearch(string cep)
        {
            Adress ret;
            string newAdress = string.Format(url, cep);
            WebClient wc = new WebClient();
            string json = wc.DownloadString(newAdress);
            ret = JsonConvert.DeserializeObject<Adress>(json);
            return ret;
        }

        
    }
}
