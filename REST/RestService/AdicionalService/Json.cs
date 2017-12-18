using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Text;
using System;

using System.Threading; 
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using System.Collections.Specialized;


namespace Rest
{
    public class Json
    {
        public string GetServicio(string Uri)
        {
            string ResultadoJson = string.Empty;
            var request = WebRequest.Create(Uri);
            var response = (HttpWebResponse)request.GetResponse();

            using (var Srv = new StreamReader(response.GetResponseStream()))
            {
                ResultadoJson = Srv.ReadToEnd();
            }

            return ResultadoJson;
        }

        public T GetServicio<T>(string Uri)
        {
            string ResultadoJson = string.Empty;
            var request = WebRequest.Create(Uri);
            var response = (HttpWebResponse) request.GetResponse();

            using (var Srv = new StreamReader(response.GetResponseStream()))
            {
                ResultadoJson = Srv.ReadToEnd();
            }

            var responseData = Deserialize<T>(ResultadoJson);

            return responseData;
        }

        public string PostServicios(string Uri, string Json)
        {
            string ResultadoJson = string.Empty;

            var request = (HttpWebRequest)WebRequest.Create(Uri);
            byte[] BytePost = Encoding.UTF8.GetBytes(Json);

            request.Method = "POST";
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";
            request.ContentLength = BytePost.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(BytePost, 0, BytePost.Length);
            requestStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                ResultadoJson = rdr.ReadToEnd();
            }

            return ResultadoJson;
        }

        public T PostServicios<T>(string Uri, T bodyData)
        {
            string ResultadoJson = string.Empty;
            string Json = string.Empty;

            Json = Serialize(bodyData);

            var request = (HttpWebRequest)WebRequest.Create(Uri);
            byte[] BytePost = Encoding.UTF8.GetBytes(Json);

            request.Method = "POST";
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";
            request.ContentLength = BytePost.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(BytePost, 0, BytePost.Length);
            requestStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                ResultadoJson = rdr.ReadToEnd();
            }

            var responseData = Deserialize<T>(ResultadoJson);

            return responseData;
        }

        public string PutServicios(string Uri, string Json)
        {
            string ResultadoJson = string.Empty;

            ////List<CampanaPresupuesto> ColeccionCampanaPresupuesto = JsonConvert.DeserializeObject<List<CampanaPresupuesto>>(ResultadoJson);

            var request = (HttpWebRequest)WebRequest.Create(Uri);
            byte[] BytePost = Encoding.UTF8.GetBytes(Json);

            request.Method = "PUT";
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";
            request.ContentLength = BytePost.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(BytePost, 0, BytePost.Length);
            requestStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                ResultadoJson = rdr.ReadToEnd();
            }

            return ResultadoJson;
        }

        public T PutServicios<T>(string Uri, T bodyData)
        {
            string ResultadoJson = string.Empty;
            string Json = string.Empty;

            Json = Serialize(bodyData);

            var request = (HttpWebRequest)WebRequest.Create(Uri);
            byte[] BytePost = Encoding.UTF8.GetBytes(Json);

            request.Method = "PUT";
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";
            request.ContentLength = BytePost.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(BytePost, 0, BytePost.Length);
            requestStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                ResultadoJson = rdr.ReadToEnd();
            }

            var responseData = Deserialize<T>(ResultadoJson);

            return responseData;
        }

        public static void MakeAsyncRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json; charset=utf-8"; 
            request.Method = WebRequestMethods.Http.Get;
            request.Timeout = 30000;
            request.Proxy = null;

            request.BeginGetResponse(new AsyncCallback(ReadCallback), request);
        }

        private static void ReadCallback(IAsyncResult asyncResult)
        {
            HttpWebRequest request = (HttpWebRequest)asyncResult.AsyncState;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(asyncResult))
                {
                    Stream responseStream = response.GetResponseStream();
                    using (StreamReader sr = new StreamReader(responseStream))
                    {
                        //Need to return this response 
                        string strContent = sr.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string Serialize(object data)
        {
            string serialized = JsonConvert.SerializeObject(data);
            return serialized;
        }

        private T Deserialize<T>(string serialized)
        {
            var data = JsonConvert.DeserializeObject<T>(serialized);
            return data;
        }
    }
}
