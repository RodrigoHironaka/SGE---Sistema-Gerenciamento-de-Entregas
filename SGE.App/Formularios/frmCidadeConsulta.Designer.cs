
namespace SGE.App.Formularios
{
    partial class frmCidadeConsulta
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
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btNovo = new DevExpress.XtraEditors.SimpleButton();
            this.colCep = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // grdConsulta
            // 
            this.grdConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdConsulta.Location = new System.Drawing.Point(25, 12);
            this.grdConsulta.MainView = this.gvwConsulta;
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.Size = new System.Drawing.Size(760, 397);
            this.grdConsulta.TabIndex = 7;
            this.grdConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwConsulta});
            // 
            // gvwConsulta
            // 
            this.gvwConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNome,
            this.colUf,
            this.ColSituacao,
            this.colCep});
            this.gvwConsulta.GridControl = this.grdConsulta;
            this.gvwConsulta.Name = "gvwConsulta";
            this.gvwConsulta.OptionsView.ShowAutoFilterRow = true;
            // 
            // colId
            // 
            this.colId.AppearanceCell.Options.UseTextOptions = true;
            this.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 78;
            // 
            // colNome
            // 
            this.colNome.Caption = "Nome";
            this.colNome.FieldName = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 1;
            this.colNome.Width = 463;
            // 
            // colUf
            // 
            this.colUf.AppearanceCell.Options.UseTextOptions = true;
            this.colUf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUf.AppearanceHeader.Options.UseTextOptions = true;
            this.colUf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUf.Caption = "UF";
            this.colUf.FieldName = "UnidadeFederacao";
            this.colUf.Name = "colUf";
            this.colUf.Visible = true;
            this.colUf.VisibleIndex = 2;
            // 
            // ColSituacao
            // 
            this.ColSituacao.AppearanceCell.Options.UseTextOptions = true;
            this.ColSituacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColSituacao.AppearanceHeader.Options.UseTextOptions = true;
            this.ColSituacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColSituacao.Caption = "Situação";
            this.ColSituacao.FieldName = "Situacao";
            this.ColSituacao.Name = "ColSituacao";
            this.ColSituacao.Visible = true;
            this.ColSituacao.VisibleIndex = 4;
            this.ColSituacao.Width = 126;
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.Location = new System.Drawing.Point(178, 415);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAlterar.Location = new System.Drawing.Point(97, 415);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 5;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNovo.Location = new System.Drawing.Point(16, 415);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 4;
            this.btNovo.Text = "Novo";
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // colCep
            // 
            this.colCep.Caption = "CEP";
            this.colCep.FieldName = "Cep";
            this.colCep.Name = "colCep";
            this.colCep.Visible = true;
            this.colCep.VisibleIndex = 3;
            // 
            // frmCidadeConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdConsulta);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Name = "frmCidadeConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCidadeConsulta";
            this.Load += new System.EventHandler(this.frmCidadeConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl grdConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwConsulta;
        private DevExpress.XtraEditors.SimpleButton btExcluir;
        private DevExpress.XtraEditors.SimpleButton btAlterar;
        private DevExpress.XtraEditors.SimpleButton btNovo;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colUf;
        private DevExpress.XtraGrid.Columns.GridColumn ColSituacao;
        private DevExpress.XtraGrid.Columns.GridColumn colCep;
    }
}