using DevExpress.XtraEditors;
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
    public partial class frmDefineEntregador : Form
    {
        ISession Session;
        Preparacao preparacao;
        List<Preparacao> linhas; //linhas selecionadas no grid control

        #region repositorio
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

        #region Repositorio Entrega
        private RepositorioEntrega _repositorioEntrega;
        public RepositorioEntrega RepositorioEntregas
        {
            get
            {
                if (_repositorioEntrega == null)
                    _repositorioEntrega = new RepositorioEntrega(Session);

                return _repositorioEntrega;
            }
            set { _repositorioEntrega = value; }
        }
        #endregion

        public frmDefineEntregador(Preparacao _preparacao, ISession _session, List<Preparacao> _linhas)
        {
            InitializeComponent();
            Session = _session;
            preparacao = _preparacao;
            linhas = _linhas;
        }

        private void txtColaborador_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmPesquisa<Colaborador> frm = new frmPesquisa<Colaborador>();
            frm.ShowDialog();
            if(frm.objeto != null)
            {
                txtColaborador.Text = frm.objeto.Id.ToString();
                lblColaborador.Text = frm.objeto.DadosColaboradorSetor;
            }
        }

        private void txtColaborador_Validating(object sender, CancelEventArgs e)
        {

        }

        private void frmDefineEntregador_Load(object sender, EventArgs e)
        {
            txtSaida.Text = DateTime.Now.ToString();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            foreach (var item in linhas)
            {
                //Entrega entrega = new Entrega();

                //if (entrega.Colaborador == null)
                //    entrega.Colaborador = new RepositorioColaborador(Session).ObterPorId(Int64.Parse(txtColaborador.Text));
                //entrega.Saida = DateTime.Parse(txtSaida.Text);
                //entrega.Preparacao = item;
                //RepositorioEntregas.Salvar(entrega);

                Entrega teste = new Entrega
                {
                    Colaborador = new RepositorioColaborador(Session).ObterPorId(Int64.Parse(txtColaborador.Text)),
                    Saida = DateTime.Parse(txtSaida.Text),
                    Preparacao = item
                };
                RepositorioEntregas.Salvar(teste);


                item.SituacaoPreparacao = SituacaoPreparacao.Saiu;
                item.Entrega = teste;
                Repositorio.Alterar(item);
                
            }
            
            this.DialogResult = DialogResult.OK;
        }
    }
}
