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
    public partial class frmMotivoCadastro : Form
    {
        ISession Session;
        #region Repositorio
        private RepositorioMotivo _repositorio;
        public RepositorioMotivo Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioMotivo(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion
        Motivo motivo;

        private void AtualizaMotivo()
        {
            motivo.Nome = txtNome.Text;
            motivo.Situacao = (Situacao)rbgSituacao.SelectedIndex;
        }

        private void PreencheCampos()
        {
            txtId.Text = motivo.Id.ToString();
            txtNome.Text = motivo.Nome;
            txtGeracao.Text = motivo.DataGeracao.ToString();
            txtAltercao.Text = motivo.DataAlteracao.ToString();
            rbgSituacao.SelectedIndex = motivo.Situacao.GetHashCode();
        }

        public frmMotivoCadastro(Motivo _motivo, ISession _session)
        {
            InitializeComponent();
            Session = _session;
            motivo = _motivo;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            AtualizaMotivo();

            if ((motivo.Id == 0) || (String.IsNullOrEmpty(motivo.Id.ToString())))
            {
                Repositorio.Salvar(motivo);
            }
            else
                Repositorio.Alterar(motivo);

            this.DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmMotivoCadastro_Load(object sender, EventArgs e)
        {
            PreencheCampos();
        }
    }
}
