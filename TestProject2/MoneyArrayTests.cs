using System;
using practice9;
using Xunit;

namespace TestProject2
{
    public class MoneyArrayTests
    {
        static Money m1 = new Money(1, 11);
        static Money m2 = new Money(100, 5);
        MoneyArray M1 = new MoneyArray(5);

        private static Money[] MArr1 = new Money[] {m1};
        MoneyArray M2 = new MoneyArray(MArr1);
        
        private static Money[] MArr2 = new Money[] {m2, m1};
        MoneyArray M3 = new MoneyArray(MArr2);

        //private MoneyArray M4 = new MoneyArray();
        
        
        [Fact]
        public void MoneyArrayTestsShow()
        {
            Assert.Equal("[1 руб. 11 коп.]", M2.Show());
        }
        
        [Fact]
        public void MoneyArrayTestSize()
        {
            Assert.Equal(5, M1.Size);
        }
        
        [Fact]
        public void MoneyArrayTestGetMinFirst()
        {
            Assert.Equal(0, M2.GetMin());
        }
        
        [Fact]
        public void MoneyArrayTestGetMinAnother()
        {
            Assert.Equal(1, M3.GetMin());
        }
        
        [Fact]
        public void MoneyArrayIndexSet()
        {
            M2[0] = m2;
            Assert.True(M2[0] == m2);
        }
        
        [Fact]
        public void MoneyArrayIndexExcept()
        {
            Assert.Throws<IndexOutOfRangeException>(() => M2[1000]);
            //(IndexOutOfRangeException() );
        }
    }
}