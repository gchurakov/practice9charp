using System;
namespace practice9
{
    public class InputData
    {
        public static string[] errorMessages = {"Число введено НЕ верно!", "Число НЕ входит в диапазон!" };

        public static bool ValidateData(int number, int min, int max)
        {
            return min <= number && number < max;
        }

        public static int InputIntNumber(string message, string errorMessage)
        {
            bool isRead = false;
            int num;
            do
            {
                Console.WriteLine("\n" + message);
                isRead = int.TryParse(Console.ReadLine(), out num);
                if (!isRead) Console.WriteLine(errorMessage);
            } while (!isRead);
            return num;
        }
        
        public static int InputValidIntNumber(int min, int max, string message)
        {
            bool isRead = false, isValid = false;
            int num;
            do
            {
                
                Console.WriteLine("\n" + message);
                isRead = int.TryParse(Console.ReadLine(), out num);
                if (!isRead) Console.WriteLine(errorMessages[0]);
                else
                {
                    isValid = ValidateData(num, min, max);
                    if (!isValid) Console.WriteLine(errorMessages[1]);
                }
                
            } while (!isRead);
            return num;
        }
    }
}