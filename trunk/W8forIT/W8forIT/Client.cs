using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace W8forIT
{
    public class Client
    {
        public void ConnectToServer(string url, string jsonData)
        {
            //string url = @"http://localhost:3723/sedcup2013/teams/Client1";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            setAuthInfo(request);
            request.Method = "POST";
            request.ContentType = "application/json";
            if (!string.IsNullOrEmpty(jsonData))
            {
                Stream requestStream = request.GetRequestStream();
                byte[] restData = Encoding.UTF8.GetBytes(jsonData);
                requestStream.Write(restData, 0, restData.Length);
                requestStream.Close();
            }
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string res = reader.ReadToEnd();
                    Console.WriteLine("Received content: " + res);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepion occured while connecting to the server" + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void setAuthInfo(HttpWebRequest request)
        {
            string authInfo = "login" + ":" + "secret";
            authInfo = Convert.ToBase64String(Encoding.UTF8.GetBytes(authInfo));
            request.Headers["Authorization"] = "Basic " + authInfo;
        }
    }
}
