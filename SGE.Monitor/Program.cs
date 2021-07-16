using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.Monitor
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process Monitor = Process.GetCurrentProcess();
            string aProcName = Monitor.ProcessName;
            if (Process.GetProcessesByName(aProcName).Length < 1)
            {
                return;
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ExecutaMonitor());
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmAtualizaPreparacao());
        }
    }

    public class ExecutaMonitor : ApplicationContext
    {
        public ExecutaMonitor()
        {
            frmAtualizaPreparacao AtualizaPreparacao = new frmAtualizaPreparacao();
            AtualizaPreparacao.Hide();
        }
    }
}
