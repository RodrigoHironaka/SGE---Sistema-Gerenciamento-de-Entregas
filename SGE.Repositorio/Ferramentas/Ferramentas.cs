﻿
using MySql.Data.MySqlClient;
using NHibernate;
using NHibernate.Cfg;
using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;
using SGE.Repositorio.Configuracao;
using SGE.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SGE.Repositorio.Ferramentas
{
    public class Ferramentas
    {
        #region
        private static ISession session;

        protected static ISession Session
        {
            get
            {
                if (session == null || !session.IsOpen)
                {
                    if (session != null)
                        session.Dispose();
                    session = NHibernateHelper.GetSession();
                }
                return session;
            }
        }
        #endregion

        #region repositorio
        private RepositorioPreparacao _repositorio;
        public RepositorioPreparacao Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioPreparacao(Session);

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        #endregion

       
        public static List<String> LerXML()
        {
            try
            {
                List<String> configuracoes = new List<String>();
                if (File.Exists(@"D:\Projetos\WEB\SGE\SGE.App\bin\Debug\config.xml"))
                {

                    var xml = XDocument.Load("config.xml");
                    configuracoes.Add(xml.Element("config").Attribute("Servidor").Value);
                    configuracoes.Add(xml.Element("config").Attribute("Porta").Value);
                    configuracoes.Add(xml.Element("config").Attribute("Banco").Value);
                    configuracoes.Add(xml.Element("config").Attribute("Usuario").Value);
                    configuracoes.Add(xml.Element("config").Attribute("Senha").Value);
                    configuracoes.Add((string)xml.Element("config").Attribute("Tipo") == "Terminal" ? "0" : "1");
                    configuracoes.Add(xml.Element("config").Attribute("CaminhoBackup").Value);
                    configuracoes.Add(xml.Element("config").Attribute("TempoAlerta").Value);
                    configuracoes.Add(xml.Element("config").Attribute("TempoAtualiza").Value);
                }
                return configuracoes;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public static string CaminhoArquivoXML()
        {
            var caminho = @"D:\Projetos\WEB\SGE\SGE.App\bin\Debug\config.xml";
            return  caminho;
        }

       public static string StringConexao()
        {
            var configuracoes = LerXML();
            var conexao = "Server=" + configuracoes[0] + ";Port=" + configuracoes[1] + ";Database=" + configuracoes[2] + ";Uid=" + configuracoes[3] + ";Pwd=" + configuracoes[4] + ";";
            return conexao;
        }

       public static void TesteConexao()
        {
            //Testar Conexao
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = StringConexao();
            conexao.Open();
            conexao.Close();
        } // usando mysqlconnection

    }
}
