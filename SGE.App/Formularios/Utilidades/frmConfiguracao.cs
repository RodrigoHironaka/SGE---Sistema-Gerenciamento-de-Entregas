using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using NHibernate;
using SGE.Repositorio.Configuracao;
using SGE.Repositorio.Ferramentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SGE.App.Formularios.Utilidades
{
    public partial class frmConfiguracao : Form
    {
        #region Session
        //private static ISession session;
        //protected static ISession Session
        //{
        //    get
        //    {
        //        if (session == null || !session.IsOpen)
        //        {
        //            if (session != null)
        //                session.Dispose();
        //            session = NHibernateHelper.GetSession();
        //        }
        //        return session;
        //    }
        //}
        #endregion

        #region Gerar e Ler XML
        public void GerarXML()
        {
            try
            {
                var xml = new XDocument(new XElement("config",
                                                   new XAttribute("Servidor", txtServidor.Text),
                                                   new XAttribute("Porta", txtPorta.Text),
                                                   new XAttribute("Banco", txtBanco.Text),
                                                   new XAttribute("Usuario", txtUsuario.Text),
                                                   new XAttribute("Senha", txtSenha.Text),
                                                   new XAttribute("Tipo", rdgServidorTerminal.SelectedIndex == 0 ? "Terminal" : "Servidor"),
                                                   new XAttribute("CaminhoBackup", txtCaminhoBackupPadrao.Text),
                                                   new XAttribute("TempoAlerta", txtAlertaAtraso.Text),
                                                   new XAttribute("TempoAtualiza", txtAtualizaEm.Text)
                                                   ));
                xml.Save("config.xml");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void PreencheCampos()
        {
            
            var configuracoes = Ferramentas.LerXML();
            if (configuracoes.Count > 0)
            {
                txtServidor.Text = configuracoes[0].ToString();
                txtPorta.Text = configuracoes[1].ToString();
                txtBanco.Text = configuracoes[2].ToString();
                txtUsuario.Text = configuracoes[3].ToString();
                txtSenha.Text = configuracoes[4].ToString();
                rdgServidorTerminal.SelectedIndex = Convert.ToInt32(configuracoes[5]);
                txtCaminhoBackupPadrao.Text = configuracoes[6].ToString();
                txtAlertaAtraso.Text = configuracoes[7].ToString();
                txtAtualizaEm.Text  = configuracoes[8].ToString();
            }

        }
        #endregion

        public bool Sucesso = false;
        public bool Gravado = false;
        public frmConfiguracao()
        {
            InitializeComponent();
        }

        private void txtCaminhoBackupPadrao_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (FolderBrowserDialog caminho = new FolderBrowserDialog())
            {
                DialogResult res = caminho.ShowDialog();
                if (res == DialogResult.OK)
                {
                    txtCaminhoBackupPadrao.Text = caminho.SelectedPath;

                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (Gravado == false)
            {
                DialogResult resultado = XtraMessageBox.Show("Deseja sair sem salvar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                    this.Close();
            }
            else if (Sucesso == false)
            {
                DialogResult resultado1 = XtraMessageBox.Show("Deseja sair sem sucesso na conexão?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado1 == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();


        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            PreencheCampos();
        }

        private void btTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                //gera o Arquivo XML com dados da conexao
                GerarXML();
                Gravado = true;

                // em seguida testa a conexao
                var session = NHibernateHelper.GetSession(true);
                btTestarConexao.Appearance.BackColor = Color.Green;
                Sucesso = true;

                this.Close();
            }
            catch (Exception)
            {
                btTestarConexao.Appearance.BackColor = Color.Red;
                Sucesso = false;
                Gravado = false;
            }
        }
    }
}
