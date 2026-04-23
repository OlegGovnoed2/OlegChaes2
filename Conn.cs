using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace OlegChaes2
{
    internal class Conn
    {
        private static void main(string[] args)
        {
            Conn conn = new Conn();

            string id = conn.regTeam().Result;
            Console.WriteLine(id);
        }
        public Conn() { }
        public Conn(string connName) { }

        //string id = "ac19afe4";

        string baseurl = "http://mephi.opentoshi.net/api/v1";

        public async Task<string> regTeam()
        {
            var client = new HttpClient();
            string endpoint = "/team/register";
            string id = "Error";
            var response = await client.GetAsync(baseurl + endpoint);
            if (response != null)
            {
                string content1 = await response.Content.ReadAsStringAsync();
                StringReader csr = new StringReader(content1);
                var content = new JsonTextReader(csr);
                JsonSerializer serializer = new JsonSerializer();
                Dictionary<string, Dictionary<string, string>> content2 = serializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(content);

                id = content2["data"]["team_id"];

            }
            return id;
        }

        public async Task<Dictionary<string, object>> getReactorDataTeam(string id)
        {
            var client = new HttpClient();
            string endpoint = "/reactor/data?team_id=" + Convert.ToString(id);
            Dictionary<string, object> predata = new Dictionary<string, object>();
            Dictionary<string, object> data = new Dictionary<string, object>();
            var response = await client.GetAsync(baseurl + endpoint);
            if (response != null)
            {
                string content1 = await response.Content.ReadAsStringAsync();
                StringReader csr = new StringReader(content1);
                var content = new JsonTextReader(csr);
                JsonSerializer serializer = new JsonSerializer();
                Dictionary<string, object> content2 = serializer.Deserialize<Dictionary<string, object>>(content);
                if (!content2.ContainsKey("code"))
                {
                    string ca = content2["data"].ToString();

                    csr = new StringReader(ca);
                    var c = new JsonTextReader(csr);
                    predata = serializer.Deserialize<Dictionary<string, object>>(c);
                    string cv = predata["reactor_state"].ToString();
                    csr = new StringReader (cv);
                     c = new JsonTextReader(csr);
                    data = serializer.Deserialize<Dictionary<string, object>>(c);
                }



            }

            return data;
        }

        public async Task<List<object>> getReactorHistoryTeam(string id)
        {
            var client = new HttpClient();
            string endpoint = "/reactor/history?team_id=" + Convert.ToString(id);
            List<object> data = new List<object>();
            data.Add("error");
            var response = await client.GetAsync(baseurl + endpoint);
            if (response != null)
            {
                string content1 = await response.Content.ReadAsStringAsync();
                StringReader csr = new StringReader(content1);
                var content = new JsonTextReader(csr);
                JsonSerializer serializer = new JsonSerializer();
                Dictionary<string, object> content2 = serializer.Deserialize<Dictionary<string, object>>(content);
                if (!content2.ContainsKey("code"))
                {
                    string ca = content2["data"].ToString();
                    csr = new StringReader(ca);
                    var c = new JsonTextReader(csr);
                    data = serializer.Deserialize<List<object>>(c);

                }



            }

            return data;
        }

        public async Task<string> createReactor(string id)
        {
            var client = new HttpClient();
            string endpoint = "reactor/create_reactor?team_id=" + Convert.ToString(id);
            Dictionary<string, object> data = new Dictionary<string, object>();
            data["code"] = "error";
            var json = "{}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(baseurl + endpoint, content);

            if (response != null)

            {
                var responseString = await response.Content.ReadAsStringAsync();
                StringReader csr = new StringReader(responseString);
                var content234 = new JsonTextReader(csr);
                JsonSerializer serializer = new JsonSerializer();

                data = serializer.Deserialize<Dictionary<string, object>>(content234);

            }
            return "Реактор команды " + id.ToString() + " создан ";
        }
        public async Task<string> resetReactor(string id)
        {
            var url = "http://mephi.opentoshi.net/api/v1/reactor/reset_reactor?team_id="+id;

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";



            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);

            return "Реактор команды " + id.ToString() + " сборшен ";
        }
        public async Task<string> emergencyShutdown(string id)
        {
            var url = "http://mephi.opentoshi.net/api/v1/reactor/emergency-shutdown?team_id=" + id;

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";



            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);
            return "Реактор команды " + id.ToString() + " остановлен ";
        }
        public async Task<string> refillWater(string id, double amount)
        {
            var client = new HttpClient();

            var url = baseurl + "/reactor/refill-water?team_id=" + Convert.ToString(id) + "&amount=" + Convert.ToString(amount); 

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";


            Console.WriteLine(url);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);
            return "Реактор команды " + id + " долит водой на " + Convert.ToString(amount);
        }
        public async Task<string> activateCooling(string id, int amount)
        {
            var client = new HttpClient();
            string endpoint = "/reactor/activate-cooling?team_id=" + Convert.ToString(id) + "&amount=" + Convert.ToString(amount);

            var httpRequest = (HttpWebRequest)WebRequest.Create(baseurl + endpoint);
            httpRequest.Method = "POST";

            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";


            Console.WriteLine(baseurl + endpoint);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            Console.WriteLine(httpResponse.StatusCode);
            return "Реактор команды " + id + " охлажден на " + Convert.ToString(amount);
        }
    }

}
