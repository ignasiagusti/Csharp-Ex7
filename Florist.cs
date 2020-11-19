using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpEx7
{
    class Florist
    {
        private String name;
        private List<Item> listItems;

        public Florist()
        {
            this.name = "";
            this.listItems = new List<Item>();
        }

        public Florist(String name)
        {
            this.name = name;
            this.listItems = new List<Item>();
        }

        public String GetName()
        {
            return this.name;
        }

        public void ChangeName(String name)
        {
            this.name = name;
        }

        public (List <Tree>, List <Flower>, List <Decor>) GetStock()
        {
            List<Tree> listTrees = new List<Tree>();
            List<Flower> listFlowers = new List<Flower>();
            List<Decor> listDecors = new List<Decor>();
            foreach (var item in listItems)
            {

                if (item.GetType().Equals(listTrees.GetType().GetGenericArguments().Single()))
                {
                    listTrees.Add((Tree) item);
                }
                if (item.GetType().Equals(listFlowers.GetType().GetGenericArguments().Single()))
                {
                    listFlowers.Add((Flower)item);
                }
                if (item.GetType().Equals(listDecors.GetType().GetGenericArguments().Single()))
                {
                    listDecors.Add((Decor)item);
                }
            }
            return (listTrees, listFlowers, listDecors);
        }

        public void AddItem(Item item)
        {
            listItems.Add(item);
            Console.WriteLine("S'ha afegit l'item {0} amb preu {1}", item.getName(), item.getPrice());
        }
        
    }
}
