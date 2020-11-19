using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEx7
{
    class Flower:Item
    {
        private String colour;
        public Flower(String name, double price, String colour) : base(name, price)
        {
            this.colour = colour;
        }

        public String getColour() => this.colour;

    }
}
