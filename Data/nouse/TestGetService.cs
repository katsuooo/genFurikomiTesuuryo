using System;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Collections.Generic;

namespace genFurikomiTesuuryo.Data
{
    public class TestGetService
    {
        /*
        public Task<TestGet[]> GetTestGetAsync()
        {
            string filepath = "./Data/test.json";   
            var jobj = new JObject {};
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                jobj = JObject.Parse(json);       
                var result = jobj.ToString();
                //Console.WriteLine(jobj);
                //Console.WriteLine(result);           
            }
            //return jobj;
            
            //return Task.FromResult(foreach(job_b in jobj)( job_d => new TestGet
            //{
            //    test = job_d.test;
            //}).ToArray());
            
                
            //return Task.FromResult(Enumerable.Range(0, 1).Select(index => new TestGet
            //{
            //    Test = (String)jobj[index]["test"]
            //}).ToArray());
            


            List<TestGet> list = new List<TestGet>();

            foreach (JObject xxx in jobj["x"])
            {
                list.Add(Task.FromResult(new TestGet{Test = xxx["test"]}));
            }

            return list.ToArray();
        }
        */
    }
}
//            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
//            {
//                Date = startDate.AddDays(index),
//                TemperatureC = rng.Next(-20, 55),
//                Summary = Summaries[rng.Next(Summaries.Length)]
//            }).ToArray());
        