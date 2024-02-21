//Obicna lista
using System.Collections;

List<int> brojevi = new List<int>(); //stvaranje

brojevi.Add(5); //dodavanje brojeva u listu
brojevi.Add(10);
brojevi.Add(15);
brojevi.Remove(10);
brojevi.Clear();


foreach (int br in brojevi) //ispis cijele liste
{
    Console.WriteLine(br); 
}

brojevi.Clear(); //brisanje svih elemenata liste

//SortedList

SortedList<string, int> godine = new SortedList<string, int>();

godine.Add("Ana", 20); //Dodavanje elemenata ime i godine u listu
godine.Add("Ivan", 30);
godine.Add("Matea", 23);


Console.WriteLine(godine["Matea"]); // Ispisuje koliko Matea ima godina



foreach (KeyValuePair<string, int> kvp in godine)
{
    Console.WriteLine($"{kvp.Key} {kvp.Value}"); //Ispisuje listu 
}

// ArrayList
ArrayList studentsArray = new ArrayList();

studentsArray.Add("Ana Anic"); //Dodavanje elemenata u listu
studentsArray.Add("Ivan Ivic");
studentsArray.Add("Matea Zovko");

Console.WriteLine("Count: " + studentsArray.Count); //Broj elemenata u listi

//Nasljedivanje- izvedene klase imaju iste atribute kao base klasa
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}
Dog dog = new Dog();
dog.Eat();
dog.Bark();
    
//Polimorfizam- istoimena metoda ima različite outpute
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}
class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

Shape shape1 = new Circle();
Shape shape2 = new Rectangle();

       
shape1.Draw(); // Output: Drawing a circle.
shape2.Draw(); // Output: Drawing a rectangle.

//Enkapsulacija- privatni članovi nedostupni izvan klase
class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value;}
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

//Apstakcija- u apstaktnoj klasi se ne implementira (apstraktna) metoda nego u izvedenoj klasi
abstract class Shape1
{
    public abstract double Area();
}

class Rectangle1 : Shape1
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle1(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double Area()
    {
        return Width * Height;
    }
}


