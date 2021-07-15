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
    public partial class frmColaboradorConsulta : Form
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
        private RepositorioColaborador _repositorio;

        public RepositorioColaborador Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioColaborador(Session);
                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion

        public frmColaboradorConsulta()
        {
            InitializeComponent();
        }

        private void CarregaDados()
        {
            grdConsulta.DataSource = Repositorio.ObterTodos().OrderBy(x => x.Nome).ToList();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            frmColaboradorCadastro frm = new frmColaboradorCadastro(new Colaborador(), Session);
            if (frm.ShowDialog() == DialogResult.OK)
                CarregaDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            Colaborador colaborador = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    colaborador = (Colaborador)gvwConsulta.GetRow(handler);
                }
            }
            if (colaborador != null)
            {
                frmColaboradorCadastro frm = new frmColaboradorCadastro(colaborador, Session);
                if (frm.ShowDialog() == DialogResult.OK)
                    CarregaDados();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Colaborador colaborador = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    colaborador = (Colaborador)gvwConsulta.GetRow(handler);
                }
            }
            if (colaborador != null)
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro: " + colaborador.Nome + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d.ToString() == "Yes")
                {
                    Repositorio.Excluir(colaborador);
                    CarregaDados();
                }
            }
        }

        private void frmColaboradorConsulta_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
    }
}
