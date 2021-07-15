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
    public partial class frmFormaPagamentoCadastro : Form
    {
        ISession Session;
        #region Repositorio
        private RepositorioFormaPagamento _repositorio;
        public RepositorioFormaPagamento Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioFormaPagamento(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion
        FormaPagamento formaPagamento;

        private void AtualizaFormaPagamento()
        {
            formaPagamento.Nome = txtNome.Text;
            formaPagamento.Situacao = (Situacao)rbgSituacao.SelectedIndex;
        }

        private void PreencheCampos()
        {
            txtId.Text = formaPagamento.Id.ToString();
            txtNome.Text = formaPagamento.Nome;
            txtGeracao.Text = formaPagamento.DataGeracao.ToString();
            txtAltercao.Text = formaPagamento.DataAlteracao.ToString();
            rbgSituacao.SelectedIndex = formaPagamento.Situacao.GetHashCode();
        }

        public frmFormaPagamentoCadastro(FormaPagamento _formaPagamento, ISession _session)
        {
            InitializeComponent();
            Session = _session;
            formaPagamento = _formaPagamento;
        }
       

        private void btSalvar_Click(object sender, EventArgs e)
        {
            AtualizaFormaPagamento();

            if ((formaPagamento.Id == 0) || (String.IsNullOrEmpty(formaPagamento.Id.ToString())))
            {
                Repositorio.Salvar(formaPagamento);
            }
            else
                Repositorio.Alterar(formaPagamento);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmFormaPagamentoCadastro_Load(object sender, EventArgs e)
        {
            PreencheCampos();
        }
    }
}
