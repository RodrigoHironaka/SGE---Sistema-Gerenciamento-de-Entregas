
namespace SGE.App.Formularios.Utilidades
{
    partial class frmConfiguracao
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
            this.groupBackup = new DevExpress.XtraEditors.GroupControl();
            this.txtCaminhoBackupPadrao = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupConfigPreparacao = new DevExpress.XtraEditors.GroupControl();
            this.txtAlertaAtraso = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAtualizaEm = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBancoDados = new DevExpress.XtraEditors.GroupControl();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.rdgServidorTerminal = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtPorta = new DevExpress.XtraEditors.TextEdit();
            this.txtBanco = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtServidor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btTestarConexao = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupBackup)).BeginInit();
            this.groupBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoBackupPadrao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupConfigPreparacao)).BeginInit();
            this.groupConfigPreparacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlertaAtraso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAtualizaEm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBancoDados)).BeginInit();
            this.groupBancoDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgServidorTerminal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBackup
            // 
            this.groupBackup.Controls.Add(this.txtCaminhoBackupPadrao);
            this.groupBackup.Controls.Add(this.labelControl1);
            this.groupBackup.Location = new System.Drawing.Point(229, 12);
            this.groupBackup.Name = "groupBackup";
            this.groupBackup.Size = new System.Drawing.Size(331, 78);
            this.groupBackup.TabIndex = 0;
            this.groupBackup.Text = "Backup";
            // 
            // txtCaminhoBackupPadrao
            // 
            this.txtCaminhoBackupPadrao.Location = new System.Drawing.Point(6, 46);
            this.txtCaminhoBackupPadrao.Name = "txtCaminhoBackupPadrao";
            this.txtCaminhoBackupPadrao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCaminhoBackupPadrao.Size = new System.Drawing.Size(314, 20);
            this.txtCaminhoBackupPadrao.TabIndex = 1;
            this.txtCaminhoBackupPadrao.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCaminhoBackupPadrao_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Caminho padrão para backup";
            // 
            // groupConfigPreparacao
            // 
            this.groupConfigPreparacao.Controls.Add(this.txtAlertaAtraso);
            this.groupConfigPreparacao.Controls.Add(this.labelControl3);
            this.groupConfigPreparacao.Controls.Add(this.txtAtualizaEm);
            this.groupConfigPreparacao.Controls.Add(this.labelControl2);
            this.groupConfigPreparacao.Location = new System.Drawing.Point(229, 96);
            this.groupConfigPreparacao.Name = "groupConfigPreparacao";
            this.groupConfigPreparacao.Size = new System.Drawing.Size(211, 78);
            this.groupConfigPreparacao.TabIndex = 2;
            this.groupConfigPreparacao.Text = "Config Preparação";
            // 
            // txtAlertaAtraso
            // 
            this.txtAlertaAtraso.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAlertaAtraso.Location = new System.Drawing.Point(105, 46);
            this.txtAlertaAtraso.Name = "txtAlertaAtraso";
            this.txtAlertaAtraso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAlertaAtraso.Size = new System.Drawing.Size(92, 20);
            this.txtAlertaAtraso.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(104, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Alerta atraso (min) ";
            // 
            // txtAtualizaEm
            // 
            this.txtAtualizaEm.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAtualizaEm.Location = new System.Drawing.Point(6, 46);
            this.txtAtualizaEm.Name = "txtAtualizaEm";
            this.txtAtualizaEm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAtualizaEm.Size = new System.Drawing.Size(92, 20);
            this.txtAtualizaEm.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Atualiza em (seg)";
            // 
            // groupBancoDados
            // 
            this.groupBancoDados.Controls.Add(this.txtSenha);
            this.groupBancoDados.Controls.Add(this.rdgServidorTerminal);
            this.groupBancoDados.Controls.Add(this.labelControl9);
            this.groupBancoDados.Controls.Add(this.txtPorta);
            this.groupBancoDados.Controls.Add(this.txtBanco);
            this.groupBancoDados.Controls.Add(this.txtUsuario);
            this.groupBancoDados.Controls.Add(this.txtServidor);
            this.groupBancoDados.Controls.Add(this.labelControl8);
            this.groupBancoDados.Controls.Add(this.labelControl6);
            this.groupBancoDados.Controls.Add(this.labelControl7);
            this.groupBancoDados.Controls.Add(this.labelControl4);
            this.groupBancoDados.Controls.Add(this.labelControl5);
            this.groupBancoDados.Location = new System.Drawing.Point(12, 12);
            this.groupBancoDados.Name = "groupBancoDados";
            this.groupBancoDados.Size = new System.Drawing.Size(211, 199);
            this.groupBancoDados.TabIndex = 4;
            this.groupBancoDados.Text = "Banco de dados";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(52, 130);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(145, 20);
            this.txtSenha.TabIndex = 308;
            // 
            // rdgServidorTerminal
            // 
            this.rdgServidorTerminal.Location = new System.Drawing.Point(52, 156);
            this.rdgServidorTerminal.Name = "rdgServidorTerminal";
            this.rdgServidorTerminal.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Terminal"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Servidor")});
            this.rdgServidorTerminal.Size = new System.Drawing.Size(145, 34);
            this.rdgServidorTerminal.TabIndex = 306;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(26, 162);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(20, 13);
            this.labelControl9.TabIndex = 307;
            this.labelControl9.Text = "Tipo";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(52, 52);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(145, 20);
            this.txtPorta.TabIndex = 11;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(52, 78);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(145, 20);
            this.txtBanco.TabIndex = 10;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(52, 104);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(145, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(52, 26);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(145, 20);
            this.txtServidor.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 133);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Senha";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 107);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Usuário";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 81);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Banco";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Porta";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Servidor";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(485, 188);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 342;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btTestarConexao
            // 
            this.btTestarConexao.Location = new System.Drawing.Point(389, 188);
            this.btTestarConexao.Name = "btTestarConexao";
            this.btTestarConexao.Size = new System.Drawing.Size(90, 23);
            this.btTestarConexao.TabIndex = 343;
            this.btTestarConexao.Text = "Testar Conexão";
            this.btTestarConexao.Click += new System.EventHandler(this.btTestarConexao_Click);
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 224);
            this.Controls.Add(this.btTestarConexao);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.groupBancoDados);
            this.Controls.Add(this.groupConfigPreparacao);
            this.Controls.Add(this.groupBackup);
            this.MaximizeBox = false;
            this.Name = "frmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfiguracao";
            this.Load += new System.EventHandler(this.frmConfiguracao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBackup)).EndInit();
            this.groupBackup.ResumeLayout(false);
            this.groupBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoBackupPadrao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupConfigPreparacao)).EndInit();
            this.groupConfigPreparacao.ResumeLayout(false);
            this.groupConfigPreparacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlertaAtraso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAtualizaEm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBancoDados)).EndInit();
            this.groupBancoDados.ResumeLayout(false);
            this.groupBancoDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgServidorTerminal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupBackup;
        private DevExpress.XtraEditors.ButtonEdit txtCaminhoBackupPadrao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupConfigPreparacao;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit txtAtualizaEm;
        private DevExpress.XtraEditors.SpinEdit txtAlertaAtraso;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupBancoDados;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPorta;
        private DevExpress.XtraEditors.TextEdit txtBanco;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtServidor;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.RadioGroup rdgServidorTerminal;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.SimpleButton btTestarConexao;
        private DevExpress.XtraEditors.TextEdit txtSenha;
    }
}