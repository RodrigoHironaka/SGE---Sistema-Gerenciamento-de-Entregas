using Doctus.Utils.Text;

using SGE.Dominio.Entidades;
using SGE.Repositorio.Repositorios;
using SGE.Web.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SGE.Web.Controllers
{
    public class LoginController : Controller
    {
       
        #region Repositorio
        private RepositorioUsuario _repositorio;
        public RepositorioUsuario Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioUsuario(NHibernateHttpModule.CurrentSession);

                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion
        public ActionResult Entrar()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Entrar(string txtUser, string txtSenha)
        {
            if (!String.IsNullOrEmpty(txtUser) && !String.IsNullOrEmpty(txtSenha))
            {
                var usuario = Repositorio.ObterPorParametros(x => x.Login == txtUser).FirstOrDefault();

                if (usuario != null)
                {

                    if (usuario.Senha == Criptografia.GerarHashSHA1(txtSenha))
                    {
                        AutenticarUsuario(usuario);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                        TempData["Mensagem"] = "Senha Inválida!";
                }
                else
                    TempData["Mensagem"] = "Usuario não encontrado!";
            }
            else
                TempData["Mensagem"] = "Usuario ou Senha invalidos!";

            return View();
        }

        private void AutenticarUsuario(Usuario usuario)
        {
            FormsAuthenticationTicket authenticationTicket = new FormsAuthenticationTicket(
                                                    1,
                                                    usuario.Id.ToString(),
                                                    DateTime.Now,
                                                    DateTime.Now.AddHours(12), //.Add(FormsAuthentication.Timeout)
                                                    false,
                                                    usuario.TipoUsuario.ConverteEnumParaString());

            String encryptTicket = FormsAuthentication.Encrypt(authenticationTicket);
            HttpCookie authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptTicket);
            authCookie.Expires = authenticationTicket.Expiration;

            Response.Cookies.Add(authCookie);
            Configuracao.Usuario = usuario;
        }
    }
}