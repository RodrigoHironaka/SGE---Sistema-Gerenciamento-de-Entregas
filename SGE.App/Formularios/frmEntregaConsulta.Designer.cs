
namespace SGE.App.Formularios
{
    partial class frmEntregaConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdConsulta = new DevExpress.XtraGrid.GridControl();
            this.gvwConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreparacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColaborador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAlteracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataGeracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChegada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTempo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // grdConsulta
            // 
            this.grdConsulta.Location = new System.Drawing.Point(12, 12);
            this.grdConsulta.MainView = this.gvwConsulta;
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.Size = new System.Drawing.Size(776, 397);
            this.grdConsulta.TabIndex = 25;
            this.grdConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwConsulta});
            // 
            // gvwConsulta
            // 
            this.gvwConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colPreparacao,
            this.colColaborador,
            this.colDataAlteracao,
            this.colDataGeracao,
            this.colMotivo,
            this.colSaida,
            this.colChegada,
            this.colTempo});
            this.gvwConsulta.GridControl = this.grdConsulta;
            this.gvwConsulta.Name = "gvwConsulta";
            this.gvwConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gvwConsulta.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigo
            // 
            this.colCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.Caption = "Entrega";
            this.colCodigo.FieldName = "Id";
            this.colCodigo.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 45;
            // 
            // colPreparacao
            // 
            this.colPreparacao.AppearanceCell.Options.UseTextOptions = true;
            this.colPreparacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPreparacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colPreparacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPreparacao.Caption = "Preparação";
            this.colPreparacao.FieldName = "Preparacao.Id";
            this.colPreparacao.Name = "colPreparacao";
            this.colPreparacao.Visible = true;
            this.colPreparacao.VisibleIndex = 1;
            // 
            // colColaborador
            // 
            this.colColaborador.Caption = "Colaborador";
            this.colColaborador.FieldName = "Colaborador.Nome";
            this.colColaborador.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colColaborador.Name = "colColaborador";
            this.colColaborador.Visible = true;
            this.colColaborador.VisibleIndex = 2;
            this.colColaborador.Width = 164;
            // 
            // colDataAlteracao
            // 
            this.colDataAlteracao.FieldName = "DataAlteracao";
            this.colDataAlteracao.Name = "colDataAlteracao";
            this.colDataAlteracao.Width = 138;
            // 
            // colDataGeracao
            // 
            this.colDataGeracao.FieldName = "DataGeracao";
            this.colDataGeracao.Name = "colDataGeracao";
            this.colDataGeracao.Width = 176;
            // 
            // colMotivo
            // 
            this.colMotivo.Caption = "Data";
            this.colMotivo.DisplayFormat.FormatString = "d";
            this.colMotivo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colMotivo.FieldName = "DataGeracao";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.Visible = true;
            this.colMotivo.VisibleIndex = 3;
            this.colMotivo.Width = 97;
            // 
            // colSaida
            // 
            this.colSaida.Caption = "Saída";
            this.colSaida.DisplayFormat.FormatString = "HH:mm";
            this.colSaida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSaida.FieldName = "Saida";
            this.colSaida.Name = "colSaida";
            this.colSaida.Visible = true;
            this.colSaida.VisibleIndex = 4;
            this.colSaida.Width = 72;
            // 
            // colChegada
            // 
            this.colChegada.Caption = "Chegada";
            this.colChegada.DisplayFormat.FormatString = "HH:mm";
            this.colChegada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colChegada.FieldName = "Chegada";
            this.colChegada.Name = "colChegada";
            this.colChegada.Visible = true;
            this.colChegada.VisibleIndex = 5;
            this.colChegada.Width = 72;
            // 
            // colTempo
            // 
            this.colTempo.Caption = "Tempo";
            this.colTempo.DisplayFormat.FormatString = "hh\\:mm\\:ss";
            this.colTempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTempo.FieldName = "Tempo";
            this.colTempo.Name = "colTempo";
            this.colTempo.Visible = true;
            this.colTempo.VisibleIndex = 6;
            this.colTempo.Width = 78;
            // 
            // frmEntregaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdConsulta);
            this.Name = "frmEntregaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEntregaConsulta";
            this.Load += new System.EventHandler(this.frmEntregaConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colPreparacao;
        private DevExpress.XtraGrid.Columns.GridColumn colColaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAlteracao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataGeracao;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn colSaida;
        private DevExpress.XtraGrid.Columns.GridColumn colChegada;
        private DevExpress.XtraGrid.Columns.GridColumn colTempo;
    }
}