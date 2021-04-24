using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text;
using Newtonsoft.Json.Linq;


namespace genFurikomiTesuuryo.Data
{
    public class GetCsvService
    {
        public void MyServiceHellow()
        {
            Console.WriteLine("hello-myservice");
        }
        public void Write(string str)
        {
            Console.WriteLine(str);
        }
        public void ReadJson()
        {
            string filepath = "./Data/test.json";
            
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                var jobj = JObject.Parse(json);       
                var result = jobj.ToString();
                Console.WriteLine(jobj);
                Console.WriteLine(result);           
            }

        }
        /**
         read data
        */
        public Task<GetJson1[]> GetJson1Async(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new GetJson1
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
            }).ToArray());
        }
        /**
        */
        public Task<GetJson2[]> GetJson2Async(DateTime startDate)
        {
            var rng = new Random();
            Console.WriteLine("rng --- " +  rng.Next(-20, 55).ToString());
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new GetJson2
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
            }).ToArray());
        }
        /**
        */
        public Task<String> GetJson3Async()
        {
            return Task.FromResult("aaa");
        }
        /**
         file string
        */
        public Task<String> GetJson4Async()
        {
            string filepath = "./Data/test.json";
            string result = new String("");
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                var jobj = JObject.Parse(json);       
                result = jobj.ToString();
                Console.WriteLine(jobj);
                Console.WriteLine(result);           
            }
            return Task.FromResult(result);
        }
        /**
         file object
        */
        public Task<JObject> GetJson5Async()
        {
            string filepath = "./Data/test2.json";
            string result = new String("");
            //JObject jobj = new jObject();
            var json = new String("");
            using (StreamReader r = new StreamReader(filepath))
            {
                //var json = r.ReadToEnd();
                //jobj = JObject.Parse(json);       
                //result = jobj.ToString();        
                json = r.ReadToEnd();
            };
            var jobj = JObject.Parse(json);
            return Task.FromResult(jobj);
        }
    }
}
