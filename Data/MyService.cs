using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

//Newtonsoft.Json.Linq;


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

            string dummy = File.ReadAllText(filepath);
            Console.WriteLine(dummy);
            string result = string.Empty;
            /*
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                var jobj = JObject.Parse(json);       
                result = jobj.ToString();
                Console.WriteLine(result);              
            }
            */
            //File.WriteAllText(filepath, result);
            //return 'a';
        }
    }
}
