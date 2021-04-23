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
    public class MyService
    {
        public void MyServiceHellow()
        {
            Console.WriteLine("hello-myservice");
        }
        public void Write(string str)
        {
            Console.WriteLine(str);
        }
        /*
        public void ReadJson()
        {
            var x = Read
            Console.WriteLine(x);
        }*/
        //public static void ReplaceJsonValue()
        public void ReadJson()
        {
            string filepath = "./Data/test.json";

            //string dummy = File.ReadAllText(filepath);
            /*
            var ms = new MemoryStream(Encoding.UTF8.GetBytes((dummy)));
            string result = string.Empty;
            ms.Seek(0, SeekOrigin.Begin);
            var data = serializer.ReadObject(ms) as JsonData;
            Console.WriteLine(data);
            */
            
           　using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                var jobj = JObject.Parse(json);       
                var result = jobj.ToString();
                Console.WriteLine(jobj);
                Console.WriteLine(result);           
            }
            
            //File.WriteAllText(filepath, result);
            //return 'a';
        }


    }
    [DataContract]
    public class JsonData
    {
        //[DataMember(Name = "@test")]
        //public string[] Context { get; set; }
        [DataMember(Name = "test")] //データメンバ属性
        public string Value { get; set; }
    }
}
