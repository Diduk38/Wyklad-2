namespace Wyklad3;

public class Program
{
    public static void Main(string[] args)
    {
        //PascalCase

        //Primitive
        int n = 10;
        double k = 5.0;
        bool b = true;
        char ch = 'Z';

        //Complex
        int[] arr;
        //Student -class
        string name = "John";

        int? w2 = null;

        if (name == "Doe") //porownuje 2 wartosci
        {
            Console.WriteLine("rowno");
        }
        else Console.WriteLine("nie");

        // + - / * ==  можно переопределять 
        Student s1 = new Student("Nazar", "Diduk");
        Student s2 = new Student("Nazar", "Diduk");
        if (s1 == s2)
        {
            //porownuje 2 adresy a nie wartosci
        }

        Teacher t1 = new Teacher();
        t1.FName = "John";
        Teacher t2 = new Teacher();

        string yourName = $"Your name {t1.FName}";

        //Kolejce

        //ArrayList
        List<int> list = new List<int>();
        
        //HashSet
        HashSet<string> names = new HashSet<string>();
        names.Add("Nazar");

        if (names.Contains("Nazar"))
        {
            //
        }
        
        //Mapy -->Dictionary

        Dictionary<string, double> oceny = new Dictionary<string, double>();
        oceny.Add("s27736",4.5);
        
        //SortedDictionary
        
        Console.WriteLine(yourName);
        Console.WriteLine("Hello, World!");
    }
}