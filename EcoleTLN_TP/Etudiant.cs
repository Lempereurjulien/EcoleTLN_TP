﻿using Classes.ClassesEcole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleTLN_TP
{
    class Etudiant:Contact
    {
        private string section;
        public Etudiant(int matricule, string nom, int anneeArrivee,string section) : base(matricule, nom, anneeArrivee)
        {
            this.section = section;
        }
    }
}
