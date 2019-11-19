using System;

namespace _6laba
{
   
    struct SomeStruct
    {
        public string name;
        public int age;
        public void DisplayNameandAge()
        {
            Console.WriteLine($"Name: {name}, age: {age}");
        }
        public SomeStruct(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    enum pr
    {
        ONE=1, TWO,THREE
    }

    class Program
    {

      
        
        static void Main(string[] args)
        {
            SomeStruct someStruct=new SomeStruct ("sd",322);
           
            Gym gym = new Gym(4);
            gym[0] = new Mate("one", 2000, 25, 15, 224);
            gym[1] = new Mate("two", 4000, 13, 2, 2424);
            gym[2] = new Mate("free",3000 , 40, 20, 3);
            gym[3] = new Mate("four", 1000, 100, 92, 1);
            gym[0].GetVehicleInf();
            gym[1].GetVehicleInf();
            gym[2].GetVehicleInf();
            gym[3].GetVehicleInf();
            Console.WriteLine(gym.size);
            Console.WriteLine("_________________ Введите даипазон цены");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int n = 0;
            for (int i = 0; i < gym.size; i++)
            {
                if (gym[i].cost >= a && gym[i].cost <= b)
                {
                    gym[i].GetVehicleInf();
                    n++;
                }
            }
            if (n == 0)
                Console.WriteLine("Товаров, входящих в заданный диапазон цен не найдено ! ");
            Console.WriteLine("_________________ Сортировка по Длине");
            Gym2 gym2 = new Gym2(gym.size);
            for (int i = 0; i < gym.size; i++)
            {
                gym2[i] = new Mate();
            }
            
            for (int i = 0; i < gym.size; i++)
            {
                for (int j = 0; j < gym.size - 1 - i; j++)
                {
                    
                    if (gym[j].length > gym[j + 1].length)
                    {
                       
                        gym2[j] = gym[j];
                        gym[j] = gym[j + 1];
                        gym[j + 1] = gym2[j];
                        gym.size -=2 ;
                       
                    }
                }
            }
           
            gym[0].GetVehicleInf();
            gym[1].GetVehicleInf();
            gym[2].GetVehicleInf();
            gym[3].GetVehicleInf();


            Console.ReadLine();
        }
    }
}
