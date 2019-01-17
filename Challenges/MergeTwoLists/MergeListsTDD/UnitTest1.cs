using System;
using Xunit;
using MergeTwoLists;
using LinkedList.Classes;

namespace MergeListsTDD
{
    public class UnitTest1
    {
        [Fact]
        public void MergeWhenListOneIslonger()
        {
            LList list1 = new LList();
            list1.Insert(2);
            list1.Insert(4);
            list1.Insert(6);
            // list1.print();
            LList list2 = new LList();
            list2.Insert(7);
            list2.Insert(79);

           Program.MergeTwoLists(list1, list2);
        //6->79->4->7->2->null so the second last positon will be 7 which is the last node in list2 when merge
            Assert.Equal(7, list1.GetValue(1));

        }


        [Fact]
        public void MergeWhenTheyhavesamelength()
        {
            LList list1 = new LList();
            list1.Insert(2);
            list1.Insert(4);
         
            LList list2 = new LList();
            list2.Insert(7);
            list2.Insert(79);

            Program.MergeTwoLists(list1, list2);
            //4->79->2->7->null so the second last positon will be 2 which is the last node in list1 when merge
            Assert.Equal(2, list1.GetValue(1));

        }


        [Fact]
        public void MergeWhenlist2islonger()
        {
            LList list1 = new LList();
            list1.Insert(2);
            list1.Insert(4);

            LList list2 = new LList();
            list2.Insert(7);
            list2.Insert(79);
            list2.Insert(9);
            Program.MergeTwoLists(list1, list2);
            //4->9->2->79->7->null so the second last positon will be 2 which is the last node in list1 when merge
            Assert.Equal(79, list1.GetValue(1));

        }



    }
}
