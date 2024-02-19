Console.WriteLine($"Unesite broj učenika:");
int brojUcenika=Convert.ToInt32(Console.ReadLine()); //unos broja učenika


for (int i=0;i<brojUcenika;i++) 
{
    Console.WriteLine($"Unesite ocjenu za učenika {i + 1}:");
    int ocjena = Convert.ToInt32(Console.ReadLine()); //unos ocjene iz ispita
                                                 
    if(ocjena>1 && ocjena<=5)
    {
        Console.WriteLine($"Ucenik {i+1} prošao je ispit! Ocjena je {ocjena}");
    }
    else if(ocjena==1)
    {
        Console.WriteLine($"Učenik {i+1} pao je ispit. Ocjena je {ocjena}");
    }
    else
    {
        Console.WriteLine($"Neispravno unesena ocjena");
    }
}
