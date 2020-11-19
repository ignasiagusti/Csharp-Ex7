using System;
using System.Collections.Generic;

namespace CsharpEx7
{
    class Program
    {
        static void Main(string[] args)
        {
            Florist florist = new Florist("Floristeria Anna");

            Console.WriteLine("Adquisicions inicials:");
            florist.AddItem(new Tree("Taronger", 13.95, 7));
            florist.AddItem(new Flower("Petúnia", 7.99, "Groga"));
            florist.AddItem(new Decor("Escultura", 4.57, "Fusta"));
            florist.AddItem(new Flower("Rosa", 2.33, "Vermella"));
            florist.AddItem(new Tree("Faig", 18.87, 10));

            Console.WriteLine("\nBenvinguts a la floristeria Anna. Indiqui què vol fer:");
            int option;
            do
            {
                Console.Write("\n1. Afegir un nou arbre\n2. Afegir una flor\n3. Afegir decoració\n4. Veure Stock\n5. Sortir\n>>>>");
                option = Int32.Parse(Console.ReadLine());
                String name;
                Double price;
                switch (option)
                {
                    case 1:
                        (name, price) = AskForItem();
                        Console.Write("Indiqui l'altura de l'arbre (en m):");
                        double height = Double.Parse(Console.ReadLine());
                        florist.AddItem(new Tree(name,price,height));
                        break;

                    case 2:
                        (name, price) = AskForItem();
                        Console.Write("Indiqui el color de la flor:");
                        String colour = Console.ReadLine();
                        florist.AddItem(new Flower(name, price, colour));
                        break;

                    case 3:
                        (name, price) = AskForItem();
                        Console.Write("Indiqui el material de la decoració (fusta o plastic):");
                        String material = Console.ReadLine();
                        while(material!="fusta" && material != "plastic")
                        {
                            Console.Write("\nNom incorrecte. El material només pot ser fusta o plastic:");
                            material = Console.ReadLine();
                        }
                        florist.AddItem(new Decor(name, price, material));
                        break;

                    case 4:
                        List<Tree> listTrees = new List<Tree>();
                        List<Flower> listFlowers = new List<Flower>();
                        List<Decor> listDecors = new List<Decor>();
                        (listTrees, listFlowers, listDecors) = florist.GetStock();

                        Console.WriteLine("\nStock de la floristeria:");
                        Console.WriteLine("\nARBRES:");
                        foreach (var tree in listTrees)
                        {
                            Console.Write("[{0}, {1}, {2}], ",tree.getName(),tree.getPrice(),tree.getHeight());
                        }
                        Console.WriteLine("\nFLORS:");
                        foreach (var f in listFlowers)
                        {
                            Console.Write("[{0}, {1}, {2}], ", f.getName(), f.getPrice(), f.getColour());
                        }
                        Console.WriteLine("\nDECORACIÓ:");
                        foreach (var d in listDecors)
                        {
                            Console.Write("[{0}, {1}, {2}], ", d.getName(), d.getPrice(), d.getMaterial());
                        }
                        Console.WriteLine("\n");
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Valor introduit incorrecte. Siusplau, introdueix un valor entre 1 i 5.");
                        break;
                }
            } while (option != 5);

            Console.WriteLine("\nA reveure!");
        }

        public static (String,double) AskForItem()
        {
            Console.Write("\nIndiqui el nom de l'item:");
            String name = Console.ReadLine();
            Console.Write("Indiqui el preu de l'item:");
            double price = Double.Parse(Console.ReadLine());

            return (name, price);
        }

        /* He inentat crear mètodes per no haver d'escriure codi al Main, però tenia més problemes, i és mes senzill gestionar-ho
         * des d'allà.
        public Florist searchFloristInList(String name)
        {
            foreach (Florist f in listFlorists)
            {
                if (f.GetName().Equals(name))
                {
                    Florist flor = f;
                    return flor;
                }
            }
            return null;
        }

        public static Florist CreateFlorist(String name)
        {
            return new Florist(name);
        }

        public void AddTree(String floristName, String name, double price, double height)
        {
            varFlorist = searchFloristInList(floristName);
            if (varFlorist == null) Console.WriteLine("No existeix una floristeria amb aquest nom");
            else varFlorist.AddItem(new Tree(name, price, height));
            varFlorist = null;
        }

        public void AddFlower(String floristName, String name, double price, String colour)
        {
            varFlorist = searchFloristInList(floristName);
            if (varFlorist == null) Console.WriteLine("No existeix una floristeria amb aquest nom");
            else varFlorist.AddItem(new Flower(name, price, colour));
            varFlorist = null;
        }

        public void AddDecor(String floristName, String name, double price, String material)
        {
            varFlorist = searchFloristInList(floristName);
            if (varFlorist == null) Console.WriteLine("No existeix una floristeria amb aquest nom");
            else varFlorist.AddItem(new Decor(name, price, material));
            varFlorist = null;
        }*/

    }



}
