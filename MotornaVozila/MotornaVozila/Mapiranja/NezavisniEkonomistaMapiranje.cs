﻿using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Mapiranja
{
    class NezavisniEkonomistaMapiranje : ClassMap<NezavisniEkonomista>
    {
        public NezavisniEkonomistaMapiranje()
        {
            Table("NEZAVISNIEKONOMISTA");

            Id(x => x.id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.ime, "IME");
            Map(x => x.prezime, "PREZIME");
            Map(x => x.maticniBroj, "MATBR");
            Map(x => x.telefon, "TELEFON");
            Map(x => x.grad, "GRAD");
            Map(x => x.adresa, "ADRESA");

        }
    }
}
