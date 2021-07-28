using NHibernate;

using SGE.Repositorio.Configuracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGE.Web.Utilitarios
{
    public class NHibernateHttpModule : IHttpModule
    {
        public const string KEY = "_TheSession_";
        private static ISession _session;

        public void Dispose() { }

        public void Init(HttpApplication application)
        {
            application.BeginRequest += (new EventHandler(this.context_BeginRequest));
            application.EndRequest += (new EventHandler(this.context_EndRequest));
        }

        private void context_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Items["_empresa_"] = "0";
            //context.Items[KEY] =  NHibernateHelper.GetSession();
            context.Items[KEY] = NHibernateHelper.GetSession();
        }

        private void context_EndRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;

            ISession session = context.Items[KEY] as ISession;
            if (session != null)
            {
                try
                {
                    session.Flush();
                    session.Close();
                }
                catch { }
            }
            context.Items[KEY] = null;
        }

        public static Int32 Empresa
        {
            get
            {
                try
                {
                    if (HttpContext.Current == null || HttpContext.Current.Items["_empresa_"] == null)
                        return 0;
                    else
                    {
                        HttpContext currentContext = HttpContext.Current;
                        string empresa = currentContext.Items["_empresa_"].ToString();
                        if (String.IsNullOrEmpty(empresa))
                            return 0;

                        return int.Parse(empresa);
                    }
                }
                catch (Exception)
                {

                    return 0;
                }
            }
            set
            {
                try
                {
                    HttpContext currentContext = HttpContext.Current;
                    currentContext.Items["_empresa_"] = value.ToString();
                }
                catch (Exception)
                {
                }
            }
        }
        public static ISession CurrentSession
        {
            get
            {
                if (HttpContext.Current == null)
                {
                    if (_session != null)
                        return _session;

                    _session = NHibernateHelper.GetSession();
                    return _session;
                }
                else
                {
                    HttpContext currentContext = HttpContext.Current;
                    ISession session = currentContext.Items[KEY] as ISession;
                    if (session == null)
                    {
                        session = NHibernateHelper.GetSession();
                        currentContext.Items[KEY] = session;
                    }
                    return session;
                }
            }
        }
    }
}