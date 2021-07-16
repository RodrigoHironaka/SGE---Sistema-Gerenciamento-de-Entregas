using SGE.App.Formularios.Login;
using SGE.App.Formularios.Utilidades;
using SGE.Monitor;
using SGE.Repositorio.Configuracao;
using SGE.Repositorio.Ferramentas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.App
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                
                if (File.Exists(Ferramentas.CaminhoArquivoXML()))
                {
                    var session = NHibernateHelper.GetSession(true);
                    Application.Run(new frmPrincipal());
                    
                }
                else
                {
                    frmConfiguracao f = new frmConfiguracao();
                    f.WindowState = FormWindowState.Normal;
                    f.ShowDialog();
                    Application.Run(new frmPrincipal());
                    
                }
            }
            catch (Exception)
            {
                frmConfiguracao f = new frmConfiguracao();
                f.WindowState = FormWindowState.Normal;
                f.ShowDialog();
                Application.Run(new frmPrincipal());
            }
            
            
        }
    }
}
