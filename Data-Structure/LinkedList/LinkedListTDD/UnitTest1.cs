using System;
using Xunit;
using LinkedList;
using LinkedList.Classes;
namespace LinkedListTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanDetectExsitingValue()
        {
            LList list = new LList();
            list.Insert(34);
     
            Assert.True(list.Includes(34));

        }



        [Fact]
        public void CanDetectNotExsitingValue()
        {
            LList list = new LList();
            list.Insert(34);

            Assert.False(list.Includes(4));

        }
        [Fact]
        public void CanDetectIfValueExsits()
        {
            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);
            Assert.True(list.Includes(10));

        }
    }
}
