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
    public partial class frmCidadeCadastro : Form
    {
        ISession Session;
        #region Repositorio
        private RepositorioCidade _repositorio;
        public RepositorioCidade Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioCidade(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion
        Cidade cidade;

        private void AtualizaCliente()
        {
            cidade.Nome = txtNome.Text;
            cidade.UnidadeFederacao = txtUF.Text;
            try
            {
                cidade.Cep = Int32.Parse(Normalizadores.SomenteNumeros(txtCEP.Text.Trim()));
            }
            catch {}
            cidade.Situacao = (Situacao)rbgSituacao.SelectedIndex;
        }

        private void PreencheCampos()
        {
            txtId.Text = cidade.Id.ToString();
            txtNome.Text = cidade.Nome;
            txtUF.Text = cidade.UnidadeFederacao;
            txtCEP.Text = cidade.Cep.ToString("00000000");
            txtGeracao.Text = cidade.DataGeracao.ToString();
            txtAltercao.Text = cidade.DataAlteracao.ToString();
            rbgSituacao.SelectedIndex = cidade.Situacao.GetHashCode();
        }

        public frmCidadeCadastro(Cidade _cidade, ISession _session)
        {
            InitializeComponent();
            Session = _session;
            cidade = _cidade;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            AtualizaCliente();

            if ((cidade.Id == 0) || (String.IsNullOrEmpty(cidade.Id.ToString())))
                Repositorio.Salvar(cidade);
            else
                Repositorio.Alterar(cidade);
            this.DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmCidadeCadastro_Load(object sender, EventArgs e)
        {
            PreencheCampos();
        }
    }
}
