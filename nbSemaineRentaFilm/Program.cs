namespace nbSemaineRentaFilm;

class Program
{
    static void Main(string[] args)
    {
        double cout = 150;
        double recette = 31;
        double total = 0;
        int semaines = 0;
        
        while (cout > total)
        {
            total = total + recette;
            semaines++;
            recette = recette * 0.8;
        }
        Console.WriteLine($"Il faudra {semaines} semaines avant que le film soit bénéficiaire");    }
}