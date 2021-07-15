using Doctus.Utils.Text;
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
    public partial class frmColaboradorCadastro : Form
    {

        ISession Session;
        #region repositorio
        private RepositorioColaborador _repositorio;
        public RepositorioColaborador Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioColaborador(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        #endregion
        Colaborador colaborador;
        public frmColaboradorCadastro(Colaborador _colaborador, ISession _session)
        {
            InitializeComponent();
            Session = _session;
            colaborador = _colaborador;
        }

        private void AtualizaColaborador()
        {
            colaborador.Nome = txtNome.Text;
            colaborador.TipoPessoa = (TipoPessoa)rdgFisicaJuridica.SelectedIndex;
            colaborador.Endereco = txtEndereco.Text;
            colaborador.Bairro = txtBairro.Text;
            colaborador.Complemento = txtComplemento.Text;
            if (!String.IsNullOrEmpty(txtNascimento.Text))
                colaborador.Nascimento = txtNascimento.DateTime.Date;
            colaborador.Documento = Int64.Parse(Normalizadores.SomenteNumeros(txtDocumento.Text));
            colaborador.Telefone = txtTelefone.Text;
            colaborador.Telefone2 = txtTelefone2.Text;
            colaborador.Email = txtEmail.Text;
            if (!String.IsNullOrEmpty(dateAdmissao.Text))
                colaborador.Admissao = dateAdmissao.DateTime.Date;
            if (!String.IsNullOrEmpty(dateDemissao.Text))
                colaborador.Demissao = dateDemissao.DateTime.Date;
            //cidade
            //setor
            colaborador.Situacao = (Situacao)rbgSituacao.SelectedIndex;

        }
        private void PreeencheCampos()
        {
            txtId.Text = colaborador.Id.ToString();
            txtNome.Text = colaborador.Nome;
            rdgFisicaJuridica.SelectedIndex = colaborador.TipoPessoa.GetHashCode();
            txtEndereco.Text = colaborador.Endereco;
            txtBairro.Text = colaborador.Bairro;
            txtComplemento.Text = colaborador.Complemento;
            if (colaborador.Nascimento != null)
                txtNascimento.DateTime = colaborador.Nascimento.Value;
            if (rdgFisicaJuridica.SelectedIndex == 0)
                txtDocumento.Text = colaborador.Documento.ToString(@"000\.000\.000\-00");
            else
                txtDocumento.Text = colaborador.Documento.ToString(@"00\.000\.000\/0000\-00");
            txtTelefone.Text = colaborador.Telefone;
            txtTelefone2.Text = colaborador.Telefone2;
            txtEmail.Text = colaborador.Email;
            if (colaborador.Admissao != null)
                dateAdmissao.DateTime = colaborador.Admissao.Value;
            if (colaborador.Demissao != null)
                dateDemissao.DateTime = colaborador.Demissao.Value;
            if (colaborador.Cidade != null)
            {
                txtCidade.Text = colaborador.Cidade.Id.ToString();
                lblCidade.Text = colaborador.Cidade.NomeCompleto;
            }
            else
            {
                txtCidade.Text = String.Empty;
                lblCidade.Text = String.Empty;
            }
            if (colaborador.Setor != null)
            {
                txtSetor.Text = colaborador.Setor.Id.ToString();
                lblSetor.Text = colaborador.Setor.Nome;
            }
            else
            {
                txtSetor.Text = String.Empty;
                lblSetor.Text = String.Empty;
            }
            txtGeracao.Text = colaborador.DataGeracao.ToString();
            txtAltercao.Text = colaborador.DataAlteracao.ToString();
            rbgSituacao.SelectedIndex = colaborador.Situacao.GetHashCode();
        }

        private void frmColaboradorCadastro_Load(object sender, EventArgs e)
        {
            PreeencheCampos();
        }

        private void rdgFisicaJuridica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdgFisicaJuridica.SelectedIndex == 0)
            {
                txtDocumento.Properties.Mask.EditMask = "000.000.000-00";
                txtDocumento.Properties.Mask.UseMaskAsDisplayFormat = true;
            }
            else
            {
                txtDocumento.Properties.Mask.EditMask = "00.000.000/0000-00";
                txtDocumento.Properties.Mask.UseMaskAsDisplayFormat = true;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            AtualizaColaborador();

            if ((colaborador.Id == 0) || (String.IsNullOrEmpty(colaborador.Id.ToString())))
                Repositorio.Salvar(colaborador);
            else
                Repositorio.Alterar(colaborador);
            this.DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtCidade_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmPesquisa<Cidade> frm = new frmPesquisa<Cidade>();
            frm.ShowDialog();
            if (frm.objeto != null)
            {
                txtCidade.Text = frm.objeto.Id.ToString();
                lblCidade.Text = frm.objeto.NomeCompleto;
            }
        }

        private void txtSetor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmPesquisa<Setor> frm = new frmPesquisa<Setor>();
            frm.ShowDialog();
            if (frm.objeto != null)
            {
                txtSetor.Text = frm.objeto.Id.ToString();
                lblSetor.Text = frm.objeto.Nome;
            }
        }

        private void txtCidade_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCidade.Text))
            {
                try
                {
                    colaborador.Cidade = new RepositorioCidade(Session).ObterPorId(Int64.Parse(txtCidade.Text));
                }
                catch (Exception)
                {
                    colaborador.Cidade = null;
                }
                lblCidade.Text = colaborador.Cidade != null ? colaborador.Cidade.NomeCompleto : "Cidade não localizada!";
            }
            else
            {
                colaborador.Cidade = null;
                lblCidade.Text = string.Empty;
            }
        }

        private void txtSetor_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSetor.Text))
            {
                try
                {
                    colaborador.Setor = new RepositorioSetor(Session).ObterPorId(Int64.Parse(txtSetor.Text));
                }
                catch (Exception)
                {
                    colaborador.Setor = null;
                }
                lblSetor.Text = colaborador.Setor != null ? colaborador.Setor.Nome : "Setor não localizado!";
            }
            else
            {
                colaborador.Setor = null;
                lblSetor.Text = string.Empty;
            }
        }
    }
}
