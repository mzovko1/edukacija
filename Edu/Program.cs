//using System.Collections;
//int br = 0;
//int[] fr=new int[10]
//{
//    0,0,0,0,0,0,0,0,0,0
//};
//int[] brojevi = new int[10]
//{
//    1,2,4,3,42,1,4,5,2,1
//};

//for (int i = 0; i < brojevi.Length; i++)
//    Console.Write(brojevi[i] + ", ");
//for (int i = 0; i < brojevi.Length; i++)
//{

//    for (int j = i; j < brojevi.Length; j++)
//    {
//        if (brojevi[i] == brojevi[j])
//        { 
//            br++;
//            fr[j] = -1;
//        }
//        if (fr[i]!=0)
//        {
//            fr[i]= br;
//        }

//    }

//}
//for (int i = 0;i < brojevi.Length;i++)
//{
//    if (fr[i]!=0)
//    {
//       Console.WriteLine($"Broj {brojevi[i]}, ponavljanje {fr[i]}");
//    }

//}


//using System.ComponentModel.DataAnnotations;
//Console.WriteLine($"Unesi velicinu polja");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] a = new int[n];

//for(int i=0; i<n; i++)
//{
//    Console.WriteLine($"Unesi {i + 1}. broj");
//    a[i]=Convert.ToInt32(Console.ReadLine());

//}
//int min = a[0];
//int max = a[0];

//for (int i = 0;i<n;i++)
//{
//    if (a[i] > max)
//    {
//        max = a[i];
//    }
//    if (a[i] < min)
//    { 
//        min = a[i];
//    }
//}

//Console.WriteLine($"max:{max}, min:{min}");


//Console.WriteLine($"Unesi broj");
//int broj = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Unesi duljinu");
//int n = Convert.ToInt32(Console.ReadLine());
//int Count = n;


//for (int i = 0;i<n;i++)
//{
//    for (int j = 0; j<Count;j++)
//    {
//        Console.Write(broj);
//    }
//    Count--;
//    Console.WriteLine();
//}

Console.WriteLine($"unesi broj");
int broj = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < broj; i++)
{
    for (int j = 1; j < broj-i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0;k<2*i-1;k++)
    {
        Console.Write($"*");
    }
    Console.WriteLine();
}


for (int i = 0; i < broj-1; i++)
{   
    for (int k = 1; k < broj - i; k++)
    {
        Console.Write($"*");
    }
    for (int j = 0; j < i+1/2; j++)
    {
        Console.Write(" ");
    }
    
    Console.WriteLine();
}
