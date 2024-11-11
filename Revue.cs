﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivre2
{
    internal class Revue : Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }


        public Revue(string titre, string auteur, int nbrPages, int numero, int annee) : base(titre, auteur, nbrPages)
        {

            Numero = numero;
            Annee = annee;
        }


        public override void AfficherDetails()
        {
            Console.WriteLine($"Le titre du livre est: {Titre}, rédigé par {Auteur} en {Annee}, contenant {NombrePages}, il s'agit du {Numero} de l'auteur");
        }
    }
}
