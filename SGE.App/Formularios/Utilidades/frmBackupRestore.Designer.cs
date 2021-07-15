
namespace SGE.App.Formularios.Utilidades
{
    partial class frmBackupRestore
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
            this.splash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SGE.App.Formularios.Utilidades.WaitForm1), true, true);
            this.btGerar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rgBackupRestore = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCaminho = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.rgBackupRestore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splash
            // 
            this.splash.ClosingDelay = 500;
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(220, 84);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(97, 23);
            this.btGerar.TabIndex = 0;
            this.btGerar.Text = "Gerar Backup";
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Caminho para salvar";
            // 
            // rgBackupRestore
            // 
            this.rgBackupRestore.Location = new System.Drawing.Point(12, 77);
            this.rgBackupRestore.Name = "rgBackupRestore";
            this.rgBackupRestore.Properties.Columns = 2;
            this.rgBackupRestore.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Backup"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Restaurar")});
            this.rgBackupRestore.Size = new System.Drawing.Size(144, 39);
            this.rgBackupRestore.TabIndex = 5;
            this.rgBackupRestore.SelectedIndexChanged += new System.EventHandler(this.rgBackupRestore_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Escolha um tipo";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(12, 32);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCaminho.Size = new System.Drawing.Size(341, 20);
            this.txtCaminho.TabIndex = 7;
            this.txtCaminho.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCaminho_ButtonClick);
            // 
            // frmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 138);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.rgBackupRestore);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btGerar);
            this.MaximizeBox = false;
            this.Name = "frmBackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackupRestore";
            this.Load += new System.EventHandler(this.frmBackupRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgBackupRestore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminho.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btGerar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup rgBackupRestore;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit txtCaminho;
        private DevExpress.XtraSplashScreen.SplashScreenManager splash;
    }
}