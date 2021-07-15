using NHibernate;
using SGE.Repositorio.Configuracao;
using SGE.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.App.Formularios
{
    public partial class frmEntregaConsulta : Form
    {
        #region Session
        private static ISession session;
        protected static ISession Session
        {
            get
            {
                if (session == null || !session.IsOpen)
                {
                    if (session != null)
                        session.Dispose();
                    session = NHibernateHelper.GetSession();
                }
                return session;
            }
        }
        #endregion

        #region Repositorio
        private RepositorioEntrega _repositorio;

        public RepositorioEntrega Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioEntrega(Session);
                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion
        public frmEntregaConsulta()
        {
            InitializeComponent();
        }
        private void CarregaDados()
        {
            grdConsulta.DataSource = Repositorio.ObterTodos().ToList();
        }

        private void frmEntregaConsulta_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
    }
}
