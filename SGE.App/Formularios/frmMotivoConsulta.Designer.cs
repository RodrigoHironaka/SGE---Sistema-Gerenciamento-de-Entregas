
namespace SGE.App.Formularios
{
    partial class frmMotivoConsulta
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
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAlteracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataGeracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btNovo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // grdConsulta
            // 
            this.grdConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdConsulta.Location = new System.Drawing.Point(12, 12);
            this.grdConsulta.MainView = this.gvwConsulta;
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.Size = new System.Drawing.Size(776, 397);
            this.grdConsulta.TabIndex = 19;
            this.grdConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwConsulta});
            // 
            // gvwConsulta
            // 
            this.gvwConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colDescricao,
            this.colSituacao,
            this.colDataAlteracao,
            this.colDataGeracao});
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
            this.colCodigo.FieldName = "Id";
            this.colCodigo.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 81;
            // 
            // colDescricao
            // 
            this.colDescricao.FieldName = "Nome";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 2;
            this.colDescricao.Width = 551;
            // 
            // colSituacao
            // 
            this.colSituacao.AppearanceCell.Options.UseTextOptions = true;
            this.colSituacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colSituacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituacao.FieldName = "Situacao";
            this.colSituacao.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.Visible = true;
            this.colSituacao.VisibleIndex = 1;
            this.colSituacao.Width = 57;
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
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.Location = new System.Drawing.Point(178, 415);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 18;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAlterar.Location = new System.Drawing.Point(97, 415);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 17;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNovo.Location = new System.Drawing.Point(16, 415);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 16;
            this.btNovo.Text = "Novo";
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // frmMotivoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdConsulta);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Name = "frmMotivoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMotivoConsulta";
            this.Load += new System.EventHandler(this.frmMotivoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAlteracao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataGeracao;
        private DevExpress.XtraEditors.SimpleButton btExcluir;
        private DevExpress.XtraEditors.SimpleButton btAlterar;
        private DevExpress.XtraEditors.SimpleButton btNovo;
    }
}