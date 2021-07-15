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
    public partial class frmBackupRestore : Form
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

        public frmBackupRestore()
        {
            InitializeComponent();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rgBackupRestore.SelectedIndex == 0)
                {
                    string data = System.DateTime.Now.ToShortDateString().Replace("/", "");
                    string hora = System.DateTime.Now.ToLongTimeString().Replace(":", "");
                    string caminhoSalvar = txtCaminho.Text + "\\SGE" + data + "_" + hora + ".sql";
                    
                    using (MySqlConnection conn = new MySqlConnection(Ferramentas.StringConexao()))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup bk = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                splash.ShowWaitForm();
                                bk.ExportToFile(caminhoSalvar);
                                splash.CloseWaitForm();
                                conn.Close();
                            }
                        }
                    }
                    btGerar.Appearance.BackColor = Color.Green;
                }
                else
                {
                    using (MySqlConnection conn = new MySqlConnection(Ferramentas.StringConexao()))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup bk = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                splash.ShowWaitForm();
                                bk.ImportFromFile(txtCaminho.Text);
                                splash.CloseWaitForm();
                                conn.Close();
                            }
                        }
                    }
                    btGerar.Appearance.BackColor = Color.Green;
                }

            }
            catch (Exception ex)
            {
                //throw new Exception("Houve um erro ao realizar o backup! Contate o suporte técnico" + ex.ToString());
                btGerar.Appearance.BackColor = Color.Red;
            }
        }

        private void txtCaminho_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(rgBackupRestore.SelectedIndex == 0)
            {
                using (FolderBrowserDialog caminho = new FolderBrowserDialog())
                {
                    DialogResult res = caminho.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        txtCaminho.Text = caminho.SelectedPath;
                    }
                }
            }
            else
            {
                using (OpenFileDialog caminho = new OpenFileDialog())
                {
                    DialogResult res = caminho.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        txtCaminho.Text = caminho.FileName;
                    }
                }
            }
            
        }

        private void frmBackupRestore_Load(object sender, EventArgs e)
        {
            var configuracoes = Ferramentas.LerXML();
            txtCaminho.Text = configuracoes[6].ToString();
        }

        private void rgBackupRestore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgBackupRestore.SelectedIndex == 0)
            {
                txtCaminho.Text = string.Empty;
                btGerar.Text = "Gerar backup";
                btGerar.Appearance.BackColor = Color.Empty;
            }

            if (rgBackupRestore.SelectedIndex == 1)
            {
                txtCaminho.Text = string.Empty;
                btGerar.Text = "Restaurar backup";
                btGerar.Appearance.BackColor = Color.Empty;
            }

        }
    }
}
