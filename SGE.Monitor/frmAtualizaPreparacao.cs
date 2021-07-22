using NHibernate;
using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;
using SGE.Monitor.Properties;
using SGE.Repositorio.Configuracao;
using SGE.Repositorio.Ferramentas;
using SGE.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SGE.Monitor
{
    public partial class frmAtualizaPreparacao : Form
    {
        #region
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

        NotifyIcon notifyIcon;
        public void Notify()
        {
            
            notifyIcon = new NotifyIcon()
            {
                Icon = Resources.icone3_sem_fundo_32x321,
                Text = "SGE - Monitor",
                ContextMenu = new ContextMenu(new MenuItem[]
                {
                    new MenuItem("Exibir", Exibir),
                    new MenuItem("Sair", Sair)
                }),
                Visible = true
            };
            
        }

        private Thread thread;
        private void VerificaTempoExcedido()
        {
            while (true)
            {
                try
                {
                    listBoxPreparacoes.Items.Clear();
                    
                    var listaPendentes = Repositorio.ObterPorParametros(x => x.SituacaoPreparacao == SituacaoPreparacao.Pendente).ToList();
                    
                    if (listaPendentes != null)
                    {
                        
                        foreach (var item in listaPendentes)
                        {
                            listBoxPreparacoes.Items.Add(item.DadosPreparacao);
                            
                            var configuracoes = Ferramentas.LerXML();
                            var HoraGeracaoMaisTempoDefinido = item.DataGeracao.Value.AddMinutes(Double.Parse(configuracoes[7]));
                            var HoraAtual = DateTime.Now;
                            if (HoraAtual > HoraGeracaoMaisTempoDefinido)
                            {
                                item.SituacaoPreparacao = SituacaoPreparacao.Excedido;
                                Repositorio.Alterar(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    Thread.Sleep(5000);
                }
            }
            
        }

        public void IniciaThread()
        {
            thread = new Thread(new ThreadStart(VerificaTempoExcedido));
            thread.IsBackground = true;
            thread.Start();
        }

        void Exibir(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;

            this.Show();
        }

        void Sair(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            thread.Abort();
            Application.Exit();
        }

        public frmAtualizaPreparacao()
        {
            InitializeComponent();
            Notify();
            IniciaThread();

        }

        private void AtualizaPreparacao_Load(object sender, EventArgs e)
        {
        }

        private void frmAtualizaPreparacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            notifyIcon.Visible = true;
        }

     
    }
}
