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
    public partial class frmMotivoConsulta : Form
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
        private RepositorioMotivo _repositorio;

        public RepositorioMotivo Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioMotivo(Session);
                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion

        public frmMotivoConsulta()
        {
            InitializeComponent();
        }

        private void CarregaDados()
        {
            grdConsulta.DataSource = Repositorio.ObterTodos().OrderBy(x => x.Nome).ToList();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            frmMotivoCadastro frm = new frmMotivoCadastro(new Motivo(), Session);
            if (frm.ShowDialog() == DialogResult.OK)
                CarregaDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            Motivo motivo = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    motivo = (Motivo)gvwConsulta.GetRow(handler);
                }
            }
            if (motivo != null)
            {
                frmMotivoCadastro frm = new frmMotivoCadastro(motivo, Session);
                if (frm.ShowDialog() == DialogResult.OK)
                    CarregaDados();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Motivo motivo = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    motivo = (Motivo)gvwConsulta.GetRow(handler);
                }
            }
            if (motivo != null)
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d.ToString() == "Yes")
                {
                    Repositorio.Excluir(motivo);
                    CarregaDados();
                }
            }
        }

        private void frmMotivoConsulta_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
    }
}
