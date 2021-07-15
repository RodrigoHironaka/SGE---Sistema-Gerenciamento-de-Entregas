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
    public partial class frmClienteConsulta : Form
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
        private RepositorioCliente _repositorio;

        public RepositorioCliente Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioCliente(Session);
                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion
        public frmClienteConsulta()
        {
            InitializeComponent();
        }

        private void CarregaDados()
        {
            grdConsulta.DataSource = Repositorio.ObterTodos().OrderBy(x => x.Nome).ToList();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            frmClienteCadastro frm = new frmClienteCadastro(new Cliente(), Session);
            if (frm.ShowDialog() == DialogResult.OK)
                CarregaDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    cliente = (Cliente)gvwConsulta.GetRow(handler);
                }
            }
            if (cliente != null)
            {
                frmClienteCadastro frm = new frmClienteCadastro(cliente, Session);
                if (frm.ShowDialog() == DialogResult.OK)
                    CarregaDados();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    cliente = (Cliente)gvwConsulta.GetRow(handler);
                }
            }
            if (cliente != null)
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro: " + cliente.Nome + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d.ToString() == "Yes")
                {
                    Repositorio.Excluir(cliente);
                    CarregaDados();
                }
            }
        }

        private void frmClienteConsulta_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
    }
}
