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
    public partial class frmCidadeConsulta : Form
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
        private RepositorioCidade _repositorio;

        public RepositorioCidade Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioCidade(Session);
                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion
        public frmCidadeConsulta()
        {
            InitializeComponent();
        }

        private void CarregaDados()
        {
            grdConsulta.DataSource = Repositorio.ObterTodos().OrderBy(x => x.Nome).ToList();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            frmCidadeCadastro frm = new frmCidadeCadastro(new Cidade(), Session);
            if (frm.ShowDialog() == DialogResult.OK)
                CarregaDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            Cidade cidade = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    cidade = (Cidade)gvwConsulta.GetRow(handler);
                }
            }
            if (cidade != null)
            {
                frmCidadeCadastro frm = new frmCidadeCadastro(cidade, Session);
                if (frm.ShowDialog() == DialogResult.OK)
                    CarregaDados();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Cidade cidade = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    cidade = (Cidade)gvwConsulta.GetRow(handler);
                }
            }
            if (cidade != null)
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro: "+ cidade.NomeCompleto +"?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d.ToString() == "Yes")
                {
                    Repositorio.Excluir(cidade);
                    CarregaDados();
                }
            }
        }

        private void frmCidadeConsulta_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
    }
}
