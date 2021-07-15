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
    public partial class frmFormaPagamentoConsulta : Form
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
        private RepositorioFormaPagamento _repositorio;

        public RepositorioFormaPagamento Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioFormaPagamento(Session);
                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion
        public frmFormaPagamentoConsulta()
        {
            InitializeComponent();
        }

        private void CarregaDados()
        {
            grdConsulta.DataSource = Repositorio.ObterTodos().OrderBy(x => x.Nome).ToList();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            frmFormaPagamentoCadastro frm = new frmFormaPagamentoCadastro(new FormaPagamento(), Session);
            if (frm.ShowDialog() == DialogResult.OK)
                CarregaDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            FormaPagamento formaPagamento = null;
            if(gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    formaPagamento = (FormaPagamento)gvwConsulta.GetRow(handler);
                }
            }
            if (formaPagamento != null)
            {
                frmFormaPagamentoCadastro frm = new frmFormaPagamentoCadastro(formaPagamento, Session);
                if (frm.ShowDialog() == DialogResult.OK)
                    CarregaDados();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            FormaPagamento formaPagamento = null;
            if(gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    formaPagamento = (FormaPagamento)gvwConsulta.GetRow(handler);
                }
            }
            if(formaPagamento != null)
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d.ToString() == "Yes")
                {
                    Repositorio.Excluir(formaPagamento);
                    CarregaDados();
                }
            }
        }

        private void frmFormaPagamentoConsulta_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
    }
}
