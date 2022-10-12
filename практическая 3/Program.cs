namespace практическая_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Клавиши пианино й-ъ. Переключение Октав F1-F3");
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                if (key.Key == ConsoleKey.F1)
                {
                    Hz1();
                }
                else if (key.Key == ConsoleKey.F2)
                {
                    Hz2();
                }
                else if (key.Key == ConsoleKey.F3)
                {
                    Hz3();
                }
            }
        }
        static void Hz1()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            int[] Hz1 = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            if (key.Key == ConsoleKey.Q)
            {
                Console.Beep(Hz1[0], 10000);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.W)
            {
                Console.Beep(Hz1[1], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.E)
            {
                Console.Beep(Hz1[2], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.R)
            {
                Console.Beep(Hz1[3], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.T)
            {
                Console.Beep(Hz1[4], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.Y)
            {
                Console.Beep(Hz1[5], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.U)
            {
                Console.Beep(Hz1[6], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.I)
            {
                Console.Beep(Hz1[7], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.O)
            {
                Console.Beep(Hz1[8], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.P)
            {
                Console.Beep(Hz1[9], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.A)
            {
                Console.Beep(Hz1[10], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.S)
            {
                Console.Beep(Hz1[11], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.D)
            {
                Console.Beep(Hz1[12], 200);
                Console.Clear();
            }
        }
        static void Hz2()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            int[] Hz2 = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            if (key.Key == ConsoleKey.Q)
            {
                Console.Beep(Hz2[0], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.W)
            {
                Console.Beep(Hz2[1], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.E)
            {
                Console.Beep(Hz2[2], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.R)
            {
                Console.Beep(Hz2[3], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.T)
            {
                Console.Beep(Hz2[4], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.Y)
            {
                Console.Beep(Hz2[5], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.U)
            {
                Console.Beep(Hz2[6], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.I)
            {
                Console.Beep(Hz2[7], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.O)
            {
                Console.Beep(Hz2[8], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.P)
            {
                Console.Beep(Hz2[9], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.A)
            {
                Console.Beep(Hz2[10], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.S)
            {
                Console.Beep(Hz2[11], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.D)
            {
                Console.Beep(Hz2[12], 200);
                Console.Clear();
            }
        }
        static void Hz3()
        {

            int[] Hz3 = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Q)
            {
                Console.Beep(Hz3[0], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.W)
            {
                Console.Beep(Hz3[1], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.E)
            {
                Console.Beep(Hz3[2], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.R)
            {
                Console.Beep(Hz3[3], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.T)
            {
                Console.Beep(Hz3[4], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.Y)
            {
                Console.Beep(Hz3[5], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.U)
            {
                Console.Beep(Hz3[6], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.I)
            {
                Console.Beep(Hz3[7], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.O)
            {
                Console.Beep(Hz3[8], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.P)
            {
                Console.Beep(Hz3[9], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.A)
            {
                Console.Beep(Hz3[10], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.S)
            {
                Console.Beep(Hz3[11], 200);
                Console.Clear();
            }
            if (key.Key == ConsoleKey.D)
            {
                Console.Beep(Hz3[12], 200);
                Console.Clear();
            }
        }
    }
}