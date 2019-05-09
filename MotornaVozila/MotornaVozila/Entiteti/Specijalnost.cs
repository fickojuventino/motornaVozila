using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class Specijalnost
    {
        public virtual int id { get; protected set; }
        //public virtual int idTehnicar { get; protected set; }
        public virtual string specijalnost { get; protected set; }
    }
}
