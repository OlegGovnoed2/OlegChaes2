using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
            string endpoint = "/reactor/data?team_id=" + id;
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
            string endpoint = "/reactor/history?team_id=" + id;
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

        public string createReactor(int id)
        {


            return "Реактор команды " + id.ToString() + " создан ";
        }
    }
    
}
