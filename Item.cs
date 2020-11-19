using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEx7
{
    class Item  //Classe item que es la classe pare dels diferents objectes de la botiga. Heredaran els seus mètodes i caract.
    {
        private String name;
        private double price;

        public Item (String name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public String getName(){ return this.name; }

        public void setName(String name){ this.name = name; }

        public double getPrice(){ return this.price; }

        public void setPrice(double price){ this.price = price; }
    }
}
