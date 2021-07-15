using NHibernate;
using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;
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
    public partial class frmDevolucaoCadastro : Form
    {
        ISession Session;
        #region Repositorio
        private RepositorioDevolucao _repositorio;
        public RepositorioDevolucao Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioDevolucao(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion
        #region repositorio Preparacao
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
        //Entrega entrega;
        //Devolucao devolucao;
        Preparacao preparacao;

        private void PreencheCamposAlterar()
        {
            txtId.Text = preparacao.Devolucao.Id.ToString();
            txtGeracao.Text = preparacao.Devolucao.DataGeracao.ToString();
            txtPreparacao.Text = preparacao.Devolucao.Preparacao.Id.ToString();
            rdgTipoDevolucao.SelectedIndex = preparacao.Devolucao.TipoDevolucao.GetHashCode();
            if (preparacao.Devolucao.Motivo != null)
                cbMotivo.ItemIndex = cbMotivo.Properties.GetDataSourceRowIndex("Id", preparacao.Devolucao.Motivo.Id);
            txtNomePessoa.Text = preparacao.Devolucao.NomePessoa.ToString();
            txtValorDevolvido.Text = preparacao.Devolucao.Valor.ToString();
            memoObs.Text = preparacao.Devolucao.Observacao;
            txtColaborador.Text = preparacao.Devolucao.Colaborador.DadosColaboradorSetor;
        }

        private void PreencheCamposChegada()
        {
            txtPreparacao.Text = preparacao.Id.ToString();
            txtColaborador.Text = preparacao.Entrega.Colaborador.DadosColaboradorSetor.ToString();
        }

        public frmDevolucaoCadastro(Preparacao _preparacao, ISession _session)
        {
            InitializeComponent();
            Session = _session;
            preparacao = _preparacao;
        }

        private void CarregaComboMotivo()
        {
            cbMotivo.Properties.DataSource = new RepositorioMotivo(Session)
                .ObterPorParametros(x => x.Situacao == Situacao.Ativo)
                .OrderBy(x => x.Nome)
                .ToList<Motivo>();
        }

        private void AtualizaDevolucao()
        {
            if(preparacao.Devolucao != null)
            {
                preparacao.Devolucao.Preparacao = preparacao;
                preparacao.Devolucao.NomePessoa = txtNomePessoa.Text;
                preparacao.Devolucao.TipoDevolucao = (TipoDevolucao)rdgTipoDevolucao.SelectedIndex;
                preparacao.Devolucao.Valor = Decimal.Parse(txtValorDevolvido.Text);
                preparacao.Devolucao.Observacao = memoObs.Text;
                preparacao.Devolucao.Colaborador = preparacao.Entrega.Colaborador;
                preparacao.Devolucao.Motivo = (Motivo)cbMotivo.EditValue;
            }
            else
            {
                //Devolucao dev = new Devolucao();
                //dev.Preparacao = preparacao;
                //dev.NomePessoa = txtNomePessoa.Text;
                //dev.TipoDevolucao = (TipoDevolucao)rdgTipoDevolucao.SelectedIndex;
                //dev.Valor = Decimal.Parse(txtValorDevolvido.Text);
                //dev.Observacao = memoObs.Text;
                //dev.Colaborador = preparacao.Entrega.Colaborador;
                //dev.Motivo = (Motivo)cbMotivo.EditValue;

                //preparacao.Devolucao = dev;

                Devolucao dev1 = new Devolucao
                {
                    Preparacao = preparacao,
                    NomePessoa = txtNomePessoa.Text,
                    TipoDevolucao = (TipoDevolucao)rdgTipoDevolucao.SelectedIndex,
                    Valor = Decimal.Parse(txtValorDevolvido.Text),
                    Observacao = memoObs.Text,
                    Colaborador = preparacao.Entrega.Colaborador,
                    Motivo = (Motivo)cbMotivo.EditValue
                };
                preparacao.Devolucao = dev1;
            }
            
        }

        private void cbFormaPagamento_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void frmDevolucaoCadastro_Load(object sender, EventArgs e)
        {
            CarregaComboMotivo();
            if (preparacao.Devolucao != null)
                PreencheCamposAlterar();
            else
                PreencheCamposChegada();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            AtualizaDevolucao();

            //Preparacao preparacao = RepositorioPreparacao.ObterPorId(preparacao.Id);
            if ((preparacao.Devolucao.Id == 0) || (String.IsNullOrEmpty(preparacao.Devolucao.Id.ToString())))
            {
                Repositorio.Salvar(preparacao.Devolucao);


                preparacao.SituacaoPreparacao = SituacaoPreparacao.Devolucao;
                preparacao.Devolucao = preparacao.Devolucao;
                preparacao.Finalizado = DateTime.Now;
                preparacao.Entrega.Chegada = DateTime.Now;
                preparacao.Entrega.Tempo = preparacao.Entrega.Chegada.Subtract(preparacao.Entrega.Saida);
                RepositorioPreparacao.Alterar(preparacao);
            }
            else
                Repositorio.Alterar(preparacao.Devolucao);

            this.DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
