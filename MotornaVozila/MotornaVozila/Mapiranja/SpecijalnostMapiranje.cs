using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Mapiranja
{
    class SpecijalnostMapiranje : ClassMap<Specijalnost>
    {
        public SpecijalnostMapiranje()
        {
            Table("SPECIJALNOST");

            Id(x => x.id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.specijalnost, "SPECIJALNOST");

            // dodati reference
        }
    }
}
