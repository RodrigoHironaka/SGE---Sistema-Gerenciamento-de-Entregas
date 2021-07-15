using DevExpress.XtraGrid.Columns;
using NHibernate;
using SGE.Dominio.Interface;
using SGE.Dominio.ObjetoValor;
using SGE.Repositorio;
using SGE.Repositorio.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.App.Formularios
{
    public partial class frmPesquisa<T> : Form where T : class, IEntidade
    {
        private Boolean SessionCompartilhada = true;

        #region Controle da Session
        private ISession session;

        protected ISession Session
        {
            get
            {
                if (session == null || !session.IsOpen)
                {
                    if (session != null)
                        session.Dispose();

                    session = NHibernateHelper.GetSession();
                    SessionCompartilhada = false;
                }
                return session;
            }
        }
        #endregion

        #region Repositorio
        private RepositorioBase<T> _repositorio;
        public RepositorioBase<T> Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioBase<T>(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion

        public T objeto;

        private void CriaColunas()
        {
            var tipo = typeof(T);
            var campos = tipo.GetProperties();
            foreach (var c in campos)
            {
                if (c.PropertyType.Name.Equals("IList`1"))
                    continue;
                gvwPesquisa.Columns.AddVisible(c.Name);
            }
        }

        private void BestFit()
        {
            foreach (GridColumn coluna in gvwPesquisa.Columns)
            {
                if ((coluna.ColumnType == typeof(String)) || (coluna.ColumnType == typeof(Int32)) || (coluna.ColumnType == typeof(Decimal)) || (coluna.ColumnType == typeof(Int64)))
                    coluna.BestFit();
            }
        }

        private void SelecionaEFecha()
        {
            if (gvwPesquisa.SelectedRowsCount != 0)
            {
                foreach (int handler in gvwPesquisa.GetSelectedRows())
                {
                    objeto = (T)gvwPesquisa.GetRow(handler);
                }
            }
            Close();
        }

        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            if (gvwPesquisa.Columns.Count == 0)
                CriaColunas();

            grdPesquisa.DataSource = Repositorio.ObterTodos();

            if (gvwPesquisa.ActiveFilter.Count == 0)
                BestFit();

            gvwPesquisa.FocusedRowHandle = -999997;
        }

        private void frmPesquisa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((session != null) && (!SessionCompartilhada))
            {
                if (session.IsOpen)
                    session.Close();
                session.Dispose();
            }
        }

        private void gvwPesquisa_DoubleClick(object sender, EventArgs e)
        {
            SelecionaEFecha();
        }

        private void frmPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SelecionaEFecha();
        }

        private void frmPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
