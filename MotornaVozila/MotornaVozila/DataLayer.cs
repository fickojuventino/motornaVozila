using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MotornaVozila.Mapiranja;

namespace MotornaVozila
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();

        // konfiguracija baze podataka
        // kreiranje i konfigurisanje SessionFactory objekta
        public static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10.ConnectionString(
                    c => c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs/SBP_PDB;User Id=S15315;Password=S15315"));
                return Fluently.Configure().Database(cfg).Mappings(m => m.FluentMappings.AddFromAssemblyOf<ZaposleniMapiranje>())
                    .BuildSessionFactory();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }
        }

        // implementacija singleton pattern-a koja obezbedjuje samo jednu instancu SessionFactory objekta u aplikaciji
        // metoda kreira i otvara nHibernate sesiju
        public static ISession GetSession()
        {
            // ukoliko session factory nije kreiran
            if(_factory == null)
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }

            return _factory.OpenSession();
        }
    }
}
