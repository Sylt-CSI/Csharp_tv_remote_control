using System;
using System.IO;
using System.Net;


namespace WebApplication2.CommunicationProtocols
{
    public class JSONMessageSender {
        public JSONMessageSender(string JSONMessage, string address = "http://192.168.0.155/sony/system", string requestMethod = "POST"){
            Result = SendJSONMessage(JSONMessage, address, requestMethod);
        }

        private string SendJSONMessage(string JSONMessage, string webAddress, string method)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddress);
            httpWebRequest.ContentType = "applictation/json-rpc";
            httpWebRequest.Method = method;
            // Convert string into JSON.
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JSONMessage;

                streamWriter.Write(json);
            }
            // Response from device
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            // Convert JSON response to string;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }

        public string Result { get; private set; }
    }
}
