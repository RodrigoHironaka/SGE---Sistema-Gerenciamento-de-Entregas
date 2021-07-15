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
    public partial class frmUsuarioCadastro : Form
    {
        ISession Session;
        #region Repositorio
        private RepositorioUsuario _repositorio;
        public RepositorioUsuario Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioUsuario(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion
        Usuario usuario;


        private void AtualizaUsuario()
        {
            usuario.Nome = txtNome.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = !String.IsNullOrEmpty(txtSenha.Text) ? Criptografia.GerarHashSHA1(txtSenha.Text) : Repositorio.ObterPorId(Int64.Parse(txtId.Text)).Senha;
            usuario.Situacao = (Situacao)rbgSituacao.SelectedIndex;
            usuario.TipoUsuario = (TipoUsuario)rbgTipoUsuario.SelectedIndex;
        }

        private void PreencheCampos()
        {
            txtId.Text = usuario.Id.ToString();
            txtNome.Text = usuario.Nome;
            txtLogin.Text = usuario.Login;
            txtSenha.Text = string.Empty;
            txtGeracao.Text = usuario.DataGeracao.ToString();
            txtAltercao.Text = usuario.DataAlteracao.ToString();
            rbgSituacao.SelectedIndex = usuario.Situacao.GetHashCode();
            rbgTipoUsuario.SelectedIndex = usuario.TipoUsuario.GetHashCode();
        }

        public frmUsuarioCadastro(Usuario _usuario, ISession _session)
        {
            InitializeComponent();
            Session = _session;
            usuario = _usuario;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            AtualizaUsuario();

            if ((usuario.Id == 0) || (String.IsNullOrEmpty(usuario.Id.ToString())))
                Repositorio.Salvar(usuario);
            else
                Repositorio.Alterar(usuario);


            this.DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmUsuarioCadastro_Load(object sender, EventArgs e)
        {
            PreencheCampos();
        }
    }
}
