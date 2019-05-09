﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class NezavisniEkonomista
    {
        public virtual int id { get; protected set; }
        public virtual string ime { get; set; }
        public virtual int maticniBroj { get; protected set; }
        public virtual int telefon { get; set; }
        public virtual string grad { get; set; }
        public virtual string adresa { get; set; }
    }
}
