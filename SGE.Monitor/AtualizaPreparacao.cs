﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.Monitor
{
    public partial class AtualizaPreparacao : Form
    {
        NotifyIcon notifyIcon;
        public AtualizaPreparacao()
        {
            InitializeComponent();
            notifyIcon = new NotifyIcon()
            {
                //Icon = Properties.Resources.;
                Text = "SGE - Monitor",
                ContextMenu = new ContextMenu(new MenuItem[]
                {
                    new MenuItem("Exibir", Exibir),
                    new MenuItem("Sair", Sair)
                }),
                Visible = true
            };
            
            
        }

        void Exibir(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;

            this.Show();
        }

        void Sair(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;

            //clicouSair = true;
            Application.Exit();
        }

        private void AtualizaPreparacao_Load(object sender, EventArgs e)
        {
            labelControl1.Text = "oi, ola";
        }
    }
}
