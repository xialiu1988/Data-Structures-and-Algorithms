using System;
using Xunit;
using binarysearch;

namespace BinarySearchTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CannotreturnIndexnotexist()
        {
            int[] arr = { 11, 22, 33, 44, 55, 66, 77 };
            int key = 99;
            int expected = -1;
            Assert.Equal(expected,Program.BinarySearch(arr,key));

        }


        [Fact]
        public void CanreturnIndexTwo()
        {
            int[] arr = { 4, 8, 15, 16, 23, 42 };
            int key = 15;
            int expected = 2;
            Assert.Equal(expected, Program.BinarySearch(arr, key));

        }

        [Fact]
        public void CanreturnIndexZero()
        {
            int[] arr = { 4, 8, 15 };
            int key = 4;
            int expected = 0;
            Assert.Equal(expected, Program.BinarySearch(arr, key));

        }


        [Fact]
        public void CannotreturnIndex()
        {
            int[] arr = { };
            int key = 4;
            int expected = -1;
            Assert.Equal(expected, Program.BinarySearch(arr, key));

        }


    }
}
