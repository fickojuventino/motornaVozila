﻿using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Mapiranja
{
    class VoziloMapiranje : ClassMap<Vozilo>
    {
        public VoziloMapiranje()
        {
            Table("VOZILO");

            Id(x => x.id, "IDVOZILO").GeneratedBy.TriggerIdentity();

            Map(x => x.brojSasije, "BRSASIJE");
            Map(x => x.boja, "BOJA");
            Map(x => x.brojMotora, "BROJMOTORA");
            Map(x => x.gorivo, "GORIVO");
            Map(x => x.modelVozila, "MODELVOZILA");
            Map(x => x.kubikaza, "KUBIKAZA");
            Map(x => x.datumUvoza, "DATUMUVOZA");
            Map(x => x.brojPutnika, "BROJPUTNIKA");
            Map(x => x.tipProstora, "TIPPROSTORA");
            Map(x => x.nosivost, "NOSIVOST");
            Map(x => x.datumKupovine, "DATUMKUPOVINE");
            Map(x => x.poznato, "POZNATO");
            Map(x => x.opisProblema, "OPISPROBLEMA");
            Map(x => x.ime, "IME");
            Map(x => x.prezime, "PREZIME");
            Map(x => x.telefon, "TELEFON");
            Map(x => x.tipVozila, "TIPVOZILA");
            Map(x => x.registarskiBroj, "REGBR");
            Map(x => x.godinaProizvodnje, "GODPROIZVODNJE");

            // dodati reference
        }
    }
}
