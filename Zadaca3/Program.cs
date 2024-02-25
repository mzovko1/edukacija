//Zadatak 1

//try
//{
//    Console.Write("Unesi broj redaka: ");
//    int n = Convert.ToInt32(Console.ReadLine());
//    if (n > 0 && n <= 9)
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            for (int j = 1; j <= n - i; j++)
//            {
//                Console.Write(" ");
//            }
//            for (int k = 1; k <= i; k++)
//            {
//                Console.Write(k);
//            }
//            for (int l = i - 1; l >= 1; l--)
//            {
//                Console.Write(l);
//            }
//            Console.Write("\n");
//        }
//    }
//    else Console.Write("Broj treba biti manji od 9");
//    }
//catch (FormatException)
//{
//    Console.WriteLine("Neispravan unos");
//}

//Zadatak 2

try
{
    Console.Write("unesite broj: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    {
        Console.WriteLine("Fibonaccijev niz:");

        int a = 0, b = 1, c;
        int sumaneparnih = 0;
        int sumaparnih = 0;
        int index = 1;

        while (a <= n)
        {
            Console.Write(a + " ");

            if (index % 2 == 0)
                sumaparnih += a;
            else
                sumaneparnih += a;

            c = a + b;
            a = b;
            b = c;
            index++;
        }

        Console.WriteLine("\nzbroj brojeva s neparnim indexom: " + sumaneparnih);
        Console.WriteLine("zbroj brojeva s parnim indexom: " + sumaparnih);
    }
    else
    {
        Console.WriteLine("broj mora biti veći od 0");
    }

}
catch (FormatException)
{
    Console.WriteLine("neispravan unos");
}

//Zadatak 3

//try
//{
//    Console.Write("Unesite prvi broj: ");
//    var br1 = Convert.ToDouble(Console.ReadLine());
//    Console.Write("Unesite drugi broj: ");
//    var br2 = Convert.ToDouble(Console.ReadLine());
//    Console.Write("Unesite aritmetički znak (+, -, *, /, % ili 'Sve'): ");
//    string op = Console.ReadLine();

//    if (op == "Sve" || op=="sve" || op=="SVE" )
//    {
//        Console.WriteLine($"Rješenje zbrajanja: {br1 + br2}");
//        Console.WriteLine($"Prvo rješenje oduzimanja: broj 1-broj 2: {br1 - br2}");
//        Console.WriteLine($"Drugo rješenje oduzimanja: broj 2- broj 1: {br2 - br1}");
//        Console.WriteLine($"Rješenje množenja: {br1 * br2}");
//        if (br2 > 0)
//            Console.WriteLine($"Rješenje dijeljenja: {br1 / br2}");
//        else
//            Console.WriteLine($"Nije moguće dijeliti s 0.");
//        Console.WriteLine($"Rješenje modula: {br1 % br2}");
//    }
//    if (op =="+")
//    { 
//        Console.WriteLine($"Rješenje zbrajanja: {br1 + br2}");
//    }
//    if (op == "-")
//    {
//        Console.WriteLine($"Prvo rješenje oduzimanja: broj 1-broj 2: {br1 - br2}");
//        Console.WriteLine($"Drugo rješenje oduzimanja: broj 2- broj 1: {br2 - br1}");
//    }
//    if (op == "*")
//    {
//        Console.WriteLine($"Rješenje množenja: {br1 * br2}");
//    }
//    if (op == "/")
//    {
//        if (br2 > 0)
//            Console.WriteLine($"Rješenje dijeljenja: {br1 / br2}");
//        else 
//            Console.WriteLine($"Nije moguće dijeliti s 0.");
//    }
//    if (op == "%")
//    {
//        Console.WriteLine($"Rješenje modula: {br1 % br2}");
//    }
//}
//catch(FormatException)
//{
//    Console.WriteLine("Neispravan unos");
//}

//Zadatak 4

//Random rand = new Random();
//int trazeniBroj = rand.Next(1, 101);

//int pogodenBroj;
//bool pogodak = false;

//Console.WriteLine("Pogodite broj između 1 i 100:");

//try
//{
//    while (!pogodak)
//    {
//        Console.Write("Unesite broj: ");
//        pogodenBroj = Convert.ToInt32(Console.ReadLine());

//        if (pogodenBroj < trazeniBroj)
//        {
//            Console.WriteLine("Prenisko, pokušaj ponovo.");
//        }
//        else if (pogodenBroj > trazeniBroj)
//        {
//            Console.WriteLine("Previsoko, pokušaj ponovo.");
//        }
//        else
//        {
//            pogodak = true;
//            Console.WriteLine("Bravo, broj je pogođen!");
//        }
//    }
//}
//catch (FormatException)
//{
//    Console.WriteLine("Neispravan unos");
//}

// Zadatak 5

//Console.Write("Unesite riječ: ");
//string rijec = Console.ReadLine();

//Console.WriteLine("Riječ pročitana unatrag:");
//for (int i = rijec.Length - 1; i >= 0; i--)
//{
//    Console.Write(rijec[i]);
//}

//6. zadatak

//Console.Write("Unesite rečenicu: ");
//string recenica = Console.ReadLine();

//string[] rijeci = recenica.Split(' ');

//List<int> duljineRijeci = new List<int>();

//foreach (string rijec in rijeci)
//{
//    duljineRijeci.Add(rijec.Length);
//}

//int najkracaDuljina = duljineRijeci.Min();
//int najduzaDuljina = duljineRijeci.Max();

//int indeksNajkrace = duljineRijeci.IndexOf(najkracaDuljina);
//int indeksNajduze = duljineRijeci.IndexOf(najduzaDuljina);

//Console.WriteLine("Najkraća riječ: " + rijeci[indeksNajkrace]);
//Console.WriteLine("Najduža riječ: " + rijeci[indeksNajduze]);

//7.zadatak
//Console.Write("Unesite riječ: ");
//string rijec = Console.ReadLine();
//int samoglasnici = 0;

//for(int i = 0; i < rijec.Length; i++)
//{
//    char slovo = rijec[i];
//    if(slovo =='a' || slovo=='A' || slovo=='e' || slovo=='E' || slovo=='i' || slovo=='I' || slovo=='o' || slovo=='O' || slovo=='u' || slovo=='U' )
//    {
//        samoglasnici++;
//    }
//}
//Console.WriteLine($"Broj samoglasnika je: {samoglasnici}");

