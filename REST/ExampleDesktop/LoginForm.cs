using Rest.Exceptions;
using Rest.Model;
using Rest.Services;
using System;
using System.Windows.Forms;

namespace ExampleDesktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SetLoginError(String Message)
        {
            this.UsernameTxt.Text = String.Empty;
            this.PasswordTxt.Text = String.Empty;
            this.ErrorMessage.Text = Message;
        }

        private void LaunchMainForm()
        {
            this.Hide();
            var MainForm = new MainForm();
            MainForm.Show();
        }

        private User GetUser()
        {
            return new User()
            {
                UserName = this.UsernameTxt.Text,
                Password = this.PasswordTxt.Text
            };

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string urlLogin = "http://localhost:51249/api/User/";
                LoginService loginService = new LoginService(urlLogin);
                User user = GetUser();
                var userLogin = loginService.Login(user);
                Statics.Token = userLogin.Token;
                this.LaunchMainForm();
            }
            catch (NotResourceFoundException)
            {
                this.SetLoginError("Usuario o contraseña invalida");
            }
            catch (InternalErrorException)
            {
                this.SetLoginError("Error al intentar logear");
            }
        }
    }
}
