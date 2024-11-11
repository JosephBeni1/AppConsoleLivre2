using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivre2
{
    internal class Roman : Livre
    {
        public string Genre { get; set; }

        public Roman(string genre, string titre, string auteur, int nbrPages) : base(titre, auteur, nbrPages)
        {
            Genre = genre;
        }

        public override void AfficherDetails() 
        {
            Console.WriteLine($"Cet ouvrage est un {Genre},le titre de cet ouvrage est {Titre} ecrit par {Auteur} contenant {NombrePages}");



        }
    }
}
