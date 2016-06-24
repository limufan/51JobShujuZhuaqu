using System;
using System.Web;
using NHibernate;
using NHibernate.Cfg;
using System.IO;

namespace JobShujuZhuaquConsoleApplication
{
    public class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

        public static string ConfigFilePath { set; get; }

        public static ISession OpenSession()
        {
            if (sessionFactory == null)
            {
                if (string.IsNullOrEmpty(ConfigFilePath))
                {
                    ConfigFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HB.config");
                }
                Configuration config = new NHibernate.Cfg.Configuration().Configure(ConfigFilePath);
                sessionFactory = config.BuildSessionFactory();
            }
            return sessionFactory.OpenSession();
        }

        public static void CloseSessionFactory()
        {
            if (sessionFactory != null)
            {
                sessionFactory.Close();
            }
        }
    }
}
