using System;

namespace practice9
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            #region Часть1

            Console.WriteLine("\nСоздание обьектов класса Money:");
            //создание 1 обьекта
            Money m1 = new Money(100, 3);
            Console.WriteLine("m1 = " + m1.Show());

            //создание 2 обьекта
            Money m2 = new Money(0, 99);
            Console.WriteLine("m2 = " + m2.Show());

            //поиск большего из обьектов (метод)
            Console.WriteLine("\nРаботает метод класса...");
            if (m1.IsBigger(m2))
                Console.WriteLine($"Максимальная сумма = {m1.Show()}");
            else Console.WriteLine($"Максимальная сумма = {m2.Show()}");

            //поиск большего из обьектов (функция)
            Console.WriteLine("\nРаботает статическая функция...");
            if (Money.IsBigger(m1, m2))
                Console.WriteLine($"Максимальная сумма = {m1.Show()}");
            else Console.WriteLine($"Максимальная сумма = {m2.Show()}");

            #endregion

            #region Часть2

            Console.WriteLine("\nОператоры:\n m2  : " + m2.Show());
            Console.WriteLine(" m2++: " + m2++.Show());
            Console.WriteLine(" m2--: " + m2--.Show());
            Console.WriteLine($" m2+10 : {(m2 + 10).Show()}");
            Console.WriteLine($" m2-11 : {(m2 - 10).Show()}");

            Console.WriteLine($"\nПриведение типов:\n Money -> Int : {m1.Show()} –> {(int) m1}");
            Console.WriteLine($" Money -> Double : {m1.Show()} –> {(double) m1}");

            Console.WriteLine($"\nКоличество объектов класса Money : {Money.count}");

            #endregion

            #region Часть3

            Console.WriteLine("\nМассив денежных сумм:");
            MoneyArray M1 = new MoneyArray(5); 
            Console.WriteLine("\nM1 : " + M1.Show());
            MoneyArray M2 = new MoneyArray(m1);
            Console.WriteLine("\nM2 : " + M2.Show());
            Money[] Marr1 = new Money[]{m1, m2};
            MoneyArray M3 = new MoneyArray(Marr1);
            Console.WriteLine("\nM3 : " + M3.Show());

            Console.WriteLine($"Номер минимальной суммы в М1 : {M1.GetMin()+1}");

            Console.WriteLine($"\nКоличество объектов класса MoneyArray : {MoneyArray.count}");

            //Console.WriteLine(new MoneyArray().Show());

            #endregion
        }
    }
}