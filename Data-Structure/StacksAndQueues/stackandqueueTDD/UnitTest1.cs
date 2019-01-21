using System;
using Xunit;
using StacksAndQueues.Classes;

namespace stackandqueueTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushOneNodetoStack()
        {
            Stack stack = new Stack();
            stack.Push(4);

            Assert.Equal(4, stack.Top.Value);
        }


        [Fact]
        public void CanPushNodetoStack()
        {
            Stack stack = new Stack();
            stack.Push(4);
            stack.Push(44);
            Assert.Equal(44, stack.Top.Value);
        }



        [Fact]
        public void CanPushnullNodetoStack()
        {
            Node node = new Node(34);
            Stack stack = new Stack(node);
            stack.Push(13);

            Assert.Equal(13, stack.Top.Value);
        }

        [Fact]
        public void CanPopNodefromStack()
        {
            Stack stack = new Stack();
            stack.Push(4);
            stack.Push(44);
            Assert.True(stack.Top.Value == 44);
            stack.Pop();
            Assert.True(stack.Top.Value == 4);

        }



        [Fact]
        public void PopNodefromStack()
        {
            Stack stack = new Stack();
            stack.Push(44);
            Assert.True(stack.Top.Value == 44);
            stack.Pop();
            Assert.True(stack.Top == null);

        }




        [Fact]
        public void CanPopNodefromtheStack()
        {
            Node node = new Node(34);
            Stack stack = new Stack(node);
            stack.Push(13);
            Assert.True(stack.Top.Value == 13);
            stack.Pop();
            Assert.True(stack.Top.Value == 34);

        }





    }
}
