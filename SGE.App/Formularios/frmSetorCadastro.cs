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
    public partial class frmSetorCadastro : Form
    {
        ISession Session;
        #region repositorio
        private RepositorioSetor _repositorio;
        public RepositorioSetor Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioSetor(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        #endregion
        Setor setor;
        public frmSetorCadastro(Setor _setor, ISession _session)
        {
            InitializeComponent();
            Session = _session;
            setor = _setor;
        }

        private void PreencheCampos()
        {
            txtId.Text = setor.Id.ToString();
            txtNome.Text = setor.Nome;
            txtGeracao.Text = setor.DataGeracao.ToString();
            txtAltercao.Text = setor.DataAlteracao.ToString();
            rbgSituacao.SelectedIndex = setor.Situacao.GetHashCode();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            AtualizaSetor();

            if ((setor.Id == 0)||(String.IsNullOrEmpty(setor.Id.ToString())))
            {
                //setor.Id = Convert.ToInt64(txtId.Text.Trim());
                Repositorio.Salvar(setor);
            }
            else
                Repositorio.Alterar(setor);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void AtualizaSetor()
        {
            setor.Nome = txtNome.Text;
            setor.Situacao = (Situacao)rbgSituacao.SelectedIndex;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmSetorCadastro_Load(object sender, EventArgs e)
        {
            PreencheCampos();
        }
    }
}
