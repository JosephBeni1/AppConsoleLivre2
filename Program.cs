using AppConsoleLivre2;

internal class Program
{
    private static void Main(string[] args)
    {

        Revue rev1 = new Revue("Disparition programmée", "Roland Smith", 316, 2, 2013);
        Revue rev2 = new Revue("Elia, la passeuse d'âmes", "Marie Vareille", 307, 3, 2016);
        Revue rev3 = new Revue("Kinshasa Dream", "Anna Kuschnarowa", 324, 4, 2016);

        rev1.AfficherDetails();
        rev2.AfficherDetails();
        rev3.AfficherDetails();



        Roman rom1 = new Roman("Manga", "Dragon Ball", "Akira Toriyama", 150);
        Roman rom2 = new Roman("Manga", "Naruto", "Masashi Kishimoto", 175);
        Roman rom3 = new Roman("Manga", "One Piece", "Eiichiro Oda", 352);

        rom1.AfficherDetails();
        rom2.AfficherDetails();
        rom3.AfficherDetails();

    }
}