using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LinqKit;
using NHibernate;
using SGE.App.Formularios;
using SGE.Dominio.Entidades;
using SGE.Relatorios;
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

namespace SGE.App
{
    public partial class frmRelPreparacao : Form
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

        Preparacao preparacao;
        public frmRelPreparacao()
        {
            InitializeComponent();
            NHibernateHelper.GetSession();

        }

        private void frmRelPreparacao_Load(object sender, EventArgs e)
        {

        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                var predicado = Repositorio.CriarPredicado();
                if (preparacao != null)
                    predicado = predicado.And(x => x.Id == preparacao.Id);

                var listaDetalhada = Repositorio.ObterPorParametros(predicado);
                var rel = new rptPreparacaoDetalhes();
                rel.DataSource = listaDetalhada;
                rel.ShowPreview();
            }
            else
                XtraMessageBox.Show("Escolha uma preparação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtCodigo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (frmPesquisa<Preparacao> frm = new frmPesquisa<Preparacao>())
            {
                frm.ShowDialog();
                if (frm.objeto != null)
                {
                    preparacao = Repositorio.ObterPorId(frm.objeto.Id);
                    if (preparacao != null)
                    {
                        txtCodigo.Text = preparacao.Id.ToString();
                        lblPreparacao.Text = preparacao.DadosPreparacao;
                        SendKeys.Send("{TAB}");
                    }
                }
            }
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
            {
                preparacao = Repositorio.ObterPorId(Int64.Parse(txtCodigo.Text));
                lblPreparacao.Text = preparacao != null ? preparacao.DadosPreparacao : "Preparação não localizada!";
            }
            else
            {
                preparacao = null;
                lblPreparacao.Text = string.Empty;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
