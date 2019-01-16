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

        [Fact]
        public void CanAppendValue()
        {
            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);
            list.print();
            list.Append(43);

            list.Current = list.Head;
            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
            }

            int expected = list.Current.Value;
            Assert.True(expected==43);

        }




        [Fact]
        public void CanAppendValuetoTheEnd()
        {
            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);
            list.print();
            list.Append(43);
            list.Append(66);

            list.Current = list.Head;
            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
            }

            int expected = list.Current.Value;
            Assert.True(expected == 66);

        }


        [Fact]
        public void CanAppendValueAgain()
        {
            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);
            list.print();
            list.Append(43);
            list.Append(3);
            list.Append(23);
            list.Current = list.Head;
            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
            }

            int expected = list.Current.Value;
            Assert.True(expected == 23);

        }



        [Fact]
        public void CanInsertBeforeValue()
        {
            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);
            list.print();
            list.InsertBefore(10,43);

            list.Current = list.Head;
            int expected=0;
            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
                if (list.Current.Value == 43)
                {
               expected=list.Current.Next.Value;
                }

            }
     
            Assert.True(expected == 10);

        }



        [Fact]
        public void CanInsertBefore()
        {
            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);
            list.print();
            list.InsertBefore(10, 43);
            list.InsertBefore(43, 24);

            list.Current = list.Head;
            int expected = 0;
            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
                if (list.Current.Value == 24)
                {
                    expected = list.Current.Next.Value;
                }

            }

            Assert.True(expected == 43);

        }




        [Fact]
        public void CanInsertBeforeAnotherVal()
        {
            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);
            list.print();
            list.InsertBefore(10, 43);
            list.InsertBefore(43, 2);

            list.Current = list.Head;
            int expected = 0;
            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
                if (list.Current.Value == 2)
                {
                    expected = list.Current.Next.Value;
                }

            }

            Assert.True(expected == 43);

        }



        [Fact]
        public void CanInsertAfterValue()
        {
            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);
            list.print();
            list.InsertAfter(10, 43);

            list.Current = list.Head;
            int expected = 0;
            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
                if (list.Current.Value == 10)
                {
                    expected = list.Current.Next.Value;
                }

            }


            Assert.True(expected == 43);

        }


        [Fact]
        public void CanInsertAfterAnotherValue()
        {
            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);
            list.print();
            list.InsertAfter(10, 43);
            list.InsertAfter(43, 433);

            list.Current = list.Head;
            int expected = 0;
            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
                if (list.Current.Value == 43)
                {
                    expected = list.Current.Next.Value;
                }

            }


            Assert.True(expected == 433);

        }


        [Fact]
        public void CanInsertAfterAnother()
        {
            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);
            list.print();
            list.InsertAfter(0, 43);
            list.print();

            list.Current = list.Head;
            int expected = 0;
            if (list.Current.Value == 0)
            {
                expected = list.Current.Next.Value;
            }
            else
            {
                while (list.Current.Next != null)
                {

                    if (list.Current.Value == 0)
                    {
                        expected = list.Current.Next.Value;
                    }
                    list.Current = list.Current.Next;
                }

            }
            Assert.True(expected == 43);

        }



        [Fact]

        public void CanGet0thValue()
        {

            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);

            Assert.Equal(0, list.GetValue(0));



        }

        [Fact]

        public void CanGet2thValue()
        {

            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);

            Assert.Equal(38, list.GetValue(2));



        }




        [Fact]

        public void CanNotGet9thValue()
        {

            LList list = new LList();
            list.Insert(0);
            list.Insert(10);
            list.Insert(38);

            Assert.Equal(-1, list.GetValue(9));



        }



    }
}
