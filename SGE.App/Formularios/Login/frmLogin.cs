using DevExpress.XtraEditors;
using Doctus.Utils.Text;
using NHibernate;
using SGE.Dominio.Entidades;
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

namespace SGE.App.Formularios.Login
{
    public partial class frmLogin : Form
    {
        #region Session
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

        public static string UsuarioLogado;
        public static string UsuarioTipo;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtSenha.Text))
            {
                usuario = Repositorio.ObterPorParametros(x => x.Login == txtUsuario.Text).FirstOrDefault();
               
                if(usuario != null)
                {
                    UsuarioLogado = usuario.Login;
                    UsuarioTipo = usuario.TipoUsuario.ToString();
                    if (usuario.Senha == Criptografia.GerarHashSHA1(txtSenha.Text))
                        this.DialogResult = DialogResult.OK;
                    else
                        XtraMessageBox.Show("Senha Inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    XtraMessageBox.Show("Usuario não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                XtraMessageBox.Show("Usuario ou Senha invalidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                btSair_Click(sender, e);
            }
        }
    }
}
