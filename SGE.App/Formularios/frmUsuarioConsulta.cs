using DevExpress.XtraEditors;
using NHibernate;
using SGE.App.Formularios.Utilidades;
using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;
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
    public partial class frmUsuarioConsulta : Form
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
        private RepositorioUsuario _repositorio;

        public RepositorioUsuario Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioUsuario(Session);
                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion
        public frmUsuarioConsulta()
        {
            InitializeComponent();
        }

        private void CarregaDados()
        {
            grdConsulta.DataSource = Repositorio.ObterTodos().OrderBy(x => x.Nome).ToList();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            frmUsuarioCadastro frm = new frmUsuarioCadastro(new Usuario(), Session);
            if (frm.ShowDialog() == DialogResult.OK)
                CarregaDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            Usuario usuario = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    usuario = (Usuario)gvwConsulta.GetRow(handler);
                }
            }
            if (frmPrincipal.TipoUsuarioLogado != TipoUsuario.Administrador.ToString())
            {
                if (usuario != null)
                {
                    frmPermissaoAdmin frmAdmin = new frmPermissaoAdmin();
                    if (frmAdmin.ShowDialog() == DialogResult.OK)
                    {
                        frmUsuarioCadastro frm = new frmUsuarioCadastro(usuario, Session);
                        if (frm.ShowDialog() == DialogResult.OK)
                            CarregaDados();
                    }
                }
            }
            else
            {
                frmUsuarioCadastro frm = new frmUsuarioCadastro(usuario, Session);
                if (frm.ShowDialog() == DialogResult.OK)
                    CarregaDados();
            }
            

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Usuario usuario = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    usuario = (Usuario)gvwConsulta.GetRow(handler);
                }
            }
            if (usuario != null)
            {
                DialogResult d = XtraMessageBox.Show("Deseja realmente excluir o registro: " + usuario.Nome + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d.ToString() == "Yes")
                {
                    Repositorio.Excluir(usuario);
                    CarregaDados();
                }
            }
        }

        private void frmUsuarioConsulta_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
    }
}
