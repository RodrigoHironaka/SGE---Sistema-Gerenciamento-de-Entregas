
namespace SGE.App.Formularios
{
    partial class frmDevolucaoCadastro
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
            this.txtGeracao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.rdgTipoDevolucao = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbMotivo = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPreparacao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomePessoa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.memoObs = new DevExpress.XtraEditors.MemoEdit();
            this.txtValorDevolvido = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtColaborador = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeracao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgTipoDevolucao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreparacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomePessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDevolvido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColaborador.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGeracao
            // 
            this.txtGeracao.Enabled = false;
            this.txtGeracao.Location = new System.Drawing.Point(284, 31);
            this.txtGeracao.Name = "txtGeracao";
            this.txtGeracao.Size = new System.Drawing.Size(130, 20);
            this.txtGeracao.TabIndex = 329;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(284, 11);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(66, 13);
            this.labelControl11.TabIndex = 328;
            this.labelControl11.Text = "Data Geração";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(12, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(130, 20);
            this.txtId.TabIndex = 327;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(12, 11);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(19, 13);
            this.labelControl12.TabIndex = 326;
            this.labelControl12.Text = "Cod";
            // 
            // rdgTipoDevolucao
            // 
            this.rdgTipoDevolucao.Location = new System.Drawing.Point(446, 17);
            this.rdgTipoDevolucao.Name = "rdgTipoDevolucao";
            this.rdgTipoDevolucao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Completa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Parcial")});
            this.rdgTipoDevolucao.Size = new System.Drawing.Size(143, 34);
            this.rdgTipoDevolucao.TabIndex = 330;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(420, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 331;
            this.labelControl3.Text = "Tipo";
            // 
            // cbMotivo
            // 
            this.cbMotivo.Location = new System.Drawing.Point(12, 76);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMotivo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", 10, "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cbMotivo.Properties.NullText = "Selecione";
            this.cbMotivo.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbFormaPagamento_Properties_ButtonClick);
            this.cbMotivo.Size = new System.Drawing.Size(130, 20);
            this.cbMotivo.TabIndex = 332;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 57);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 13);
            this.labelControl8.TabIndex = 333;
            this.labelControl8.Text = "Motivo";
            // 
            // txtPreparacao
            // 
            this.txtPreparacao.Enabled = false;
            this.txtPreparacao.Location = new System.Drawing.Point(148, 31);
            this.txtPreparacao.Name = "txtPreparacao";
            this.txtPreparacao.Size = new System.Drawing.Size(130, 20);
            this.txtPreparacao.TabIndex = 335;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(148, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 334;
            this.labelControl1.Text = "Preparação";
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(148, 77);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(322, 20);
            this.txtNomePessoa.TabIndex = 337;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(148, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 336;
            this.labelControl2.Text = "Quem Devolveu?";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(476, 57);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 13);
            this.labelControl4.TabIndex = 338;
            this.labelControl4.Text = "Valor Devolvido";
            // 
            // memoObs
            // 
            this.memoObs.Location = new System.Drawing.Point(12, 121);
            this.memoObs.Name = "memoObs";
            this.memoObs.Size = new System.Drawing.Size(577, 187);
            this.memoObs.TabIndex = 340;
            // 
            // txtValorDevolvido
            // 
            this.txtValorDevolvido.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtValorDevolvido.Location = new System.Drawing.Point(476, 76);
            this.txtValorDevolvido.Name = "txtValorDevolvido";
            this.txtValorDevolvido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtValorDevolvido.Properties.DisplayFormat.FormatString = "N2";
            this.txtValorDevolvido.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtValorDevolvido.Size = new System.Drawing.Size(113, 20);
            this.txtValorDevolvido.TabIndex = 341;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 102);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 342;
            this.labelControl5.Text = "Observação";
            // 
            // txtColaborador
            // 
            this.txtColaborador.Enabled = false;
            this.txtColaborador.Location = new System.Drawing.Point(12, 334);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(415, 20);
            this.txtColaborador.TabIndex = 344;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 314);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 343;
            this.labelControl6.Text = "Colaborador";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(514, 331);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 346;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(433, 331);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 345;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // frmDevolucaoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 367);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtColaborador);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtValorDevolvido);
            this.Controls.Add(this.memoObs);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtNomePessoa);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtPreparacao);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbMotivo);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.rdgTipoDevolucao);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtGeracao);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelControl12);
            this.Name = "frmDevolucaoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDevolucaoCadastro";
            this.Load += new System.EventHandler(this.frmDevolucaoCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGeracao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgTipoDevolucao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreparacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomePessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoObs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDevolvido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColaborador.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtGeracao;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.RadioGroup rdgTipoDevolucao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cbMotivo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtPreparacao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomePessoa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit memoObs;
        private DevExpress.XtraEditors.SpinEdit txtValorDevolvido;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtColaborador;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.SimpleButton btSalvar;
    }
}