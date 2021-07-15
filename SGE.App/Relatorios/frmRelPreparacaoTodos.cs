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

namespace SGE.App.Relatorios
{
    public partial class frmRelPreparacaoTodos : Form
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

        #region repositorio cliente
        private RepositorioCliente _repositorioCliente;
        public RepositorioCliente RepositorioCliente
        {
            get
            {
                if (_repositorioCliente == null)
                    _repositorioCliente = new RepositorioCliente(Session);

                return _repositorioCliente;
            }
            set { _repositorioCliente = value; }
        }

        #endregion

        //Preparacao preparacao;
        Cliente cliente;
    

        public frmRelPreparacaoTodos()
        {
            InitializeComponent();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
                var predicado = Repositorio.CriarPredicado();
                if (cliente != null)
                    predicado = predicado.And(x => x.Cliente == cliente);
                if (!String.IsNullOrEmpty(dtInicio.Text))
                    predicado = predicado.And(x => x.DataGeracao.Value.Date >= (DateTime)dtInicio.EditValue);
                if (!String.IsNullOrEmpty(dtFinal.Text))
                    predicado = predicado.And(x => x.DataGeracao.Value.Date <= (DateTime)dtFinal.EditValue);

                var listaDetalhada = Repositorio.ObterPorParametros(predicado);
                var rel = new rptPreparacao();
                rel.DataSource = listaDetalhada;
                rel.ShowPreview();
            
        }

        private void txtCodigo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (frmPesquisa<Cliente> frm = new frmPesquisa<Cliente>())
            {
                frm.ShowDialog();
                if (frm.objeto != null)
                {
                    cliente = RepositorioCliente.ObterPorId(frm.objeto.Id);
                    if (cliente != null)
                    {
                        txtCodigo.Text = cliente.Id.ToString();
                        lblCliente.Text = cliente.DadosCliente;
                        SendKeys.Send("{TAB}");
                    }
                }
            }
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
            {
                cliente = RepositorioCliente.ObterPorId(Int64.Parse(txtCodigo.Text));
                lblCliente.Text = cliente != null ? cliente.DadosCliente : "Cliente não localizado!";
            }
            else
            {
                cliente = null;
                lblCliente.Text = "...";
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
