using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Rest.Services
{
    public interface IRESTService<T>
    {
        T GetById(string id);

        IList<T> GetByUrlParameter(string parameter);

        T Post(T Entity);

        HttpStatusCode Delete(string id);

        void Update(T entity, string id);

    }
}
