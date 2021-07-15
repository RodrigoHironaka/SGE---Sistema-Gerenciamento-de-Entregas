
namespace SGE.App.Formularios
{
    partial class frmUsuarioConsulta
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
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btNovo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // grdConsulta
            // 
            this.grdConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdConsulta.Location = new System.Drawing.Point(16, 12);
            this.grdConsulta.MainView = this.gvwConsulta;
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.Size = new System.Drawing.Size(769, 397);
            this.grdConsulta.TabIndex = 11;
            this.grdConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwConsulta});
            // 
            // gvwConsulta
            // 
            this.gvwConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNome,
            this.colLogin,
            this.ColSituacao,
            this.colTipoUsuario});
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
            this.colId.Width = 65;
            // 
            // colNome
            // 
            this.colNome.Caption = "Nome";
            this.colNome.FieldName = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 1;
            this.colNome.Width = 208;
            // 
            // colLogin
            // 
            this.colLogin.AppearanceCell.Options.UseTextOptions = true;
            this.colLogin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogin.AppearanceHeader.Options.UseTextOptions = true;
            this.colLogin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogin.Caption = "Login";
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 2;
            this.colLogin.Width = 219;
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
            this.ColSituacao.Width = 95;
            // 
            // colTipoUsuario
            // 
            this.colTipoUsuario.Caption = "Tipo";
            this.colTipoUsuario.FieldName = "TipoUsuario";
            this.colTipoUsuario.Name = "colTipoUsuario";
            this.colTipoUsuario.Visible = true;
            this.colTipoUsuario.VisibleIndex = 3;
            this.colTipoUsuario.Width = 98;
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.Location = new System.Drawing.Point(178, 415);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAlterar.Location = new System.Drawing.Point(97, 415);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNovo.Location = new System.Drawing.Point(16, 415);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 8;
            this.btNovo.Text = "Novo";
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // frmUsuarioConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdConsulta);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Name = "frmUsuarioConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarioConsulta";
            this.Load += new System.EventHandler(this.frmUsuarioConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl grdConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn ColSituacao;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoUsuario;
        private DevExpress.XtraEditors.SimpleButton btExcluir;
        private DevExpress.XtraEditors.SimpleButton btAlterar;
        private DevExpress.XtraEditors.SimpleButton btNovo;
    }
}