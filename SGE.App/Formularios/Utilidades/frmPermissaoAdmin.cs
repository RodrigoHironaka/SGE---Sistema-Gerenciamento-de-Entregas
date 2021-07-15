using DevExpress.XtraEditors;
using Doctus.Utils.Text;
using NHibernate;
using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;
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

namespace SGE.App.Formularios.Utilidades
{
    public partial class frmPermissaoAdmin : Form
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

        public frmPermissaoAdmin()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtSenha.Text))
            {
                usuario = Repositorio.ObterPorParametros(x => x.Login == txtUsuario.Text && x.TipoUsuario == TipoUsuario.Administrador && x.Situacao == Situacao.Ativo).FirstOrDefault();

                if (usuario != null)
                {
                    if (usuario.Senha == Criptografia.GerarHashSHA1(txtSenha.Text))
                        this.DialogResult = DialogResult.OK;
                    else
                        XtraMessageBox.Show("Senha Inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    XtraMessageBox.Show("Usuário Inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                XtraMessageBox.Show("Existem campos em brancos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmPermissaoAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                btSair_Click(sender, e);
            }
        }
    }
}
