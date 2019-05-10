﻿using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Mapiranja
{
    class ServisMapiranje : ClassMap<Servis>
    {
        public ServisMapiranje()
        {
            Table("SERVIS");

            Id(x => x.id, "IDSERVIS").GeneratedBy.TriggerIdentity();

            Map(x => x.datumPrijema, "DATUMPRIJEMA");
            Map(x => x.datumZavrsetka, "DATUMZAVRSETKA");
            Map(x => x.tipuUsluge, "TIPUSLUGE");

            // reference dodati
            References(x => x.odgovorniTehnicar).Column("IDTEHNICAR").LazyLoad();
        }
    }
}
