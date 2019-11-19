using System;
using System.Collections.Generic;
using System.Text;

namespace _6laba
{
    class Gym 
    {
        private static Item[] itemArr;
        private int maxIndex;
        public int size = 0;
        public Item this[int index]
        {
            get
            {
               

                if (index > maxIndex)
                {
                    Console.WriteLine("Превышен максимальный индекс предметов");
                    return null;
                }
                return itemArr[index];
            }
            set
            {
                size++;
                if (index > maxIndex)
                    Console.WriteLine("Елемент  с таким индексом не существует");
                else
                    itemArr[index] = value;

            }
        }
        public Gym(int maxIndex)
        {
            this.maxIndex = maxIndex - 1;
            itemArr = new Item[maxIndex];
        }
        public static void show()
        {
            foreach (Item it in itemArr)
                it.GetVehicleInf();
        }
    }
}
