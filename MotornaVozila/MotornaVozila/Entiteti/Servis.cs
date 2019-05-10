﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class Servis
    {
        public virtual int id { get; protected set; }
        public virtual DateTime datumPrijema { get; set; }
        //public virtual int idSef { get; protected set; }
        //public virtual int idSalon { get; protected set; }
        public virtual DateTime datumZavrsetka { get; set; }
        public virtual string tipuUsluge { get; set; }
        //public virtual int idtehnicar { get; protected set; }

        public virtual Zaposleni odgovorniTehnicar { get; set; }
    }
}
