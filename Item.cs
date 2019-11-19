using System;
using System.Collections.Generic;
using System.Text;

namespace _6laba
{
    abstract class Item 
    {

       public int cost { get; set; } //цена

        public int length { get; set; }  //длина

        public int width { get; set; }   //ширина

        public int area { get; set; }    //площадь

        public string name { get; set; } //name

    
        public Item()
        {
            name = "";
            cost = 0;
            length = 0;
            width = 0;
            area = 0;
        }

        public Item(string name, int cost, int _lenght, int width, int area)
        {
            
            this.name = name;
            this.cost = cost;
            length = _lenght;
            this.width = width;
            this.area = area;
        }
        public virtual void GetVehicleInf()
        {
            Console.WriteLine("Данные об объекте : ");

            Console.WriteLine($"Стоимость : {cost}");

            Console.WriteLine($"Длина : {length}");

            Console.WriteLine($"Ширина : {width}");

            Console.WriteLine($"Площадь : {area}");

            Console.WriteLine($"Имя :  {name}");
        }
    }
}
