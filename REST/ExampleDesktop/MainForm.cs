using Model;
using Rest.Exceptions;
using Rest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDesktop
{
    public partial class MainForm : Form
    {
        private IRESTService<Product> _RESTProductService;

        public MainForm()
        {
            InitializeComponent();
            String ApiResourcePath = "http://localhost:51249/api/Product";
            _RESTProductService = new RESTService<Product>(ApiResourcePath, Statics.Token);
        }

        private void CleanLabelProduct()
        {
            this.ProductDescription.Text = String.Empty;
            this.ProductId.Text = String.Empty;
        }
        private void CleanLabelPutProduct()
        {
            this.txtDescripcionPut.Text = String.Empty;
            this.txtIdPut.Text = String.Empty;
        }

        private void SetEstado(String Message)
        {
            this.lblEstado.Text = "Estado: " + Message;
        }

        private void MainForm_Load(object sender, EventArgs e) { }

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product()
                {
                    //ProductId = "0", /// NO el ID lo tiene luego de crear el objeto
                    ProductDescription = txtDescriptionProductPost.Text
                };

                Product productCreated = _RESTProductService.Post(product);
                this.SetEstado("Se creo el producto " + productCreated.ProductDescription + " id: " + productCreated.ProductId);
            }
            catch (InternalErrorException)
            {
                this.SetEstado("Error al crear el producto");
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                String ProductId = txtIdProductGet.Text;
                Product product = _RESTProductService.GetById(ProductId);
                CleanLabelProduct();
                this.ProductDescription.Text = product.ProductDescription;
                this.ProductId.Text = product.ProductId;
                this.SetEstado("Se obtuvo el producto correctamente");
            }
            catch (NotResourceFoundException)
            {
                this.SetEstado("No existe el produto con id: " + txtIdProductGet.Text);
            }
            catch (InternalErrorException)
            {
                this.SetEstado("Error al obtener el producto");
            }


        }

        private void btnPut_Click(object sender, EventArgs e)
        {
            try
            {
                string ProductId = txtIdPut.Text;
                Product productOld = new Product()
                {
                    //ProductId = "0", /// NO el ID lo tiene luego de crear el objeto
                    ProductDescription = txtDescripcionPut.Text
                };

                _RESTProductService.Update(productOld, ProductId);
                CleanLabelProduct();
                //this.ProductDescription.Text = product.ProductDescription;
                //this.ProductId.Text = product.ProductId;
                this.SetEstado("Se actualizo el producto correctamente");
            }
            catch (NotResourceFoundException)
            {
                this.SetEstado("No existe el produto con id: " + txtIdProductGet.Text);
            }
            catch (InternalErrorException)
            {
                this.SetEstado("Error al actualizar el producto");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string ProductId = txtIdDelete.Text;
                var statusCode = _RESTProductService.Delete(ProductId);
                this.SetEstado("Se actualizo el producto correctamente");
            }
            catch (NotResourceFoundException)
            {
                this.SetEstado("No existe el produto con id: " + txtIdProductGet.Text);
            }
            catch (InternalErrorException)
            {
                this.SetEstado("Error al obtener el producto");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGetFilter_Click(object sender, EventArgs e)
        {
            try
            {
                //---
                string desc = txtDescripcionGetFilter.Text;
                var product2 = _RESTProductService.GetByUrlParameter("?descripcion=" + desc + "&id=0");
                this.lblCantidadGet.Text = product2?.Count().ToString();

                this.SetEstado("Se obtuvo el producto correctamente");
            }
            catch (NotResourceFoundException)
            {
                this.SetEstado("No existe el produto con id: " + txtIdProductGet.Text);
            }
            catch (InternalErrorException)
            {
                this.SetEstado("Error al obtener el producto");
            }

        }

        private void btnAdmedia_Click(object sender, EventArgs e)
        {
            FrmSoporteAdmedia frm = new FrmSoporteAdmedia();
            frm.Show();
        }
    }
}
