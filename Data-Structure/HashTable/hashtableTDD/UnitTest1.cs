using HashTable.Classes;
using System;
using Xunit;


namespace hashtableTDD
{
    public class UnitTest1
    {
        [Fact]
        public void canaddkeyvaluetomyhashtable()
        {
            Hash_table ht = new Hash_table();
            ht.add(5, "test");
            Assert.True(ht.Contains(5));
        }
    }
}
