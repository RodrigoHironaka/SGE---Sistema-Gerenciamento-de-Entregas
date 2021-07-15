using NHibernate;
using SGE.Dominio.Entidades;
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
using Doctus.Utils.Text;
using SGE.Dominio.ObjetoValor;

namespace SGE.App.Formularios.Utilidades
{
    public partial class frmConsultaEntregasPorColaborador : Form
    {
        ISession Session;

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

        #region Repositorio Entrega
        private RepositorioEntrega _repositorioEntrega;
        public RepositorioEntrega RepositorioEntregas
        {
            get
            {
                if (_repositorioEntrega == null)
                    _repositorioEntrega = new RepositorioEntrega(Session);

                return _repositorioEntrega;
            }
            set { _repositorioEntrega = value; }
        }

        #endregion

        #region Repositorio Colaborador
        private RepositorioColaborador _repositorioColaborador;
        public RepositorioColaborador RepositorioColaboradores
        {
            get
            {
                if (_repositorioColaborador == null)
                    _repositorioColaborador = new RepositorioColaborador(Session);

                return _repositorioColaborador;
            }
            set { _repositorioColaborador = value; }
        }

        #endregion

        #region Repositorio Preparacao
        private RepositorioPreparacao _repositorioPreparacao;
        public RepositorioPreparacao RepositorioPreparacao
        {
            get
            {
                if (_repositorioPreparacao == null)
                    _repositorioPreparacao = new RepositorioPreparacao(Session);

                return _repositorioPreparacao;
            }
            set { _repositorioPreparacao = value; }
        }

        #endregion

        public frmConsultaEntregasPorColaborador(ISession _session)
        {
            InitializeComponent();
            Session = _session;
        }

        private void txtColaborador_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmPesquisa<Colaborador> frm = new frmPesquisa<Colaborador>();
            frm.ShowDialog();
            if (frm.objeto != null)
            {
                txtColaborador.Text = frm.objeto.Id.ToString();
                lblColaborador.Text = frm.objeto.Nome;
            }

        }

        private void txtColaborador_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColaborador.Text))
            {
                try
                {
                    var dadosColaborador = new RepositorioColaborador(Session).ObterPorId(Int64.Parse(txtColaborador.Text));
                    lblColaborador.Text = dadosColaborador != null ? dadosColaborador.Nome : "Colaborador não localizado!";
                }
                catch (Exception)
                {
                    lblColaborador.Text = "Colaborador não localizado!";
                }
            }
            else
            {
                lblColaborador.Text = "Colaborador não localizado!";
            }

        }

        private void txtColaborador_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColaborador.Text))
            {
                grdConEntregasColaborador.DataSource = RepositorioEntregas.ObterPorParametros(x => x.Colaborador.Id == Int64.Parse(txtColaborador.Text)&& x.Preparacao.SituacaoPreparacao == SituacaoPreparacao.Saiu)
                    .Select (x => x.Preparacao);
                //gvwConEntregasColaborador.RefreshData();
            }
        }

        private void grdConEntregasColaborador_DoubleClick(object sender, EventArgs e)
        {
          

        }

        private void grdConEntregasColaborador_EmbeddedNavigator_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gvwConEntregasColaborador_DoubleClick(object sender, EventArgs e)
        {
            if ((gvwConEntregasColaborador.SelectedRowsCount > 0) && (gvwConEntregasColaborador.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle))
            {
                var PreparacaoEntrega = (Preparacao)gvwConEntregasColaborador.GetRow(gvwConEntregasColaborador.GetSelectedRows().First());
                frmDevolucaoCadastro frm = new frmDevolucaoCadastro(PreparacaoEntrega, Session);
                if (frm.ShowDialog() == DialogResult.OK)
                    gvwConEntregasColaborador.RefreshData();
            }
            
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var PreparacaoEntrega = (grdConEntregasColaborador.DataSource as IEnumerable<Preparacao>).ToList();

            foreach (var item in PreparacaoEntrega)
            {
                if (item.Devolucao == null)
                {
                    item.SituacaoPreparacao = SituacaoPreparacao.Entregue;
                    item.Finalizado = DateTime.Now;
                    item.Entrega.Chegada = DateTime.Now;
                    item.Entrega.Tempo = item.Entrega.Chegada.Subtract(item.Entrega.Saida);
                    RepositorioPreparacao.Alterar(item);
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
