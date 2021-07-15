
namespace SGE.App.Formularios
{
    partial class frmUsuarioCadastro
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
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
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
            this.rbgTipoUsuario = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbgSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltercao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeracao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbgTipoUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(209, 123);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(205, 20);
            this.txtSenha.TabIndex = 43;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(209, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 13);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Senha";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(12, 123);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(194, 20);
            this.txtLogin.TabIndex = 41;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 104);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 13);
            this.labelControl6.TabIndex = 40;
            this.labelControl6.Text = "Login";
            // 
            // rbgSituacao
            // 
            this.rbgSituacao.Location = new System.Drawing.Point(12, 168);
            this.rbgSituacao.Name = "rbgSituacao";
            this.rbgSituacao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Inativo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Ativo")});
            this.rbgSituacao.Size = new System.Drawing.Size(118, 48);
            this.rbgSituacao.TabIndex = 39;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 149);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 38;
            this.labelControl5.Text = "Situação";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(339, 180);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 37;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(260, 180);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 36;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txtAltercao
            // 
            this.txtAltercao.Enabled = false;
            this.txtAltercao.Location = new System.Drawing.Point(284, 32);
            this.txtAltercao.Name = "txtAltercao";
            this.txtAltercao.Size = new System.Drawing.Size(130, 20);
            this.txtAltercao.TabIndex = 35;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(284, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "Data Alteração";
            // 
            // txtGeracao
            // 
            this.txtGeracao.Enabled = false;
            this.txtGeracao.Location = new System.Drawing.Point(148, 32);
            this.txtGeracao.Name = "txtGeracao";
            this.txtGeracao.Size = new System.Drawing.Size(130, 20);
            this.txtGeracao.TabIndex = 33;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(148, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Data Geração";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(402, 20);
            this.txtNome.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(12, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(130, 20);
            this.txtId.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 13);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Cod";
            // 
            // rbgTipoUsuario
            // 
            this.rbgTipoUsuario.Location = new System.Drawing.Point(136, 168);
            this.rbgTipoUsuario.Name = "rbgTipoUsuario";
            this.rbgTipoUsuario.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Admin"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Usuário")});
            this.rbgTipoUsuario.Size = new System.Drawing.Size(118, 48);
            this.rbgTipoUsuario.TabIndex = 45;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(136, 149);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(20, 13);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "Tipo";
            // 
            // frmUsuarioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 233);
            this.Controls.Add(this.rbgTipoUsuario);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtLogin);
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
            this.Name = "frmUsuarioCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarioCadastro";
            this.Load += new System.EventHandler(this.frmUsuarioCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbgSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltercao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeracao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbgTipoUsuario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.LabelControl labelControl6;
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
        private DevExpress.XtraEditors.RadioGroup rbgTipoUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}