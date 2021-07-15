
namespace SGE.App.Formularios
{
    partial class frmDevolucaoConsulta
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
            this.btAlterar = new DevExpress.XtraEditors.SimpleButton();
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
            this.grdConsulta.TabIndex = 23;
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
            this.colMotivo});
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
            this.colCodigo.Caption = "Id";
            this.colCodigo.FieldName = "Devolucao.Id";
            this.colCodigo.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 63;
            // 
            // colPreparacao
            // 
            this.colPreparacao.AppearanceCell.Options.UseTextOptions = true;
            this.colPreparacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPreparacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colPreparacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPreparacao.Caption = "Preparação";
            this.colPreparacao.FieldName = "Devolucao.Preparacao.Id";
            this.colPreparacao.Name = "colPreparacao";
            this.colPreparacao.Visible = true;
            this.colPreparacao.VisibleIndex = 1;
            this.colPreparacao.Width = 103;
            // 
            // colColaborador
            // 
            this.colColaborador.Caption = "Colaborador";
            this.colColaborador.FieldName = "Devolucao.Colaborador.Nome";
            this.colColaborador.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colColaborador.Name = "colColaborador";
            this.colColaborador.Visible = true;
            this.colColaborador.VisibleIndex = 2;
            this.colColaborador.Width = 226;
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
            this.colMotivo.Caption = "Motivo";
            this.colMotivo.FieldName = "Devolucao.Motivo.Nome";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.Visible = true;
            this.colMotivo.VisibleIndex = 3;
            this.colMotivo.Width = 211;
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAlterar.Location = new System.Drawing.Point(12, 415);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 21;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // frmDevolucaoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdConsulta);
            this.Controls.Add(this.btAlterar);
            this.Name = "frmDevolucaoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDevolucaoConsulta";
            this.Load += new System.EventHandler(this.frmDevolucaoConsulta_Load);
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
        private DevExpress.XtraEditors.SimpleButton btAlterar;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivo;
    }
}