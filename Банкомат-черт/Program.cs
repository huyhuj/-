using System.Diagnostics.CodeAnalysis;
using System.Security.Authentication;

class Programm
{
    
    
        static void Main()
        {
            int[] denomations = { 5000, 2000, 1000, 500, 100, 50 };
            int[] atm = new int[denomations.Length];
            Random rand = new Random();
            int pinCode = 69;
            Console.WriteLine("Гони порль");
            int enteredPin = int.Parse(Console.ReadLine());
            if (enteredPin != pinCode ) 
            {
                Console.WriteLine("Неправлиьный пороль, пиши снова, черт");
                return;
            }
            int score = 0;
            for (int i = 0; i < atm.Length; i++)
            {
                atm[i] = rand.Next(1, 20);
                Console.WriteLine((denomations[i].ToString()) + "    " + atm[i]);
                score = denomations[i] * atm[i] + score;
            }
            int schet = rand.Next(1, 1000000);
            Console.WriteLine("У тебя денеш нету {0}", schet);
            Console.WriteLine("Максимум, что я тебе дам: {0}", score);
            Console.WriteLine("Сколько хошь? Напиши: ");
            int withdrawalAmount = int.Parse(Console.ReadLine());
            if (withdrawalAmount > score) 
            {
                Console.WriteLine("Жирно не будит? У меня купюр стака нет, иди еще куда-нибудь");
                Environment.Exit(0);
            }
            if (withdrawalAmount % 50 !=0) 
            {
                Console.WriteLine("Надо, чтобы было кратно 50, иди в баню, пиши правильно");
                return;
            }
            int totalNotes = 0;
            for (int i = 0; i < denomations.Length; i++) 
            {
                int notesCount = withdrawalAmount / denomations[i];

                if (notesCount > atm[i])
                {
                    notesCount = atm[i];
                }
                withdrawalAmount -= notesCount * denomations[i];
                atm[i] -= notesCount;
                totalNotes += notesCount;
                Console.WriteLine($"Выдано {notesCount} купюр достоинством {denomations[i]}");

            }
            Console.WriteLine($"Всего выдано {totalNotes} купюр");
        }
    
}