using DevExpress.XtraReports.UI;
using NHibernate;
using SGE.App.Formularios;
using SGE.App.Formularios.Login;
using SGE.App.Formularios.Utilidades;
using SGE.App.Relatorios;
using SGE.Dominio.ObjetoValor;
using SGE.Monitor;
using SGE.Relatorios;
using SGE.Repositorio.Configuracao;
using SGE.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.App
{
    public partial class frmPrincipal : Form
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
        private RepositorioPreparacao _repositorio;
        public RepositorioPreparacao Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioPreparacao(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        #endregion

        public static string TipoUsuarioLogado;

        public void BloqueiaCamposPeloTipoUsuario()
        {
            var usuario = frmLogin.UsuarioTipo == TipoUsuario.Usuario.ToString();
            setorToolStripMenuItem.Visible = !usuario;
            formaDePagamentoToolStripMenuItem.Visible = !usuario;
            motivoToolStripMenuItem.Visible = !usuario;
            colaboradorToolStripMenuItem.Visible = !usuario;
            usuarioToolStripMenuItem.Visible = !usuario;

            //relatorios
            relatóriosToolStripMenuItem.Visible = !usuario;

            //opçoes
            configuraçõesToolStripMenuItem.Visible = !usuario;
            backupToolStripMenuItem.Visible = !usuario;

            //Compras
            entregaToolStripMenuItem.Visible = !usuario;
        }

        private void BloqueiaCamposFormPrincipal()
        {
            mStripPrincipal.Visible = false;
            StatusLabelNome.Text = "Usuário";
            StatusLabelTipo.Text = "Tipo";
            StatusLabelDataHora.Text = "DataHora";
            TipoUsuarioLogado = null;
        }

        private void LiberaCamposFormPrincipal()
        {
            mStripPrincipal.Visible = true;
            StatusLabelNome.Text = frmLogin.UsuarioLogado;
            StatusLabelTipo.Text = frmLogin.UsuarioTipo;
            StatusLabelDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            TipoUsuarioLogado = StatusLabelTipo.Text;
        }

        public frmPrincipal()
        {
            InitializeComponent();
            NHibernateHelper.GetSession();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetorConsulta frm = new frmSetorConsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormaPagamentoConsulta frm = new frmFormaPagamentoConsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidadeConsulta frm = new frmCidadeConsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteConsulta frm = new frmClienteConsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColaboradorConsulta frm = new frmColaboradorConsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void preparaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreparacaoConsulta frm = new frmPreparacaoConsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntregaConsulta frm = new frmEntregaConsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void motivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMotivoConsulta frm = new frmMotivoConsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucaoConsulta frm = new frmDevolucaoConsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lista = Repositorio.ObterTodos().ToList();
            var rel = new rptPreparacao();
            rel.DataSource = lista;
            rel.ShowPreview();
        }

        private void detalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelPreparacao frm = new frmRelPreparacao();
            frm.MdiParent = this;
            frm.Show();
        }

        private void porPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelPreparacaoTodos frm = new frmRelPreparacaoTodos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioConsulta frm = new frmUsuarioConsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            BloqueiaCamposFormPrincipal();
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LiberaCamposFormPrincipal();
                System.Diagnostics.Process.Start("SGE.Monitor.exe");
            }
                
            else
                Application.Exit();
            BloqueiaCamposPeloTipoUsuario();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrincipal_Load(sender, e);
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupRestore frm = new frmBackupRestore();
            frm.MdiParent = this;
            frm.Show();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracao frm = new frmConfiguracao();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
