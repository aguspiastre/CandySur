using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.BLL
{
    public class JsonHelper
    {
        public JsonHelper() { }

        public static string Read(string fileName, string location)
        {
            var path = Path.Combine(
            @"C:\github\CandySur\CandySur\CandySur.DLL\",
            location,
            fileName);

            string jsonResult = string.Empty;

            using (StreamReader streamReader = new StreamReader(path))
            {
                jsonResult = streamReader.ReadToEnd();
            }
            return jsonResult;
        }

        public static void Write(string fileName, string location, string jSONString)
        {
            var path = Path.Combine(
            @"C:\github\CandySur\CandySur\CandySur.DLL\",
            location,
            fileName);

            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(jSONString);
            }
        }
    }
}
