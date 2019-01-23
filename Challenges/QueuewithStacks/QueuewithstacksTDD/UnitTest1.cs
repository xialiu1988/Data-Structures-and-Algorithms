using System;
using Xunit;
using QueuewithStacks;
using static QueuewithStacks.PseudoQueue;

namespace QueuewithstacksTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueValue()
        {
            Stack stack = new Stack();
            PseudoQueue pse = new PseudoQueue(stack);
            pse.Enqueque(68);

            Assert.Equal(68, pse.Front.Top.Value);

        }

        [Fact]
        public void CanEnqueueValueTotheQueue()
        {
            Stack stack = new Stack();
            stack.Push(32);
            stack.Push(2);
            PseudoQueue pse = new PseudoQueue(stack);
            pse.Enqueque(68);

            while (pse.Front.Top.Next != null)
            {
                pse.Front.Top = pse.Front.Top.Next;
            }
            int res = pse.Front.Top.Value;

            Assert.Equal(68, res);
        }


        [Fact]
        public void CanEnqueueTotheQueue()
        {
            Node node = new Node(14);
            Stack stack = new Stack(node);
    
            PseudoQueue pse = new PseudoQueue(stack);
            pse.Enqueque(68);

            Assert.Equal(14, pse.Front.Top.Value);
        }


        [Fact]
        public void CanDequeuefromtheQueue()
        {
            Node node = new Node(14);
            Stack stack = new Stack(node);

            PseudoQueue pse = new PseudoQueue(stack);
            pse.Enqueque(68);
            pse.Dequeue();

            Assert.Equal(68, pse.Front.Top.Value);
        }


        [Fact]
        public void CanDequeuefromthequeue()
        {

            Stack stack = new Stack();

            PseudoQueue pse = new PseudoQueue(stack);
            pse.Enqueque(68);
            pse.Dequeue();

            Assert.True(pse.Front.Top==null);
        }

        [Fact]
        public void CanDequeuefromtheQueuewhichIsnotempty()
        {

            Stack stack = new Stack();
            stack.Push(20);
            stack.Push(32);
            PseudoQueue pse = new PseudoQueue(stack);
            pse.Enqueque(68);
            pse.Dequeue();

            Assert.Equal(20, pse.Front.Top.Value);
        }
    }
}
