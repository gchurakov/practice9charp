using practice9;
using Xunit;

namespace TestProject2
{
    public class MoneyTests
    {
        [Fact]
        public void TestMoneyIsBiggerMethod()
        {
            Money m1 = new Money(100, 103);
            Money m2 = new Money();
            m2.Kopeks = 99;
            m2.Rubles = 0;

            bool isBigger = m1.IsBigger(m2);

            Assert.True(isBigger);
        }
        
        [Fact]
        public void TestMoneyIsBiggerFunc()
        {
            Money m1 = new Money(100, 3);
            Money m2 = new Money(0, 99);

            bool isBigger = Money.IsBigger(m1, m2);

            Assert.True(isBigger);
        }
        
        [Fact]
        public void TestMoneyToKopeks()
        {
            Money m1 = new Money(100, 3);
            
            int m1ToKops = m1.ToKopeks();

            Assert.True(m1ToKops == m1.Rubles*100 + m1.Kopeks);
        }
        
        [Fact]
        public void TestMoneyPlusPlus()
        {
            Money m1 = new Money(100, 3);
            Money m2 = new Money(100, 4);
            m1++;

            Assert.True(m1==m2);
        }
        
        [Fact]
        public void TestMoneyMinusMinus()
        {
            Money m1 = new Money(100, 4);
            Money m2 = new Money(100, 3);
            m1--;

            Assert.True(m1 == m2);
        }
        
        [Fact]
        public void TestMoneyNoRubs()
        {
            Money m1 = new Money(-1, 4);

            Assert.True(m1 == new Money(0,4));
        }
        
        [Fact]
        public void TestMoneyNoKops()
        {
            Money m1 = new Money(0, -4);

            Assert.True(m1 == new Money(0,0));
        }
        
        
        [Fact]
        public void TestMoneyMinus()
        {
            Money m1 = new Money(100, 6);
            Money m2 = m1 - 2;

            Assert.True(m2==new Money(100, 4));
        }
        
        [Fact]
        public void TestMinusMoney()
        {
            Money m1 = new Money(1, 6);
            Money m2 = 12 - m1;

            Assert.True(m2==new Money(0, 94));
        }
        
        [Fact]
        public void TestMoneyPlus()
        {
            Money m1 = new Money(100, 4);
            Money m2 = m1 + 2;

            Assert.True(m2==new Money(100,6));
        }
        
        [Fact]
        public void TestPlusMoney()
        {
            Money m1 = new Money(100, 4);
            Money m2 = 2 + m1;

            Assert.True(m2==new Money(100,6));
        }
        
        [Fact]
        public void TestMoneyUnEqual()
        {
            Money m1 = new Money(1, 4);

            Assert.True(m1 != new Money(0,4));
        }
        
        [Fact]
        public void TestMoneyInt()
        {
            Money m1 = new Money(100, 4);

            Assert.True((int)m1== 100);
        }
        
        [Fact]
        public void TestMoneyDouble()
        {
            Money m1 = new Money(100, 4);

            Assert.True((double)m1 == 0.04);
        }
        
        [Fact]
        public void TestMoneyShow()
        {
            Money m1 = new Money(100, 4);

            Assert.True(m1.Show()== "100 руб. 4 коп.");
        }
        
        
    }
}