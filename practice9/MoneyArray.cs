using System;
namespace practice9
{
    public class MoneyArray
    {
        private static Random random = new Random();
        private Money[] array = null;
        public static int count = 0;

        #region Свойства

        public int Size
        {
            get
            {
                return array.Length;
            }
        }

        #endregion

        #region Индексатор

        public Money this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
            }
        }

        #endregion

        #region Конструктор

        public MoneyArray()
        {
            count++;
            array = new Money[0];// xz
        }

        public MoneyArray(int size)
        {
            count++;
            array = new Money[size];
            for (int i = 0; i < size; i++)
                array[i] = new Money(random.Next(1, 100), random.Next(0, 100));
        }
        
        public MoneyArray(int size, bool flag)
        {
            count++;
            array = new Money[size];
            int rubs, kops;
            for (int i = 0; i < size; i++)
            {
                rubs = InputData.InputValidIntNumber(0, 1000000, $"\nВведите количество Рублей {i + 1} денежной суммы:");
                kops = InputData.InputValidIntNumber(0, 100, $"\nВведите количество Копеек {i + 1} денежной суммы:");
                array[i] = new Money(rubs, kops);
            }
        }
        
        public MoneyArray(params Money[] arr)
        {
            count++;
            array = arr;
        }
        
        #endregion

        #region Методы

        public string Show()
        {
            //    "[Х руб. У коп.; I руб. J коп.]"
            string[] moneys = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
                moneys[i] = array[i].Show();//сбор сумм в массив для конкатенации
            return $"[{String.Join("; ", moneys)}]";
        }
        
        public int GetMin()
        {
            int minMoney = this[0].ToKopeks();// X руб. У коп. ->  XY0  
            int tempMoney, index = 0;
            for (int i = 1; i < this.Size; i++)
            {
                tempMoney = this[i].ToKopeks();
                if (tempMoney < minMoney)
                {
                    index = i;//запомнинаем индекс мин элемента
                    minMoney = tempMoney;//мин сумма
                }
            }
            return index;
        }
        #endregion
    }
}