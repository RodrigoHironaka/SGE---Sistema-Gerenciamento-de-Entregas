
namespace SGE.App.Formularios
{
    partial class frmClienteConsulta
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
            this.btExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btNovo = new DevExpress.XtraEditors.SimpleButton();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBairro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCidade = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.grdConsulta.Size = new System.Drawing.Size(773, 397);
            this.grdConsulta.TabIndex = 19;
            this.grdConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwConsulta});
            // 
            // gvwConsulta
            // 
            this.gvwConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNome,
            this.colTel,
            this.colTel2,
            this.colEnd,
            this.colBairro,
            this.colCompl,
            this.colResp,
            this.colCidade});
            this.gvwConsulta.GridControl = this.grdConsulta;
            this.gvwConsulta.Name = "gvwConsulta";
            this.gvwConsulta.OptionsView.ShowAutoFilterRow = true;
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
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 62;
            // 
            // colNome
            // 
            this.colNome.Caption = "Nome";
            this.colNome.FieldName = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 1;
            this.colNome.Width = 147;
            // 
            // colTel
            // 
            this.colTel.Caption = "Telefone";
            this.colTel.FieldName = "Telefone";
            this.colTel.Name = "colTel";
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 2;
            this.colTel.Width = 76;
            // 
            // colTel2
            // 
            this.colTel2.Caption = "Telefone2";
            this.colTel2.FieldName = "Telefone2";
            this.colTel2.Name = "colTel2";
            this.colTel2.Visible = true;
            this.colTel2.VisibleIndex = 3;
            this.colTel2.Width = 78;
            // 
            // colEnd
            // 
            this.colEnd.Caption = "Endereço";
            this.colEnd.FieldName = "Endereco";
            this.colEnd.Name = "colEnd";
            this.colEnd.Visible = true;
            this.colEnd.VisibleIndex = 4;
            this.colEnd.Width = 138;
            // 
            // colBairro
            // 
            this.colBairro.Caption = "Bairro";
            this.colBairro.FieldName = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.Visible = true;
            this.colBairro.VisibleIndex = 5;
            this.colBairro.Width = 92;
            // 
            // colCompl
            // 
            this.colCompl.Caption = "Complemento";
            this.colCompl.FieldName = "Complemento";
            this.colCompl.Name = "colCompl";
            this.colCompl.Visible = true;
            this.colCompl.VisibleIndex = 6;
            this.colCompl.Width = 73;
            // 
            // colResp
            // 
            this.colResp.Caption = "Responsáveis";
            this.colResp.FieldName = "Responsaveis";
            this.colResp.Name = "colResp";
            this.colResp.Visible = true;
            this.colResp.VisibleIndex = 7;
            this.colResp.Width = 56;
            // 
            // colCidade
            // 
            this.colCidade.Caption = "Cidade";
            this.colCidade.FieldName = "Cidade.Nome";
            this.colCidade.Name = "colCidade";
            this.colCidade.Visible = true;
            this.colCidade.VisibleIndex = 8;
            this.colCidade.Width = 33;
            // 
            // frmClienteConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdConsulta);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Name = "frmClienteConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClienteConsulta";
            this.Load += new System.EventHandler(this.frmClienteConsulta_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colTel2;
        private DevExpress.XtraGrid.Columns.GridColumn colEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colBairro;
        private DevExpress.XtraGrid.Columns.GridColumn colCompl;
        private DevExpress.XtraGrid.Columns.GridColumn colResp;
        private DevExpress.XtraGrid.Columns.GridColumn colCidade;
    }
}