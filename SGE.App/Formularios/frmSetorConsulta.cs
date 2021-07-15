using NHibernate;
using SGE.Dominio.Entidades;
using SGE.Repositorio.Configuracao;
using SGE.Repositorio.Repositorios;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace SGE.App.Formularios
{
    public partial class frmSetorConsulta : Form
    {
        #region
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

        #region repositorio
        private RepositorioSetor _repositorio;
        public RepositorioSetor Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioSetor(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        #endregion
        public frmSetorConsulta()
        {
            InitializeComponent();
        }

        private void CarregaDados()
        {
            grdConsulta.DataSource = Repositorio.ObterTodos().OrderBy(x => x.Nome).ToList();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            frmSetorCadastro frm = new frmSetorCadastro(new Setor(), Session);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                CarregaDados();
        }

        private void frmSetorConsulta_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

            Setor setor = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    setor = (Setor)gvwConsulta.GetRow(handler);
                }
            }
            if (setor != null)
            {
                frmSetorCadastro frm = new frmSetorCadastro(setor, Session);
                if (frm.ShowDialog() == DialogResult.OK)
                    CarregaDados();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Setor setor = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    setor = (Setor)gvwConsulta.GetRow(handler);
                }
            }
            if (setor != null)
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(d.ToString() == "Yes")
                {
                    Repositorio.Excluir(setor);
                    CarregaDados();
                }  
            }

        }
    }
}
