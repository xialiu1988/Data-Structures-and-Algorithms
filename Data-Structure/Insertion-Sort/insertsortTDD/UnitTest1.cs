using System;
using Xunit;
using Insertion_Sort;
namespace insertsortTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Sortunsortedarray()
        {
            int[] arr = { 3, 41, 1 };
          int[] a=Program.InsertionSort(arr);
            Assert.Equal(1, a[0]);
            Assert.Equal(3, a[1]);
            Assert.Equal(41, a[2]);
        }

        [Fact]
        public void Sortsortedarray()
        {
            int[] arr = { 1,3,41};
           int[] a= Program.InsertionSort(arr);
            Assert.Equal(1, a[0]);
            Assert.Equal(3, a[1]);
            Assert.Equal(41, a[2]);
        }
    
        [Fact]
        public void Sortbackwardssortedarray()
        {
            int[] arr = { 41 ,3,1};
           int[] a= Program.InsertionSort(arr);
            Assert.Equal(1, a[0]);
            Assert.Equal(3, a[1]);
            Assert.Equal(41, a[2]);
        }
        /// <summary>
        /// empty array no value
        /// </summary>
        [Fact]
        public void Sortemptyarray()
        {
            int[] arr = new int[] { };

            int[] a = Program.InsertionSort(arr);
            Assert.True(a.Length==0);
          
        }

        /// <summary>
        /// return same array with one value
        /// </summary>
        [Fact]
        public void SortOneElement()
        {
            int[] arr =  {5};

            int[] a = Program.InsertionSort(arr);
            Assert.True(a.Length == 1);
            Assert.Equal(5, arr[0]);

        }
    }
}
