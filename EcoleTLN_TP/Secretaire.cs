using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleTLN_TP
{
    class Secretaire:Personnel
    {
        public secretaire(int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire) : base(matricule, nom, anneeArrivee, nomLaboratoire, salaire)
        {

        }
    }
}
