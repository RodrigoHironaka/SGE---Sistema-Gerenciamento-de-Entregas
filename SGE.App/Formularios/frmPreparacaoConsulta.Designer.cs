
namespace SGE.App.Formularios
{
    partial class frmPreparacaoConsulta
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
            this.btExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btNovo = new DevExpress.XtraEditors.SimpleButton();
            this.btChegada = new DevExpress.XtraEditors.SimpleButton();
            this.btSaida = new DevExpress.XtraEditors.SimpleButton();
            this.grdConsulta = new DevExpress.XtraGrid.GridControl();
            this.gvwConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAlteracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataGeracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcougue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPadaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaixa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.Location = new System.Drawing.Point(174, 415);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 26;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAlterar.Location = new System.Drawing.Point(93, 415);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 25;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNovo.Location = new System.Drawing.Point(12, 415);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 24;
            this.btNovo.Text = "Novo";
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btChegada
            // 
            this.btChegada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btChegada.Location = new System.Drawing.Point(697, 415);
            this.btChegada.Name = "btChegada";
            this.btChegada.Size = new System.Drawing.Size(75, 23);
            this.btChegada.TabIndex = 29;
            this.btChegada.Text = "Chegada";
            this.btChegada.Click += new System.EventHandler(this.btChegada_Click);
            // 
            // btSaida
            // 
            this.btSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSaida.Location = new System.Drawing.Point(616, 415);
            this.btSaida.Name = "btSaida";
            this.btSaida.Size = new System.Drawing.Size(75, 23);
            this.btSaida.TabIndex = 28;
            this.btSaida.Text = "Saída";
            this.btSaida.Click += new System.EventHandler(this.btSaida_Click);
            // 
            // grdConsulta
            // 
            this.grdConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdConsulta.Location = new System.Drawing.Point(11, 12);
            this.grdConsulta.MainView = this.gvwConsulta;
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.Size = new System.Drawing.Size(761, 397);
            this.grdConsulta.TabIndex = 30;
            this.grdConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwConsulta});
            // 
            // gvwConsulta
            // 
            this.gvwConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colCliente,
            this.colSituacao,
            this.colDataAlteracao,
            this.colDataGeracao,
            this.colAcougue,
            this.colPadaria,
            this.colLoja,
            this.colCaixa,
            this.colValor});
            this.gvwConsulta.GridControl = this.grdConsulta;
            this.gvwConsulta.Name = "gvwConsulta";
            this.gvwConsulta.OptionsSelection.MultiSelect = true;
            this.gvwConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gvwConsulta.OptionsView.ShowFooter = true;
            this.gvwConsulta.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigo
            // 
            this.colCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.Caption = "Preparação";
            this.colCodigo.FieldName = "Id";
            this.colCodigo.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            this.colCodigo.Width = 65;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente.Nome";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 2;
            this.colCliente.Width = 186;
            // 
            // colSituacao
            // 
            this.colSituacao.AppearanceCell.Options.UseTextOptions = true;
            this.colSituacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colSituacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituacao.Caption = "Situação";
            this.colSituacao.FieldName = "SituacaoPreparacao";
            this.colSituacao.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.Visible = true;
            this.colSituacao.VisibleIndex = 0;
            this.colSituacao.Width = 59;
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
            // colAcougue
            // 
            this.colAcougue.AppearanceCell.Options.UseTextOptions = true;
            this.colAcougue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAcougue.AppearanceHeader.Options.UseTextOptions = true;
            this.colAcougue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAcougue.Caption = "Açougue";
            this.colAcougue.FieldName = "Acougue";
            this.colAcougue.Name = "colAcougue";
            this.colAcougue.Visible = true;
            this.colAcougue.VisibleIndex = 4;
            this.colAcougue.Width = 66;
            // 
            // colPadaria
            // 
            this.colPadaria.AppearanceCell.Options.UseTextOptions = true;
            this.colPadaria.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPadaria.AppearanceHeader.Options.UseTextOptions = true;
            this.colPadaria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPadaria.Caption = "Padaria";
            this.colPadaria.FieldName = "Padaria";
            this.colPadaria.Name = "colPadaria";
            this.colPadaria.Visible = true;
            this.colPadaria.VisibleIndex = 5;
            this.colPadaria.Width = 58;
            // 
            // colLoja
            // 
            this.colLoja.AppearanceCell.Options.UseTextOptions = true;
            this.colLoja.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoja.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoja.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoja.Caption = "Loja";
            this.colLoja.FieldName = "Loja";
            this.colLoja.Name = "colLoja";
            this.colLoja.Visible = true;
            this.colLoja.VisibleIndex = 6;
            this.colLoja.Width = 58;
            // 
            // colCaixa
            // 
            this.colCaixa.AppearanceCell.Options.UseTextOptions = true;
            this.colCaixa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCaixa.AppearanceHeader.Options.UseTextOptions = true;
            this.colCaixa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCaixa.Caption = "Caixa";
            this.colCaixa.FieldName = "Caixa";
            this.colCaixa.Name = "colCaixa";
            this.colCaixa.Visible = true;
            this.colCaixa.VisibleIndex = 7;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.DisplayFormat.FormatString = "N2";
            this.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValor.FieldName = "Total";
            this.colValor.Name = "colValor";
            this.colValor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "SUM={0:N2}")});
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 3;
            this.colValor.Width = 118;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelar.Location = new System.Drawing.Point(255, 415);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 31;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmPreparacaoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.grdConsulta);
            this.Controls.Add(this.btChegada);
            this.Controls.Add(this.btSaida);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Name = "frmPreparacaoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPreparacaoConsulta";
            this.Load += new System.EventHandler(this.frmPreparacaoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btExcluir;
        private DevExpress.XtraEditors.SimpleButton btAlterar;
        private DevExpress.XtraEditors.SimpleButton btNovo;
        private DevExpress.XtraEditors.SimpleButton btChegada;
        private DevExpress.XtraEditors.SimpleButton btSaida;
        private DevExpress.XtraGrid.GridControl grdConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAlteracao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataGeracao;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn colAcougue;
        private DevExpress.XtraGrid.Columns.GridColumn colPadaria;
        private DevExpress.XtraGrid.Columns.GridColumn colLoja;
        private DevExpress.XtraGrid.Columns.GridColumn colCaixa;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
    }
}