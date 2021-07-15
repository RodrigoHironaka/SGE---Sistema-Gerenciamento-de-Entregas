
namespace SGE.App.Formularios
{
    partial class frmPesquisa<T>
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
            this.grdPesquisa = new DevExpress.XtraGrid.GridControl();
            this.gvwPesquisa = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPesquisa
            // 
            this.grdPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPesquisa.Location = new System.Drawing.Point(0, 0);
            this.grdPesquisa.MainView = this.gvwPesquisa;
            this.grdPesquisa.Name = "grdPesquisa";
            this.grdPesquisa.Size = new System.Drawing.Size(584, 360);
            this.grdPesquisa.TabIndex = 2;
            this.grdPesquisa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwPesquisa});
            // 
            // gvwPesquisa
            // 
            this.gvwPesquisa.GridControl = this.grdPesquisa;
            this.gvwPesquisa.Name = "gvwPesquisa";
            this.gvwPesquisa.OptionsBehavior.Editable = false;
            this.gvwPesquisa.OptionsBehavior.ReadOnly = true;
            this.gvwPesquisa.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvwPesquisa.OptionsView.ColumnAutoWidth = false;
            this.gvwPesquisa.OptionsView.ShowAutoFilterRow = true;
            this.gvwPesquisa.OptionsView.ShowGroupPanel = false;
            this.gvwPesquisa.DoubleClick += new System.EventHandler(this.gvwPesquisa_DoubleClick);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.grdPesquisa);
            this.MinimizeBox = false;
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPesquisa_FormClosed);
            this.Load += new System.EventHandler(this.frmPesquisa_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPesquisa_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPesquisa_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl grdPesquisa;
        public DevExpress.XtraGrid.Views.Grid.GridView gvwPesquisa;
    }
}