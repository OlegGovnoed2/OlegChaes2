using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
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
                string content1  = await response.Content.ReadAsStringAsync();
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
            Dictionary<string, object> data = new Dictionary<string, object>();
            data["code"] = "error";
            var response = await client.GetAsync(baseurl+ endpoint);
            if (response != null)
            {
                string content1 = await response.Content.ReadAsStringAsync();
                StringReader csr = new StringReader(content1);
                var content = new JsonTextReader(csr);
                JsonSerializer serializer = new JsonSerializer();
                Dictionary<string, string> content2 = serializer.Deserialize<Dictionary<string, string>>(content);
                if (!content2.ContainsKey("code"))
                {
                    
                    csr = new StringReader(content2["reactor_state"]);
                    var c = new JsonTextReader(csr);
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
            data.Add( "error");
            var response = await client.GetAsync(baseurl + endpoint);
            if (response != null)
            {
                string content1 = await response.Content.ReadAsStringAsync();
                StringReader csr = new StringReader(content1);
                var content = new JsonTextReader(csr);
                JsonSerializer serializer = new JsonSerializer();
                Dictionary<string, string> content2 = serializer.Deserialize<Dictionary<string, string>>(content);
                if (!content2.ContainsKey("code"))
                {

                    csr = new StringReader(content2["data"]);
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
        public async Task<string > resetReactor(string id)
        {
            var client = new HttpClient();
            string endpoint = "reactor/reset_reactor?team_id=" + Convert.ToString(id);
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
            return "Реактор команды " + id.ToString() + " сборшен ";
        }
        public async Task<string> emergencyShutdown(string id)
        {
            var client = new HttpClient();
            string endpoint = "reactor/emergency-shutdown?team_id=" + Convert.ToString(id);
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
            return "Реактор команды " + id.ToString() + " остановлен ";
        }
        public async Task<string> refillWater(string id, float amount)
        {
            var client = new HttpClient();
            string endpoint = "reactor/refill_water?team_id=" + Convert.ToString(id) + "&amount=" + Convert.ToString(amount);
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
            return "Реактор команды " + id + " долит водой на " + Convert.ToString(amount) ;
        }
        public async Task<string> activateCooling(string id, int amount)
        {
            var client = new HttpClient();
            string endpoint = "reactor/activate_cooling?team_id=" + Convert.ToString(id) + "&amount=" + Convert.ToString(amount);
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
            return "Реактор команды " + id + " охлажден на " + Convert.ToString(amount);
        }
    }
    
}
