namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Всего актав 4 , чтобы поменять актаву нажмите F2 или нажмите Escape , чтобы закончить сессию");
            ConsoleKeyInfo start = Console.ReadKey();
            while (start.Key != ConsoleKey.Escape)
            {
                if (start.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("F5");
                    while (start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start, 0);
                    }
                }else if(start.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("F2");
                    while (start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start, 2);
                    }
                }
                else if (start.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("F3");
                    while (start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start, 3);
                    }
                }
                else if( start.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("F4");
                    while (start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start,1);
                    }
                }
                else
                {
                    Console.WriteLine(" Такой актавы нету");
                    start = Console.ReadKey();
                }
            }
        }

        static int sound(int i, int j) // функция массива частоты
        {
            int[,] arr = new int[4, 12] { { 523, 587, 659, 698, 784, 880, 987, 554, 622, 740, 830, 932,}, { 261, 293, 329, 349, 392, 440, 494, 277, 311, 370, 415, 366, }, { 65, 73, 82, 87, 98, 110, 123, 69, 78, 93, 103, 116 }, { 130, 146, 164, 174, 196, 220, 246, 138, 155, 185, 207, 233 } };
            return arr[i,j];
        }
        static ConsoleKeyInfo key (ConsoleKeyInfo start,int i) // функция клавиш
        {
            start = Console.ReadKey();
            if (start.Key == ConsoleKey.Q) //до
            {
                int j = 0;
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.W) // ре
            {
                int j = 1;
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.E) // ми
            {
                int j = 2;
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.R) // фа
            {
                int j = 3;
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.T) // соль
            {
                int j = 4; 
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.Y) // ля
            {
                int j = 5; 
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.U) // си
            {
                int j = 6;
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.D2)
            {
                int j = 7;
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.D3)
            {
                int j = 8;
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.D5)
            {
                int j = 9;
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.D6)
            {
                int j = 10;
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.D7)
            {
                int j = 11;
                int N = sound(i, j);
                sound2(N);
            }
            else if (start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Такой клавиши нету");
            }
            return start;
        }
        public static void sound2(int  N)
        {
            Console.Clear();
            Console.Beep(N, 200);
        }
    }
}