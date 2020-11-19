using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEx7
{
    class Tree : Item
    {
        private double height;
        public Tree(String name, double price, double height) : base(name, price)
        {
            this.height = height;
        }

        public double getHeight() => this.height;
    }
}
