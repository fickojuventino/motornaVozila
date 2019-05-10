using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Mapiranja
{
    class SalonMapiranje : ClassMap<Salon>
    {
        public SalonMapiranje()
        {
            Table("SALON");

            Id(x => x.id, "IDSALON").GeneratedBy.TriggerIdentity();

            Map(x => x.grad, "GRAD");
            Map(x => x.adresa, "ADRESA");
            Map(x => x.stepenOpremljenosti, "STEPENOPREMLJENOSTI");

            // dodati reference

        }
    }
}
