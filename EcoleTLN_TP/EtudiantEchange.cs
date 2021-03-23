using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleTLN_TP
{
    class EtudiantEchange:Etudiant
    {
        public string universiteOrigine;
        public EtudiantEchange(int matricule, string nom, int anneeArrivee, string section, string universiteOrigine) : base(matricule, nom, anneeArrivee, section)
        {
            this.universiteOrigine = universiteOrigine;
        }
    }
}
