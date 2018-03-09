using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace REST_Client{

    public enum httpVerb {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class RestClient{
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient() {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest() {
            string strResponseValue = string.Empty;
            HttpWebRequest request;
            try {
                request = (HttpWebRequest)WebRequest.Create(endPoint);
                request.Method = httpMethod.ToString();
            }catch(Exception e) {
                return e.Message;
            }

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                if (response.StatusCode != HttpStatusCode.OK) {
                    throw new ApplicationException("Error code: " + response.StatusCode.ToString());
                }
                //Process the response stream (Could be JSON, XML, or HTML etc...)
                using (Stream responseStream = response.GetResponseStream()) {
                    if (responseStream != null) {
                        using (StreamReader reader = new StreamReader(responseStream)) {
                            strResponseValue = reader.ReadToEnd();
                        }//End of using StreamReader
                    }

                }//End of using ResponseStream
            }
            return strResponseValue;
        }
    }
}
