using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;

namespace ResumeScanner.Network
{
    class JobApi
    {
       
        private async Task<int> jobMatchFromApiAsync(string resume,string jd)
        {
            JSONData jsonData = new JSONData { ResumeData = resume, JD = jd };
            string jsonString;
            jsonString = JsonConvert.SerializeObject(jsonData);

            var responseString = await "http://127.0.0.1:5000/file"
              .PostUrlEncodedAsync(jsonData)
              .ReceiveString();

            int match = Convert.ToInt32(responseString);
            return match;
        }
    }

    internal class JSONData
    {

        public string ResumeData { get; set; }
        public string JD { get; set; }
    }
}
