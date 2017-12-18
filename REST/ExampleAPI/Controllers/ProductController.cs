using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using ExampleAPI.Filters;
using System.Web.Http.Results;
using System.Threading.Tasks;

namespace ExampleAPI.Controllers
{
    [SecurityFilter]
    public class ProductController : ApiController
    {
        // GET: api/Product/5
        public IHttpActionResult Get(String id)
        {
            try
            {
                Product Product = Statics.Statics.Products.FirstOrDefault(x => x.ProductId == id);

                if (Product != null && Product.ProductId.Equals(id))
                {
                    return Ok(Product);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception Exception)
            {
                return new BadRequestErrorMessageResult(Exception.Message, this);
            }

        }

        public IHttpActionResult Get(string id, string descripcion)
        {
            try
            {
                //IList<Product> Products = Statics.Statics.Products.Where(x => descripcion.Contains(x.ProductDescription)).ToList();
                IList<Product> Products = Statics.Statics.Products.Where(x => x.ProductDescription.Contains(descripcion)).ToList();

                if (Products != null)
                {
                    return Ok(Products);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception Exception)
            {
                return new BadRequestErrorMessageResult(Exception.Message, this);
            }

        }

        public HttpResponseMessage Post(Product product)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.SelectMany(x => x.Value.Errors).Select(y => y.ErrorMessage).ToList();
                return Request.CreateResponse(HttpStatusCode.Forbidden, errors);
            }

            //Creo un ID con el maximo id existente en la lista
            int id = (Convert.ToInt32(Statics.Statics.Products.Max(x => Convert.ToInt32(x.ProductId)))) + 1;
            product.ProductId = id.ToString();

            Statics.Statics.Products.Add(product);
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        public HttpResponseMessage Put(Product product, int Id)
        {
            Statics.Statics.Products.FirstOrDefault(x => x.ProductId == Id.ToString()).ProductDescription = product.ProductDescription;

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        public HttpResponseMessage Delete(string id)
        {
            Product Product = Statics.Statics.Products.FirstOrDefault(x => x.ProductId == id);

            if (Product != null && Product.ProductId.Equals(id))
            {
                Statics.Statics.Products.Remove(Product);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }


    }
}
