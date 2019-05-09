using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class Salon
    {
        public virtual int id { get; protected set; }
        public virtual string grad { get; set; }
        public virtual string adresa { get; set; }
        //public virtual int idZaposleni { get; protected set; }
        public virtual float stepenOpremljenosti { get; set; }
    }
}
