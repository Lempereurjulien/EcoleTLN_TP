using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleTLN_TP
{
    class EtudiantRegulier:Etudiant
    {
        public double noteMoyenne;
        EtudiantRegulier(int matricule, string nom, int anneeArrivee, string section,double noteMoyenne) : base(matricule,nom, anneeArrivee,section)
        {
            this.noteMoyenne = noteMoyenne;
        }
    }
}
