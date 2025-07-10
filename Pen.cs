using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pen
    {
        string name;
        string color;
        int price;

        //Constructor
        public Pen()
        {
            name = "Doms";
            color = "Blue";
            price = 15;
        }

        //Constructor with Parameters
        public Pen(string name,string color,int price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }
    }
}
