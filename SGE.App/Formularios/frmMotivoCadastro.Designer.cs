
namespace SGE.App.Formularios
{
    partial class frmMotivoCadastro
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
            ((System.ComponentModel.ISupportInitialize)(this.rbgSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltercao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeracao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rbgSituacao
            // 
            this.rbgSituacao.Location = new System.Drawing.Point(62, 109);
            this.rbgSituacao.Name = "rbgSituacao";
            this.rbgSituacao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Inativo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Ativo")});
            this.rbgSituacao.Size = new System.Drawing.Size(74, 48);
            this.rbgSituacao.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 109);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Situação";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(341, 122);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 33;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(262, 122);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 32;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txtAltercao
            // 
            this.txtAltercao.Enabled = false;
            this.txtAltercao.Location = new System.Drawing.Point(286, 37);
            this.txtAltercao.Name = "txtAltercao";
            this.txtAltercao.Size = new System.Drawing.Size(130, 20);
            this.txtAltercao.TabIndex = 31;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(286, 17);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Data Alteração";
            // 
            // txtGeracao
            // 
            this.txtGeracao.Enabled = false;
            this.txtGeracao.Location = new System.Drawing.Point(150, 37);
            this.txtGeracao.Name = "txtGeracao";
            this.txtGeracao.Size = new System.Drawing.Size(130, 20);
            this.txtGeracao.TabIndex = 29;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(150, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "Data Geração";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(402, 20);
            this.txtNome.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(14, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(130, 20);
            this.txtId.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 13);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Cod";
            // 
            // frmMotivoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 175);
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
            this.Name = "frmMotivoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMotivoCadastro";
            this.Load += new System.EventHandler(this.frmMotivoCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbgSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltercao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeracao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
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
    }
}