using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class Zaposleni
    {
        public virtual int id { get; protected set; }
        public virtual int maticniBroj { get; protected set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual int godineRadnogStaza { get; set; }
        public virtual DateTime datumZaposlenja { get; set; }
        public virtual DateTime datumRodjenja { get; set; }
        public virtual int stepenStrucneSpreme { get; set; }
        public virtual float plata { get; set; }
        public virtual string tipZaposlenog { get; set; }
        public virtual string tipUgovora { get; set; }
        public virtual DateTime datumIstekaUgovora { get; set; }
    }
}
