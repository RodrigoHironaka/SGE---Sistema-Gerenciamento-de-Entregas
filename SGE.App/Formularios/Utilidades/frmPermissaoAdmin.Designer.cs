
namespace SGE.App.Formularios.Utilidades
{
    partial class frmPermissaoAdmin
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
            this.btSair = new DevExpress.XtraEditors.SimpleButton();
            this.btEntrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbUsuario = new DevExpress.XtraEditors.LabelControl();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(123, 103);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "Cancelar";
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(42, 103);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(75, 23);
            this.btEntrar.TabIndex = 10;
            this.btEntrar.Text = "Permitir";
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Senha";
            // 
            // lbUsuario
            // 
            this.lbUsuario.Location = new System.Drawing.Point(12, 12);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(36, 13);
            this.lbUsuario.TabIndex = 8;
            this.lbUsuario.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 77);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(215, 20);
            this.txtSenha.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(215, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // frmPermissaoAdmin
            // 
            this.AcceptButton = this.btEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 140);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmPermissaoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPermissaoAdmin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPermissaoAdmin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btSair;
        private DevExpress.XtraEditors.SimpleButton btEntrar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbUsuario;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
    }
}