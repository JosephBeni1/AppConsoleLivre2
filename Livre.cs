﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivre2
{
    internal class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NombrePages { get; set; }


        public Livre(string titre, string auteur, int nbrPages)
        {

            Titre = titre;
            Auteur = auteur;
            NombrePages = nbrPages;

        }

        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Le livre s'appelle: {Titre} écrit par {Auteur} avec un total de {NombrePages} pages");
        }



    }
}
