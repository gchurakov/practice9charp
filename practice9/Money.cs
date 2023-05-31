using System;

namespace practice9
{
    public class Money
    {
        private int rubles, kopeks;
        public static int count = 0;

        #region Свойства
        public int Rubles
        {
            get
            {
                return rubles;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error!");
                    rubles =  0;
                }
                else rubles = value;
            }
        }

        public int Kopeks
        {
            get
            {
                return kopeks;
            }
            set
            {
                if (value < 0)
                {
                    if (rubles < 1)
                    {
                        Console.WriteLine("Error!");
                        kopeks = 0;
                    }
                    else
                    {
                        rubles -= 1;
                        kopeks = value + 100;
                    }
                }
                else if (value >= 100)
                {   
                    rubles += value / 100;
                    kopeks = value % 100;
                }
                else kopeks = value;
            }
        }
        #endregion

        #region Конструкторы

        public Money()
        {
            Rubles = 0;
            Kopeks = 0;
            count++;
        }

        public Money(int rubles, int kopeks)
        {
            Rubles = rubles;
            Kopeks = kopeks;
            count++;
        }
        #endregion
        
        #region Операторы
        //унарные операторы
        public static Money operator++(Money m)
        {
            m.Kopeks += 1;
            return m;
        }
        
        public static Money operator--(Money m)
        {
            m.Kopeks -= 1;
            return m;
        }
        //бинарные опрераторы
        public static Money operator-(Money m, int num)
        {
            Money temp = m;
            temp.Kopeks -= num;
            return temp;
        }
        
        public static Money operator-(int num, Money m)
        {
            Money temp = m;
            temp.Kopeks -= num;
            return temp;
        }
        
        public static Money operator+(Money m, int num)
        {
            Money temp = m;
            temp.Kopeks += num;
            return temp;
        }
        
        public static Money operator+(int num, Money m)
        {
            Money temp = m;
            temp.Kopeks += num;
            return temp;
        }
        
        public static bool operator==(Money m1, Money m2)
        {
            return (m1.Kopeks == m2.Kopeks && m1.Rubles == m2.Rubles);
        }
        
        public static bool operator!=(Money m1, Money m2)
        {
            return (m1.Kopeks != m2.Kopeks || m1.Rubles != m2.Rubles);
        }
        //приведение типов
        public static implicit operator int(Money m)//рубли
        {
            return m.Rubles;
        }
        
        public static explicit operator double(Money m)//копейки
        {
            return (double)m.Kopeks/100;
        }
        #endregion
        
        #region Методы
        public string Show()
        {
            return ($"{rubles} руб. {kopeks} коп.");
        }
        //bool сравнение обьектов
        public static bool IsBigger(Money m1, Money m2)
        {
            return (m1.ToKopeks() > m2.ToKopeks());
        }

        public  bool IsBigger(Money m2)
        {
            return this.ToKopeks() > m2.ToKopeks();
        }

        #endregion
        //сумма –> копейки
        public int ToKopeks()
        {
            return Rubles * 100 + Kopeks;
        }

        
    }
}