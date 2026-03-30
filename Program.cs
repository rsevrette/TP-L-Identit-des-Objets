using System.Runtime.Serialization.Formatters;

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

        //EXERCICE 3
        Console.WriteLine("\n____________________EXO 3____________________");
        HashSet<Produit> panier = new HashSet<Produit>();
        panier.Add(p2);
        panier.Add(p3);
        Console.WriteLine(panier.Count);

        //EXERCICE 4
        Console.WriteLine("\n____________________EXO 4____________________");
        Produit article = new ProduitPerissable("B05", "Lait", 15.0, 5);
        Console.WriteLine( article.GetType());

        //EXERCICE 5
        Console.WriteLine("\n____________________EXO 5____________________");
        List<object> inventaire = new List<object>();
        Produit p4 = new Produit("A01", "Souris", 15.0);

        inventaire.Add(5);                
        inventaire.Add("Dépôt central");  
        inventaire.Add(p4);              

        foreach (object item in inventaire)
        {
            Console.WriteLine("Type : " + item.GetType());
            Console.WriteLine("ToString : " + item.ToString());
            if (item is Produit p)
            {
                Console.WriteLine("Code article : " + p.GetCodeArticle());
            }
            Console.WriteLine("-------------------");
        }
    }
}
