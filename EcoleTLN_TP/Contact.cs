using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Contact
    {
        private int matricule;
        private string nom;
        private int anneeArrivee;

        public Contact( int matricule, string nom, int anneeArrivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArrivee = anneeArrivee;
        }       
    }

    class Etudiant :Contact
    { 
        private string section;
        public Etudiant(int matricule, string nom, int anneeArrivee, string section):base(matricule,nom,anneeArrivee) 
        {
            this.section = section;
        }
    }

    class EtudiantEchange : Etudiant
    {
        public string universiteOrigine; 
        public EtudiantEchange(int matricule, string nom, int anneeArrivee, string section, string universiteOrigine) : base(matricule, nom, anneeArrivee, section)
        {
            this.universiteOrigine = universiteOrigine;
        }
    }
    class EtudiantRegulier:Etudiant
    {
        public double noteMoyenne;
        EtudiantRegulier(int matricule, string nom, int anneeArrivee, string section, double noteMoyenne) : base(matricule, nom, anneeArrivee, section)
        {
            this.noteMoyenne = noteMoyenne;
        }
    }

    class Personnel:Contact
    {
        private string nomLaboratoire;
        private double salaire;
        public Personnel(int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire) : base(matricule, nom, anneeArrivee)
        {
            this.nomLaboratoire = nomLaboratoire;
            this.salaire = salaire;
        }
    }

}
