
namespace SGE.App.Formularios.Utilidades
{
    partial class frmDefineEntregador
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
            this.lblColaborador = new DevExpress.XtraEditors.LabelControl();
            this.txtColaborador = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaida = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtColaborador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaida.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColaborador
            // 
            this.lblColaborador.Location = new System.Drawing.Point(101, 28);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(27, 13);
            this.lblColaborador.TabIndex = 318;
            this.lblColaborador.Text = "Nome";
            // 
            // txtColaborador
            // 
            this.txtColaborador.EnterMoveNextControl = true;
            this.txtColaborador.Location = new System.Drawing.Point(12, 25);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtColaborador.Size = new System.Drawing.Size(83, 20);
            this.txtColaborador.TabIndex = 316;
            this.txtColaborador.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtColaborador_ButtonClick);
            this.txtColaborador.Validating += new System.ComponentModel.CancelEventHandler(this.txtColaborador_Validating);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 13);
            this.labelControl7.TabIndex = 317;
            this.labelControl7.Text = "Colaborador";
            // 
            // txtSaida
            // 
            this.txtSaida.Enabled = false;
            this.txtSaida.Location = new System.Drawing.Point(12, 75);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(130, 20);
            this.txtSaida.TabIndex = 325;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(12, 55);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(26, 13);
            this.labelControl11.TabIndex = 324;
            this.labelControl11.Text = "Saída";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(196, 72);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 340;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // frmDefineEntregador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 107);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.lblColaborador);
            this.Controls.Add(this.txtColaborador);
            this.Controls.Add(this.labelControl7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDefineEntregador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDefineEntregador";
            this.Load += new System.EventHandler(this.frmDefineEntregador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtColaborador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaida.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblColaborador;
        private DevExpress.XtraEditors.ButtonEdit txtColaborador;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtSaida;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btSalvar;
    }
}