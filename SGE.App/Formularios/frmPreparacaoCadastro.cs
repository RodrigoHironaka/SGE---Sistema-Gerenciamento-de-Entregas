using DevExpress.XtraEditors;
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
    public partial class frmPreparacaoCadastro : Form
    {
        ISession Session;

        #region Repositorio
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

        Preparacao preparacao;

        private void AtualizaPreparacaoSetores()
        {
            if (preparacao.PreparacaoSetores.Count != 0)
            {
                foreach (var item in preparacao.PreparacaoSetores)
                {
                    if (item.Setor.Nome == "Acougue" && item.Colaborador == null)
                    {
                        preparacao.Acougue = SituacaoPreparacaoSetores.Aberto;
                        continue;
                    }
                    else if (item.Setor.Nome == "Acougue" && item.Colaborador != null)
                    {
                        preparacao.Acougue = SituacaoPreparacaoSetores.Concluido;
                        continue;
                    }

                    if (item.Setor.Nome == "Padaria" && item.Colaborador == null)
                    {
                        preparacao.Padaria = SituacaoPreparacaoSetores.Aberto;
                        continue;
                    }
                    else if (item.Setor.Nome == "Padaria" && item.Colaborador != null)
                    {
                        preparacao.Padaria = SituacaoPreparacaoSetores.Concluido;
                        continue;
                    }
                    
                    if (item.Setor.Nome == "Loja" && item.Colaborador == null)
                    {
                        preparacao.Loja = SituacaoPreparacaoSetores.Aberto;
                        continue;
                    }
                    else if (item.Setor.Nome == "Loja" && item.Colaborador != null)
                    {
                        preparacao.Loja = SituacaoPreparacaoSetores.Concluido;
                        continue;
                    }
                   
                    if (item.Setor.Nome == "Caixa" && item.Colaborador == null)
                    {
                        preparacao.Caixa = SituacaoPreparacaoSetores.Aberto;
                        continue;
                    }
                    else if (item.Setor.Nome == "Caixa" && item.Colaborador != null)
                    {
                        preparacao.Caixa = SituacaoPreparacaoSetores.Concluido;
                    }
                    
                }
            }
            
        }

        private void AtualizaPreparacao()
        {
            
            if (!String.IsNullOrEmpty(dateAgendar.Text))
            {
                preparacao.Aproximada = dateAgendar.DateTime.Date;
                preparacao.SituacaoPreparacao = SituacaoPreparacao.Agendado;
            }
            else
            {
                preparacao.Aproximada = null;
                preparacao.SituacaoPreparacao = SituacaoPreparacao.Pendente;
            }
            if (lblSituacao.Text == SituacaoPreparacao.Saiu.ToString())
                preparacao.SituacaoPreparacao = SituacaoPreparacao.Saiu;
            preparacao.Total = txtTotalCompra.Value;
            preparacao.TrocoPara = txtTrocoPara.Value;
            preparacao.Troco = txtTroco.Value;
            preparacao.Cupom = Int32.Parse(txtCupom.Text);
            preparacao.Ficha = Int32.Parse(txtFicha.Text);
            preparacao.Observacao = memoObs.Text;
            preparacao.FormaPagamento = (FormaPagamento)cbFormaPagamento.EditValue;
            AtualizaPreparacaoSetores();


        }

        private void PreencheCampos()
        {
            txtId.Text = preparacao.Id.ToString();
            txtGeracao.Text = preparacao.DataGeracao.ToString();
            txtAltercao.Text = preparacao.DataAlteracao.ToString();
            txtFinalizado.Text = preparacao.Finalizado.ToString();
            if (preparacao.Aproximada != null)
                dateAgendar.DateTime = preparacao.Aproximada.Value;
            if (preparacao.Finalizado != null)
                txtFinalizado.Text = preparacao.Finalizado.ToString();
            lblSituacao.Text = preparacao.SituacaoPreparacao.ToString();
            txtTotalCompra.Text = preparacao.Total.ToString();
            txtTrocoPara.Text = preparacao.TrocoPara.ToString();
            txtTroco.Text = preparacao.Troco.ToString();
            txtCupom.Text = preparacao.Cupom.ToString();
            txtFicha.Text = preparacao.Ficha.ToString();
            memoObs.Text = preparacao.Observacao;
            if (preparacao.Cliente != null)
            {
                txtCliente.Text = preparacao.Cliente.Id.ToString();
                txtDadosCliente.Text = preparacao.Cliente.DadosCliente;
            }
            else
            {
                txtCliente.Text = String.Empty;
                txtDadosCliente.Text = String.Empty;
            }
            if (preparacao.FormaPagamento != null)
                cbFormaPagamento.ItemIndex = cbFormaPagamento.Properties.GetDataSourceRowIndex("Id", preparacao.FormaPagamento.Id);
            if(preparacao.Entrega != null)
                txtDadosEntrega.Text = preparacao.Entrega.DadosEntrega;
        }

        private void CarregaComboPagamento()
        {
            cbFormaPagamento.Properties.DataSource = new RepositorioFormaPagamento(Session)
                .ObterPorParametros(x => x.Situacao == Situacao.Ativo)
                .OrderBy(x => x.Nome)
                .ToList<FormaPagamento>();
        }

        private void PreencherGrid()
        {
            gbgPrepSetores.DataSource = new BindingList<PreparacaoSetores>(preparacao.PreparacaoSetores);
        }

        private void LiberaPaineis()
        {
            if (preparacao.SituacaoPreparacao == SituacaoPreparacao.Cancelado
                || preparacao.SituacaoPreparacao == SituacaoPreparacao.Entregue
                || preparacao.SituacaoPreparacao == SituacaoPreparacao.Devolucao)
            {
                pCabecalho.Enabled = !pCabecalho.Enabled;
                grpCliente.Enabled = !grpCliente.Enabled;
                grpPreparacao.Enabled = !grpPreparacao.Enabled;
                pPagamento.Enabled = !pPagamento.Enabled;
                grpEntrega.Enabled = !grpEntrega.Enabled;
                btSalvar.Enabled = !btSalvar.Enabled;
            }

        }

        private void BloqueioSituacaoSaiu()
        {
            if(lblSituacao.Text == SituacaoPreparacao.Saiu.ToString())
            {
                txtSetor.Enabled = !txtSetor.Enabled;
                txtNomeSetor.Enabled = !txtNomeSetor.Enabled;
                btIniciar.Enabled = !btIniciar.Enabled;
                txtColaborador.Enabled = !txtColaborador.Enabled;
                txtNomeColaborador.Enabled = !txtNomeColaborador.Enabled;
                btFinalizar.Enabled = !btFinalizar.Enabled;
            }
            
            
        }

        public frmPreparacaoCadastro(Preparacao _preparacao, ISession _session)
        {
            InitializeComponent();
            Session = _session;
            preparacao = _preparacao;
            LiberaPaineis();
        }

        private void frmPreparacaoCadastro_Load(object sender, EventArgs e)
        {
            CarregaComboPagamento();
            PreencheCampos();
            PreencherGrid();
            BloqueioSituacaoSaiu();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            AtualizaPreparacao();

            if ((preparacao.Id == 0) || (String.IsNullOrEmpty(preparacao.Id.ToString())))
            {
                preparacao.PreparacaoSetores.ToList().ForEach(x => x.Preparacao = preparacao);
                Repositorio.Salvar(preparacao);
                foreach (var item in preparacao.PreparacaoSetores)
                {
                    PreparacaoSetores preparacaoSetores = new PreparacaoSetores();
                    preparacaoSetores.Setor = new Setor { Id = item.Setor.Id };
                    preparacaoSetores.Inicio = item.Inicio;
                    preparacaoSetores.Final = item.Final;
                    preparacaoSetores.Tempo = item.Tempo;
                    preparacaoSetores.Colaborador = item.Colaborador != null ? new Colaborador { Id = item.Colaborador.Id } : null;
                    preparacaoSetores.Preparacao = preparacao;
                    //RepositorioSetores.Salvar(preparacaoSetores);
                }
            }
            else
            {
                IList<PreparacaoSetores> setores = new List<PreparacaoSetores>(preparacao.PreparacaoSetores.Count);
                foreach (var item in (IList<PreparacaoSetores>)gbgPrepSetores.DataSource)
                    setores.Add(item);

                preparacao.PreparacaoSetores.Clear();
                foreach (var item in setores)
                {
                    if (item.Preparacao == null)
                        item.Preparacao = this.preparacao;
                    preparacao.PreparacaoSetores.Add(item);
                    //RepositorioSetores.Alterar(item);
                }
                Repositorio.Alterar(preparacao);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtCliente_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmPesquisa<Cliente> frm = new frmPesquisa<Cliente>();
            frm.ShowDialog();
            if (frm.objeto != null)
            {
                txtCliente.Text = frm.objeto.Id.ToString();
                txtDadosCliente.Text = frm.objeto.DadosCliente;
            }
        }

        private void txtCliente_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCliente.Text))
            {
                try
                {
                    preparacao.Cliente = new RepositorioCliente(Session).ObterPorId(Int64.Parse(txtCliente.Text));
                }
                catch (Exception)
                {
                    preparacao.Cliente = null;
                }
                txtDadosCliente.Text = preparacao.Cliente != null ? preparacao.Cliente.DadosCliente : "Cidade não localizada!";
            }
            else
            {
                preparacao.Cliente = null;
                txtDadosCliente.Text = string.Empty;
            }
        }

        private void txtSetor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmPesquisa<Setor> frm = new frmPesquisa<Setor>();
            frm.ShowDialog();
            if (frm.objeto != null)
            {
                txtSetor.Text = frm.objeto.Id.ToString();
                txtNomeSetor.Text = frm.objeto.Nome;
            }
        }

        private void txtSetor_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSetor.Text))
            {
                try
                {
                    //preparacao.PreparacaoSetores = new RepositorioPreparacaoSetores(Session).ObterPorId(Int64.Parse(txtSetor.Text));
                }
                catch (Exception)
                {
                    //preparacao.PreparacaoSetores = null;
                }
                //txtNomeSetor.Text = preparacao.PreparacaoSetores != null ? preparacao.Cliente.DadosCliente : "Cidade não localizada!";
            }
            else
            {
                //preparacao.PreparacaoSetores = null;
                txtNomeSetor.Text = string.Empty;
            }
        }

        private void txtColaborador_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmPesquisa<Colaborador> frm = new frmPesquisa<Colaborador>();
            frm.ShowDialog();
            if (frm.objeto != null)
            {
                txtColaborador.Text = frm.objeto.Id.ToString();
                txtNomeColaborador.Text = frm.objeto.Nome;
            }
        }

        private void txtColaborador_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColaborador.Text))
            {
                try
                {
                    //preparacao.PreparacaoSetores = new RepositorioPreparacaoSetores(Session).ObterPorId(Int64.Parse(txtSetor.Text));
                }
                catch (Exception)
                {
                    //preparacao.PreparacaoSetores = null;
                }
                //txtNomeSetor.Text = preparacao.PreparacaoSetores != null ? preparacao.Cliente.DadosCliente : "Cidade não localizada!";
            }
            else
            {
                //preparacao.PreparacaoSetores = null;
                txtNomeColaborador.Text = string.Empty;
            }
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSetor.Text) && !String.IsNullOrEmpty(txtNomeSetor.Text))
            {
                if (preparacao.PreparacaoSetores.Count != 0)
                {
                    var setor = new RepositorioSetor(Session).ObterPorId(Int64.Parse(txtSetor.Text));
                    int retornaSetor = preparacao.PreparacaoSetores.Count(x => x.Setor.Id == setor.Id && x.Colaborador == null);

                    if (retornaSetor == 0)
                    {
                        preparacao.PreparacaoSetores.Add(new PreparacaoSetores { Setor = new Setor { Id = Int32.Parse(txtSetor.Text), Nome = txtNomeSetor.Text }, Inicio = DateTime.Now });
                        gvwPrepSetores.RefreshData();
                    }
                    else
                        XtraMessageBox.Show("Este setor já está lançado e ainda nao foi finalizado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    preparacao.PreparacaoSetores.Add(new PreparacaoSetores { Setor = new Setor { Id = Int32.Parse(txtSetor.Text), Nome = txtNomeSetor.Text }, Inicio = DateTime.Now });
                    gvwPrepSetores.RefreshData();
                }
            }
            else
                XtraMessageBox.Show("Por favor defina um setor para iniciar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtSetor.Text = string.Empty;
            txtNomeSetor.Text = string.Empty;
        }

        private void cbFormaPagamento_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColaborador.Text))
            {
                var colaborador = new RepositorioColaborador(Session).ObterPorId(Int64.Parse(txtColaborador.Text));
                foreach (var item in preparacao.PreparacaoSetores)
                {
                    if (item.Tempo > TimeSpan.Zero)
                        continue;
                    if (item.Setor.Id == colaborador.Setor.Id)
                    {
                        item.Colaborador = new Colaborador { Id = colaborador.Id, Nome = colaborador.Nome };
                        item.Final = DateTime.Now;
                        item.Tempo = item.Final.Subtract(item.Inicio);
                    }
                }

                gvwPrepSetores.RefreshData();
            }
            else
            {
                XtraMessageBox.Show("Por favor defina um colaborador para finalizar o setor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtColaborador.Text = string.Empty;
            txtNomeColaborador.Text = string.Empty;
        }

        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            frmClienteCadastro frm = new frmClienteCadastro(new Cliente(), Session);
            frm.ShowDialog();

        }

        private void txtTrocoPara_Leave(object sender, EventArgs e)
        {
            preparacao.Total = Decimal.Parse(txtTotalCompra.Text);
            preparacao.TrocoPara = Decimal.Parse(txtTrocoPara.Text);

            if (preparacao.TrocoPara < preparacao.Total && preparacao.TrocoPara > 0)
            {
                XtraMessageBox.Show("Campo 'Troco Para' não pode ser menor que o 'Total da Compra'!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTrocoPara.Select();
                return;
            }

            if (preparacao.TrocoPara == preparacao.Total)
                txtTrocoPara.Value = 0;

            if (preparacao.TrocoPara != 0)
                txtTroco.Text = Convert.ToString(preparacao.TrocoPara - preparacao.Total);
            else
                txtTroco.Value = 0;


        }

        private void txtTotalCompra_Leave(object sender, EventArgs e)
        {
            preparacao.Total = Decimal.Parse(txtTotalCompra.Text);
            if (preparacao.Total == 0)
            {
                XtraMessageBox.Show("Total não pode ser Zero!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalCompra.Select();
            }
        }
    }
}
