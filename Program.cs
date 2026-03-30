namespace TP1_14_classe_object;

class Program
{
    static void Main(string[] args)
    {
        //EXERCICE 1
        Console.WriteLine("\n____________________EXO 1____________________");
        Produit p1 = new Produit("0123", "azerty", 15);
        Console.WriteLine(p1.ToString());

        //EXERCICE 2
        Console.WriteLine("\n____________________EXO 2____________________");
        Produit p2 = new Produit("A01", "souris", 15.0);
        Produit p3 = new Produit("A01", "souris", 15.0);
        Console.WriteLine(p2.Equals(p3));
    }
}
