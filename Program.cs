namespace _6._6._boekhouder;
class Program
{
    static void Main(string[] args)
    {
        string input = "";
        int getal = 0;
        int total = 0;
        int sumPos = 0;
        int sumNeg = 0;
        double avg = 0.0;
        List<int> getallenLijst = new List<int>();
        Console.WriteLine($"Geef getallen op of druk op q om de informatie te tonen");
        do
        {
            if (!int.TryParse(Console.ReadLine(), out getal))
            {
                 break;
            }
            else
            {
                getallenLijst.Add(getal);
            }
        }
        while (input?.ToLower() != "q");

        // Code executed when q is pressed
        if(getallenLijst.Count == 0)
        {
            Console.WriteLine("Geen informatie, er werd niets ingegeven");
        }
        else
        {
            for (int i = 0; i < getallenLijst.Count; i++)
            {
                if (getallenLijst[i] >= 0)
                {
                    sumPos += getallenLijst[i];
                }
                else
                {
                    sumNeg += getallenLijst[i];
                }

                total += getallenLijst[i];
  
            }
            Console.WriteLine("Info:");
            Console.WriteLine($"Totaal: {total}");
            Console.WriteLine($"Totaal positieve getallen: {sumPos}");
            Console.WriteLine($"Totaal negatieve getallen: {sumNeg}");
            // Console.WriteLine($"Gemiddelde van de getallen: {Queryable.Average(getallenLijst.AsQueryable())}");
            avg = getallenLijst.Average();
            Console.WriteLine($"Gemiddelde van de getallen: {avg}");
        }

        

    }
}
