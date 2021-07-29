
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

        public static IList<Menu> Menus
        {
            get
            {
                if (HttpContext.Current.Session["Menus"] == null)
                {
                    var ids = Usuario.Acessos.Select(x => x.Id);
                    var menus = new RepositorioMenu(NHibernateHttpModule.CurrentSession).ObterPorParametros(x => ids.Contains(x.Id)).ToList();
                    Menus = menus;

                }
                
                return HttpContext.Current.Session["Menus"] as IList<Menu>;
            }
            set
            {
                HttpContext.Current.Session["Menus"] = value;
            }
        }
    }
}