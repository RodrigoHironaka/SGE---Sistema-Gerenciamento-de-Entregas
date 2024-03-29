﻿using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using SGE.Repositorio.Mapeamentos;

namespace SGE.Repositorio.Configuracao
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static Configuration cfg = new Configuration();


        public static ISession GetSession(bool revalidar = false)
        {
            //var configuracoes = Ferramentas.Ferramentas.LerXML();
            if (_sessionFactory == null || revalidar )
            {
            
                    var configure = new Configuration();
                    configure.DataBaseIntegration(db =>
                    {
                        db.Dialect<NHibernate.Dialect.MySQL55InnoDBDialect>();
                        db.Driver<NHibernate.Driver.MySqlDataDriver>();
                        //db.ConnectionString = "Server=" + configuracoes[0] + ";Port=" + configuracoes[1] + ";Database=" + configuracoes[2] + ";Uid=" + configuracoes[3] + ";Pwd=" + configuracoes[4] + ";";
                        db.ConnectionString = "Server=localhost;Port=3306;Database=sge;Uid=root;Pwd=hiro;";
                        db.Timeout = 10;

                        db.LogFormattedSql = false;
                        db.LogSqlInConsole = false;
                        db.AutoCommentSql = false;
                    });

                    var mapper = new ModelMapper();
                    mapper.AddMappings(typeof(ClienteMAP).Assembly.GetTypes());

                    HbmMapping mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
                    configure.AddMapping(mapping);

                    _sessionFactory = configure.BuildSessionFactory();
                    BuildSchema(configure);
            }
            return _sessionFactory.OpenSession();
        }

        private NHibernateHelper()
        {

        }

        private static void BuildSchema(Configuration config)
        {
            new SchemaExport(config).SetOutputFile(@"D:\Projetos\WEB\SGE\Doc\sge.sql").SetDelimiter(";").Create(false, false);
        }

       
    }
}
