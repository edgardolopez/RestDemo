using Rest.Exceptions;
using Rest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Services
{
    public class LoginService
    {
        private User _user;
        private string _uri;
        private HttpStatusCode _requestCodeResult;
        public HttpStatusCode RequestCodeResult { get { return _requestCodeResult; } }

        public LoginService(string uri)
        {
            this._uri = uri;
        }

        public User Login(User user)
        {
            ProccessLogin(user);

            switch (this._requestCodeResult)
            {
                case HttpStatusCode.OK:
                    return this._user;
                case HttpStatusCode.NotFound:
                    throw new NotResourceFoundException();
                default:
                    //Excepción genérica. Aquí habría que capturar el error específico devuelto en el código HTTP de la API y obrar
                    //en consecuencia
                    throw new InternalErrorException();
            }
        }

        private async void ProccessLogin(User user)
        {
            using (var Client = new HttpClient())
            {
                HttpResponseMessage response = Client.PostAsJsonAsync(this._uri, user).Result;

                if (response.IsSuccessStatusCode)
                {
                    this._user = await response.Content.ReadAsAsync<User>();
                }
                this._requestCodeResult = response.StatusCode;
            }
        }

    }
}
