#Queues with Stacks

# Implement a Queue using two Stacks.
<!-- Short summary or background information -->

Queue:FIFO

Stack:FILO

## Challenge
<!-- Description of the challenge -->
Create a brand new PseudoQueue class. 

PseudoQueue class will implement the standard queue interface, but will internally only utilize 2 Stack objects. 

enqueue(value) which inserts value into the PseudoQueue, using a first-in, first-out approach.

dequeue() which extracts a value from the PseudoQueue, using a first-in, first-out approach.

The Stack instances have only push, pop, and peek methods. 

Instantiate these Stack objects in your PseudoQueue constructor.


## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

Enqueue:
T<- O(n)
S<- O(n);

Dequeue:
T<- O(1)
S<- O(1);

## Solution
<!-- Embedded whiteboard image -->

Following is the whiteboard picture


![img](../../Assets/pwithstack.jpg)