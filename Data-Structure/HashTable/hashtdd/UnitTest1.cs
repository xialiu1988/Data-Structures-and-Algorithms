using System;
using Xunit;
using HashTable;
using HashTable.Classes;

namespace hashtdd
{
    public class UnitTest1
    {
        [Fact]
        public void canaddkeyandvaluetothetable()
        {
            Hash_table h = new Hash_table();
            h.add(5, "test");
            Assert.True(h.Contains(5));

        }
        /// <summary>
        /// has same hashindex,5 and 15 %10 both ==5;
        /// </summary>
        [Fact]
        public void canhandelcollison()
        {
            Hash_table h = new Hash_table();
            h.add(5, "test");
            h.add(15, "test");
            Assert.True(h.Contains(5));
            Assert.True(h.Contains(15));

        }



        /// <summary>
        ///  Retrieving based on a key returns the value stored
        /// </summary>

        [Fact]
        public void cangetvaluebykey()
        {
            Hash_table h = new Hash_table();
            h.add(5, "test");
            h.add(15, "testyouandme");
            Assert.Equal("test",h.get(5));

        }
        /// <summary>
        ///   Successfully returns null for a key that does not exist in the hashtable
        /// </summary>

        [Fact]
        public void canhandelifkeynotexsits()
        {
            Hash_table h = new Hash_table();
            h.add(5, "test");
            Assert.Equal("Key Not available", h.get(11));

        }

        [Fact]
        public void canhashakey()
        {
            Hash_table h = new Hash_table();
            int n = h.Hash(6);
            Assert.Equal(6, n);

        }

    }
}
