using System;
using Xunit;
using find_maximum_value_binary_tree;
using System.Collections.Generic;

namespace MaximumTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindMax()
        {
            Tree tr = Program.GetAtree();
            List<TreeNode> group = Program.GetAllValues(tr.Root);

            Assert.True( group[3].Value==330);
            Assert.True(group[3].Value > group[2].Value);
            Assert.True(group[3].Value > group[5].Value);

        }
        [Fact]
        public void CanFindValue()
        {
            Tree tr = Program.GetAtree();
            List<TreeNode> group = Program.GetAllValues(tr.Root);

            Assert.True(group[3].Value == 330);
            Assert.True(group[3].Value > group[1].Value);
            Assert.True(group[3].Value > group[4].Value);

        }
        [Fact]
        public void CangetValue()
        {
            Tree tr = Program.GetAtree();
            List<TreeNode> group = Program.GetAllValues(tr.Root);

            Assert.True(group[3].Value == 330);
            Assert.True(group[3].Value > group[6].Value);

        }
    }
}
