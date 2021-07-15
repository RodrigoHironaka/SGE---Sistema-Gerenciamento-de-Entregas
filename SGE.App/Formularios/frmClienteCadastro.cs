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
    public partial class frmClienteCadastro : Form
    {
        ISession Session;
        #region repositorio
        private RepositorioCliente _repositorio;
        public RepositorioCliente Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioCliente(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        #endregion
        Cliente cliente;

        public frmClienteCadastro(Cliente _cliente, ISession _session)
        {
            InitializeComponent();
            Session = _session;
            cliente = _cliente;
            rbgSituacao.SelectedIndex = 0;
            txtDocumento.Text = string.Empty;
            
        }

        private void AtualizaCliente()
        {
            cliente.Nome = txtNome.Text;
            cliente.TipoPessoa = (TipoPessoa)rdgFisicaJuridica.SelectedIndex;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Complemento = txtComplemento.Text;
            if (!String.IsNullOrEmpty(txtNascimento.Text))
                cliente.Nascimento = txtNascimento.DateTime.Date;
          
            cliente.Documento = Int64.Parse(Normalizadores.SomenteNumeros(txtDocumento.Text));
            cliente.Telefone = txtTelefone.Text;
            cliente.Telefone2 = txtTelefone2.Text;
            cliente.Email = txtEmail.Text;
            cliente.Responsaveis = txtResponsaveis.Text;
            
            cliente.Situacao = (Situacao)rbgSituacao.SelectedIndex;

        }
        private void PreeencheCampos()
        {
            txtId.Text = cliente.Id.ToString();
            txtNome.Text = cliente.Nome;
            rdgFisicaJuridica.SelectedIndex = cliente.TipoPessoa.GetHashCode();
            txtEndereco.Text = cliente.Endereco;
            txtBairro.Text = cliente.Bairro;
            txtComplemento.Text = cliente.Complemento;
            if(cliente.Nascimento != null)
                txtNascimento.DateTime = cliente.Nascimento.Value;
            if(rdgFisicaJuridica.SelectedIndex == 0)
                txtDocumento.Text = cliente.Documento.ToString(@"000\.000\.000\-00");
            else
                txtDocumento.Text = cliente.Documento.ToString(@"00\.000\.000\/0000\-00");
            txtTelefone.Text = cliente.Telefone;
            txtTelefone2.Text = cliente.Telefone2;
            txtEmail.Text = cliente.Email;
            txtResponsaveis.Text = cliente.Responsaveis;
            if (cliente.Cidade != null)
            {
                txtCidade.Text = cliente.Cidade.Id.ToString();
                lblCidade.Text = cliente.Cidade.NomeCompleto;
            }
            else
            {
                txtCidade.Text = String.Empty;
                lblCidade.Text = String.Empty;
            }
            txtGeracao.Text = cliente.DataGeracao.ToString();
            txtAltercao.Text = cliente.DataAlteracao.ToString();
            rbgSituacao.SelectedIndex = cliente.Situacao.GetHashCode();
        }

        private void frmClienteCadastro_Load(object sender, EventArgs e)
        {
            PreeencheCampos();
        }

        private void rdgFisicaJuridica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdgFisicaJuridica.SelectedIndex == 0)
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
            AtualizaCliente();

            if ((cliente.Id == 0) || (String.IsNullOrEmpty(cliente.Id.ToString())))
                Repositorio.Salvar(cliente);
            else
                Repositorio.Alterar(cliente);
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

        private void txtCidade_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCidade.Text))
            {
                try
                {
                    cliente.Cidade = new RepositorioCidade(Session).ObterPorId(Int64.Parse(txtCidade.Text));
                }
                catch (Exception)
                {
                    cliente.Cidade = null;
                }
                lblCidade.Text = cliente.Cidade != null ? cliente.Cidade.NomeCompleto : "Cidade não localizada!";
            }
            else
            {
                cliente.Cidade = null;
                lblCidade.Text = string.Empty;
            }
        }
    }
}
