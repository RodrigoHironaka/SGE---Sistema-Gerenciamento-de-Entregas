
namespace SGE.App
{
    partial class frmRelPreparacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btImprimir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lblPreparacao = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(67, 69);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 23);
            this.btImprimir.TabIndex = 0;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(148, 69);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lblPreparacao
            // 
            this.lblPreparacao.Location = new System.Drawing.Point(116, 39);
            this.lblPreparacao.Name = "lblPreparacao";
            this.lblPreparacao.Size = new System.Drawing.Size(12, 13);
            this.lblPreparacao.TabIndex = 16;
            this.lblPreparacao.Text = "...";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Preparação";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(10, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.BeepOnError = false;
            this.txtCodigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCodigo_ButtonClick);
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // frmRelPreparacao
            // 
            this.ClientSize = new System.Drawing.Size(289, 117);
            this.Controls.Add(this.lblPreparacao);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btImprimir);
            this.MaximizeBox = false;
            this.Name = "frmRelPreparacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRelPreparacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btCancelar;
        private DevExpress.XtraEditors.LabelControl lblPreparacao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit txtCodigo;
    }
}

