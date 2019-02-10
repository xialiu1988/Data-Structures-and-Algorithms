using System;
using Xunit;
using SumOddNum_BST;
namespace SumOfOddTDD
{
    public class UnitTest1
    {/// <summary>
    /// get sum of all odd nums-->success
    /// </summary>
        [Fact]
        public void CanGetSumOfOddNumbers()
        {
            Tree testtree = new Tree();
            testtree.Add(66);
            testtree.Add(5);
            testtree.Add(33);
          int sum=  Program.getsum(testtree.Root, 0);
            Assert.Equal(38, sum);
        }

        /// <summary>
        /// expected fail
        /// </summary>
        [Fact]
        public void GetSumOfOddNumbers()
        {
            Tree testtree = new Tree();
            testtree.Add(66);
            testtree.Add(5);
            testtree.Add(33);
            int sum = Program.getsum(testtree.Root, 0);
            Assert.False(sum==66);
        }


        /// <summary>
        /// edgecase:null tree
        /// </summary>
        [Fact]
        public void testanulltree()
        {
            Tree test2 = new Tree();
            Assert.Equal(0, Program.getsum(test2.Root, 0));
        }
    }
}
