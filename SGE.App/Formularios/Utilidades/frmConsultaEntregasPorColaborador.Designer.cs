
namespace SGE.App.Formularios.Utilidades
{
    partial class frmConsultaEntregasPorColaborador
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
            this.grdConEntregasColaborador = new DevExpress.XtraGrid.GridControl();
            this.gvwConEntregasColaborador = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPreparacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevolucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblColaborador = new DevExpress.XtraEditors.LabelControl();
            this.txtColaborador = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdConEntregasColaborador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConEntregasColaborador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColaborador.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdConEntregasColaborador
            // 
            this.grdConEntregasColaborador.EmbeddedNavigator.DoubleClick += new System.EventHandler(this.grdConEntregasColaborador_EmbeddedNavigator_DoubleClick);
            this.grdConEntregasColaborador.Location = new System.Drawing.Point(12, 65);
            this.grdConEntregasColaborador.MainView = this.gvwConEntregasColaborador;
            this.grdConEntregasColaborador.Name = "grdConEntregasColaborador";
            this.grdConEntregasColaborador.Size = new System.Drawing.Size(444, 187);
            this.grdConEntregasColaborador.TabIndex = 31;
            this.grdConEntregasColaborador.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwConEntregasColaborador});
            this.grdConEntregasColaborador.DoubleClick += new System.EventHandler(this.grdConEntregasColaborador_DoubleClick);
            // 
            // gvwConEntregasColaborador
            // 
            this.gvwConEntregasColaborador.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPreparacao,
            this.colCliente,
            this.colValor,
            this.colDevolucao});
            this.gvwConEntregasColaborador.GridControl = this.grdConEntregasColaborador;
            this.gvwConEntregasColaborador.Name = "gvwConEntregasColaborador";
            this.gvwConEntregasColaborador.OptionsBehavior.Editable = false;
            this.gvwConEntregasColaborador.OptionsSelection.MultiSelect = true;
            this.gvwConEntregasColaborador.OptionsView.ShowGroupPanel = false;
            this.gvwConEntregasColaborador.DoubleClick += new System.EventHandler(this.gvwConEntregasColaborador_DoubleClick);
            // 
            // colPreparacao
            // 
            this.colPreparacao.Caption = "Preparação";
            this.colPreparacao.FieldName = "Id";
            this.colPreparacao.Name = "colPreparacao";
            this.colPreparacao.Visible = true;
            this.colPreparacao.VisibleIndex = 0;
            this.colPreparacao.Width = 99;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente.Nome";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 1;
            this.colCliente.Width = 332;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.FieldName = "Total";
            this.colValor.Name = "colValor";
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 2;
            this.colValor.Width = 72;
            // 
            // colDevolucao
            // 
            this.colDevolucao.Caption = "Devolução";
            this.colDevolucao.FieldName = "Devolucao.Id";
            this.colDevolucao.Name = "colDevolucao";
            this.colDevolucao.Visible = true;
            this.colDevolucao.VisibleIndex = 3;
            this.colDevolucao.Width = 100;
            // 
            // lblColaborador
            // 
            this.lblColaborador.Location = new System.Drawing.Point(101, 34);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(27, 13);
            this.lblColaborador.TabIndex = 321;
            this.lblColaborador.Text = "Nome";
            // 
            // txtColaborador
            // 
            this.txtColaborador.EnterMoveNextControl = true;
            this.txtColaborador.Location = new System.Drawing.Point(12, 31);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtColaborador.Size = new System.Drawing.Size(83, 20);
            this.txtColaborador.TabIndex = 319;
            this.txtColaborador.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtColaborador_ButtonClick);
            this.txtColaborador.Leave += new System.EventHandler(this.txtColaborador_Leave);
            this.txtColaborador.Validating += new System.ComponentModel.CancelEventHandler(this.txtColaborador_Validating);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 13);
            this.labelControl7.TabIndex = 320;
            this.labelControl7.Text = "Colaborador";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(382, 28);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 341;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // frmConsultaEntregasPorColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 265);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lblColaborador);
            this.Controls.Add(this.txtColaborador);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.grdConEntregasColaborador);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaEntregasPorColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaEntregasPorColaborador";
            ((System.ComponentModel.ISupportInitialize)(this.grdConEntregasColaborador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwConEntregasColaborador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColaborador.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdConEntregasColaborador;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwConEntregasColaborador;
        private DevExpress.XtraGrid.Columns.GridColumn colPreparacao;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraEditors.LabelControl lblColaborador;
        private DevExpress.XtraEditors.ButtonEdit txtColaborador;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btSalvar;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colDevolucao;
    }
}