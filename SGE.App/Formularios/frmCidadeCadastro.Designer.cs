
namespace SGE.App.Formularios
{
    partial class frmCidadeCadastro
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
            this.rbgSituacao = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.txtAltercao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtGeracao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUF = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCEP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rbgSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltercao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeracao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCEP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rbgSituacao
            // 
            this.rbgSituacao.Location = new System.Drawing.Point(122, 123);
            this.rbgSituacao.Name = "rbgSituacao";
            this.rbgSituacao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Inativo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Ativo")});
            this.rbgSituacao.Size = new System.Drawing.Size(126, 48);
            this.rbgSituacao.TabIndex = 23;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(122, 104);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Situação";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(339, 135);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 21;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(260, 135);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 20;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txtAltercao
            // 
            this.txtAltercao.Enabled = false;
            this.txtAltercao.Location = new System.Drawing.Point(284, 32);
            this.txtAltercao.Name = "txtAltercao";
            this.txtAltercao.Size = new System.Drawing.Size(130, 20);
            this.txtAltercao.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(284, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Data Alteração";
            // 
            // txtGeracao
            // 
            this.txtGeracao.Enabled = false;
            this.txtGeracao.Location = new System.Drawing.Point(148, 32);
            this.txtGeracao.Name = "txtGeracao";
            this.txtGeracao.Size = new System.Drawing.Size(130, 20);
            this.txtGeracao.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(148, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Data Geração";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(356, 20);
            this.txtNome.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(12, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(130, 20);
            this.txtId.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Cod";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(374, 78);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(40, 20);
            this.txtUF.TabIndex = 25;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(374, 58);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(13, 13);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "UF";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(12, 124);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(104, 20);
            this.txtCEP.TabIndex = 27;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(19, 13);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "CEP";
            // 
            // frmCidadeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 185);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.rbgSituacao);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtAltercao);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtGeracao);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmCidadeCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCidadeCadastro";
            this.Load += new System.EventHandler(this.frmCidadeCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbgSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltercao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeracao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCEP.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rbgSituacao;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.SimpleButton btSalvar;
        private DevExpress.XtraEditors.TextEdit txtAltercao;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtGeracao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUF;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCEP;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}