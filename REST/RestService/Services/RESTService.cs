using Rest.Exceptions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rest.Services
{
    public class RESTService<T> : IRESTService<T>
    {
        #region Propiedades
        private string _token;
        private string _uri;
        private T _entity;
        private IList<T> _entities;
        private HttpStatusCode _requestCodeResult;
        public HttpStatusCode RequestCodeResult { get { return _requestCodeResult; } }
        #endregion
       
        #region Constructor

        public RESTService(string uri, string token)
        {
            _uri = uri;
            _token = token;
        }

        public RESTService(string uri)
        {
            _uri = uri;
        }

        #endregion

        public T GetById(string id)
        {
            this.SearchEntityAsync(id);

            switch (this._requestCodeResult)
            {
                case HttpStatusCode.OK:
                    return this._entity;

                case HttpStatusCode.NotFound:
                    throw new NotResourceFoundException();

                default:
                    //Excepción genérica. Aquí habría que capturar el error específico devuelto en el código HTTP de la API y obrar
                    // en consecuencia
                    throw new InternalErrorException();
            }
        }

        public IList<T> GetByUrlParameter(string parameter)
        {
            this.SearchEntitiesAsync(parameter);

            switch (this._requestCodeResult)
            {
                case HttpStatusCode.OK:
                    return this._entities;

                case HttpStatusCode.NotFound:
                    throw new NotResourceFoundException();

                default:
                    //Excepción genérica. Aquí habría que capturar el error específico devuelto en el código HTTP de la API y obrar
                    // en consecuencia
                    throw new InternalErrorException();
            }
        }

        public T Post(T Entity)
        {
            this.ProccessEntityAsync(Entity);

            switch (this._requestCodeResult)
            {
                case HttpStatusCode.OK:
                    return this._entity;

                case HttpStatusCode.NotFound:
                    throw new NotResourceFoundException();

                default:
                    //Excepción genérica. Aquí habría que capturar el error específico devuelto en el código HTTP de la API y obrar
                    //en consecuencia
                    throw new InternalErrorException();
            }
        }

        public HttpStatusCode Delete(string id)
        {
            using (var Client = new HttpClient())
            {
                this.AddTokenInHeader(Client);
                String FullPath = this._uri + "/" + id;
                HttpResponseMessage response = Client.DeleteAsync(FullPath).Result;
                this._requestCodeResult = response.StatusCode;
                return response.StatusCode;
            }
        }

        public void Update(T entity, string id)
        {
            UpdateAsync(entity, id);
        }
  
        #region Metodos Privados

        //Este método tiene que buscar la entidad consumiento el método GET de la API REST y setear el atributo entity
        //Es la forma de evitar los Task/async/wait en las clases "clientes"

        private async void SearchEntityAsync(string id)
        {
            using (var Client = new HttpClient())
            {
                String FullPath = this._uri + "/" + id;
                this.AddTokenInHeader(Client);

                HttpResponseMessage response = Client.GetAsync(FullPath).Result;

                if (response.IsSuccessStatusCode)
                {
                    this._entity = await response.Content.ReadAsAsync<T>();
                }

                this._requestCodeResult = response.StatusCode;

            }
        }

        private async void SearchEntitiesAsync(string paramater)
        {
            using (var Client = new HttpClient())
            {
                String FullPath = this._uri + "/" + paramater;
                this.AddTokenInHeader(Client);

                HttpResponseMessage response = Client.GetAsync(FullPath).Result;

                if (response.IsSuccessStatusCode)
                {
                    this._entities = await response.Content.ReadAsAsync<IList<T>>();
                }
                this._requestCodeResult = response.StatusCode;

            }
        }

        private async void ProccessEntityAsync(T Entity)
        {
            using (var Client = new HttpClient())
            {
                this.AddTokenInHeader(Client);

                HttpResponseMessage response = Client.PostAsJsonAsync(this._uri, Entity).Result;

                if (response.IsSuccessStatusCode)
                {
                    this._entity = await response.Content.ReadAsAsync<T>();
                }
                this._requestCodeResult = response.StatusCode;
            }

        }

        private void AddTokenInHeader(HttpClient Client)
        {
            string authenticationHeader = "Authentication";
            if (!String.IsNullOrEmpty(_token))
            {
                Client.DefaultRequestHeaders.Add(authenticationHeader, _token);
            }
        }

        private async void UpdateAsync(T entity, string id)
        {
            using (var Client = new HttpClient())
            {
                this.AddTokenInHeader(Client);
                String FullPath = this._uri + "/" + id;
                HttpResponseMessage response = Client.PutAsJsonAsync(FullPath, entity).Result;

                if (response.IsSuccessStatusCode)
                {
                    this._entity = await response.Content.ReadAsAsync<T>();
                }
                this._requestCodeResult = response.StatusCode;

                //response.EnsureSuccessStatusCode();
                // Deserialize the updated product from the response body.
            }
        }

        #endregion

    }
}
