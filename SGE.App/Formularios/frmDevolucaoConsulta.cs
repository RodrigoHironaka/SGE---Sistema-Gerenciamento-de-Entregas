using NHibernate;
using SGE.Dominio.Entidades;
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
    public partial class frmDevolucaoConsulta : Form
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
        private RepositorioDevolucao _repositorio;

        public RepositorioDevolucao Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioDevolucao(Session);
                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion

        #region Repositorio Preparação
        private RepositorioPreparacao _repositorioPreparacao;

        public RepositorioPreparacao RepositorioPreparacao
        {
            get
            {
                if (_repositorioPreparacao == null)
                    _repositorioPreparacao = new RepositorioPreparacao(Session);
                return _repositorioPreparacao;
            }
            set { _repositorioPreparacao = value; }
        }
        #endregion

        public frmDevolucaoConsulta()
        {
            InitializeComponent();
        }

        private void CarregaDados()
        {
            grdConsulta.DataSource = Repositorio.ObterTodos().ToList().Select(x => x.Preparacao);
        }

        private void frmDevolucaoConsulta_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

            Preparacao preparacao = null; 
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    preparacao = (Preparacao)gvwConsulta.GetRow(handler);
                }
            }
            if (preparacao != null)
            {
                frmDevolucaoCadastro frm = new frmDevolucaoCadastro(preparacao, Session);
                if (frm.ShowDialog() == DialogResult.OK)
                    CarregaDados();
            }
        }
    }
}
