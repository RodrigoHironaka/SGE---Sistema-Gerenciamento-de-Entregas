using DevExpress.XtraEditors;
using NHibernate;
using SGE.App.Formularios.Utilidades;
using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;
using SGE.Repositorio.Configuracao;
using SGE.Repositorio.Ferramentas;
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
    public partial class frmPreparacaoConsulta : Form
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

        #region Repositorio Setores
        private RepositorioPreparacaoSetores _repositorioSetores;
        public RepositorioPreparacaoSetores RepositorioSetores
        {
            get
            {
                if (_repositorioSetores == null)
                    _repositorioSetores = new RepositorioPreparacaoSetores(Session);

                return _repositorioSetores;
            }
            set { _repositorioSetores = value; }
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

        public void ConfiguraTimer()
        {
            var configuracoes = Ferramentas.LerXML();
            timerGrid.Interval = Convert.ToInt32(configuracoes[8]) * 1000;
            timerGrid.Enabled = true;
        }
       
        public frmPreparacaoConsulta()
        {
            InitializeComponent();
            ConfiguraTimer();
        }

        private void CarregaDados()
        {
            grdConsulta.DataSource = Repositorio.ObterTodos().ToList();

        }

        public void VerificaSetorAberto()
        {
            var linhas = new List<Preparacao>();
            Preparacao preparacao = null;

            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (var handler in gvwConsulta.GetSelectedRows())
                {
                    preparacao = (Preparacao)gvwConsulta.GetRow(handler);
                    linhas.Add(preparacao);
                }
            }

            if (linhas != null)
            {
                foreach (var item in linhas)
                {
                    var prep = Repositorio.ObterPorId(item.Id);

                    if (prep.SituacaoPreparacao == SituacaoPreparacao.Cancelado
                        || prep.SituacaoPreparacao == SituacaoPreparacao.Entregue
                        || prep.SituacaoPreparacao == SituacaoPreparacao.Devolucao
                        || prep.SituacaoPreparacao == SituacaoPreparacao.Saiu)
                    {
                        XtraMessageBox.Show("Situação da preparação nº "+ item.Id +" esta '" + prep.SituacaoPreparacao.ToString() +
                            "'.\nVocê não pode realizar esta operação!\n", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (prep.Acougue == SituacaoPreparacaoSetores.Aberto
                       || prep.Padaria == SituacaoPreparacaoSetores.Aberto
                       || prep.Loja == SituacaoPreparacaoSetores.Aberto
                       || prep.Caixa == SituacaoPreparacaoSetores.Aberto)
                    {
                        XtraMessageBox.Show("Existem setores em aberto, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                frmDefineEntregador frm = new frmDefineEntregador(preparacao, Session, linhas);
                if (frm.ShowDialog() == DialogResult.OK)
                    gvwConsulta.RefreshData();
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            frmPreparacaoCadastro frm = new frmPreparacaoCadastro(new Preparacao(), Session);
            if (frm.ShowDialog() == DialogResult.OK)
                CarregaDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            Preparacao preparacao = null;
            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    preparacao = (Preparacao)gvwConsulta.GetRow(handler);
                }
            }
            if (preparacao != null)
            {
                frmPreparacaoCadastro frm = new frmPreparacaoCadastro(preparacao, Session);
                if (frm.ShowDialog() == DialogResult.OK)
                    CarregaDados();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Preparacao preparacao = null;

            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    preparacao = (Preparacao)gvwConsulta.GetRow(handler);
                }
            }
            if (preparacao != null)
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir a preparação: " + preparacao.Id + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d.ToString() == "Yes")
                {
                    //RepositorioSetores.Excluir();
                    Repositorio.Excluir(preparacao);
                    CarregaDados();
                }
            }
        }

        private void frmPreparacaoConsulta_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Preparacao preparacao = null;

            if (gvwConsulta.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwConsulta.GetSelectedRows())
                {
                    preparacao = (Preparacao)gvwConsulta.GetRow(handler);
                }
            }
            if (preparacao != null)
            {
                DialogResult d = MessageBox.Show("Deseja realmente cancelar o registro:" + preparacao.Id + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d.ToString() == "Yes")
                {
                    preparacao.SituacaoPreparacao = Dominio.ObjetoValor.SituacaoPreparacao.Cancelado;
                    Repositorio.Alterar(preparacao);
                    CarregaDados();
                }
            }
        }

        private void btSaida_Click(object sender, EventArgs e)
        {
            VerificaSetorAberto();
        }

        private void btChegada_Click(object sender, EventArgs e)
        {
            frmConsultaEntregasPorColaborador frm = new frmConsultaEntregasPorColaborador(Session);
            if (frm.ShowDialog() == DialogResult.OK)
                gvwConsulta.RefreshData();
        }

        private void timerGrid_Tick(object sender, EventArgs e)
        {
            CarregaDados();
        }
    }
}
