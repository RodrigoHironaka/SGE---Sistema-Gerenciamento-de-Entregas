
using SGE.Dominio.Entidades;
using SGE.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGE.Web.Utilitarios
{
    public class Configuracao
    {
        public static Usuario Usuario
        {
            get
            {
                if(HttpContext.Current.Session["Usuario"] == null)
                {
                    Usuario = new RepositorioUsuario(NHibernateHttpModule.CurrentSession).ObterPorId(long.Parse(HttpContext.Current.User.Identity.Name));

                }
                return HttpContext.Current.Session["Usuario"] as Usuario;
            }
            set
            {
                HttpContext.Current.Session["Usuario"] = value;
            }
        }
    }
}