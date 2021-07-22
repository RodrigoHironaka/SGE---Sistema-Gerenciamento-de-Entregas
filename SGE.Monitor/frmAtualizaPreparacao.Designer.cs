
namespace SGE.Monitor
{
    partial class frmAtualizaPreparacao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtualizaPreparacao));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxPreparacoes = new DevExpress.XtraEditors.ListBoxControl();
            this.pictureCarregando = new DevExpress.XtraEditors.PictureEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxPreparacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarregando.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(198, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Verificando Preparações";
            // 
            // listBoxPreparacoes
            // 
            this.listBoxPreparacoes.Location = new System.Drawing.Point(12, 55);
            this.listBoxPreparacoes.Name = "listBoxPreparacoes";
            this.listBoxPreparacoes.Size = new System.Drawing.Size(245, 116);
            this.listBoxPreparacoes.TabIndex = 2;
            // 
            // pictureCarregando
            // 
            this.pictureCarregando.EditValue = ((object)(resources.GetObject("pictureCarregando.EditValue")));
            this.pictureCarregando.Location = new System.Drawing.Point(216, 3);
            this.pictureCarregando.Name = "pictureCarregando";
            this.pictureCarregando.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureCarregando.Properties.Appearance.Options.UseBackColor = true;
            this.pictureCarregando.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureCarregando.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureCarregando.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureCarregando.Size = new System.Drawing.Size(41, 37);
            this.pictureCarregando.TabIndex = 3;
            // 
            // frmAtualizaPreparacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 191);
            this.Controls.Add(this.pictureCarregando);
            this.Controls.Add(this.listBoxPreparacoes);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtualizaPreparacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAtualizaPreparacao_FormClosing);
            this.Load += new System.EventHandler(this.AtualizaPreparacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxPreparacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCarregando.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxPreparacoes;
        private DevExpress.XtraEditors.PictureEdit pictureCarregando;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}

