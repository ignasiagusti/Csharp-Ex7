using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEx7
{
    class Decor:Item
    {
        private String material;
        public Decor(String name, double price, String material):base(name, price){
            this.material = material;
        }

        public String getMaterial() => this.material;
    }
}
