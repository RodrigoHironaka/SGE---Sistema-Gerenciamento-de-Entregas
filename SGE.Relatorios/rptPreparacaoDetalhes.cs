using DevExpress.XtraReports.UI;
using SGE.Dominio.Entidades;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace SGE.Relatorios
{
    public partial class rptPreparacaoDetalhes : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPreparacaoDetalhes()
        {
            InitializeComponent();
        }

        private void rptPreparacaoDetalhes_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var row = (Preparacao)this.GetCurrentRow();
            if (row != null)
            {
                var sub = (XRSubreport)sender;
                sub.ReportSource = new rptSubPreparacaoDetalhes();

                sub.ReportSource.DataSource = row.PreparacaoSetores;
            }
        }
    }
}
