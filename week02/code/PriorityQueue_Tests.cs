using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items that has  different priorities and remove one
// Expected Result: then the Highest priority item is returned
// Defect(s) Found: 
   public void TestPriorityQueue_1()
{
    var pq = new PriorityQueue();

    pq.Enqueue("A", 1);
    pq.Enqueue("B", 5);
    pq.Enqueue("C", 3);

    var result = pq.Dequeue();

    Assert.AreEqual("B", result);
}

    [TestMethod]
     // Scenario: gives two items with same priority
     // Expected Result: First inserted item with highest priority is removed first
     // Defect(s) Found:
public void TestPriorityQueue_2()
{
    var pq = new PriorityQueue();

    pq.Enqueue("A", 5);
    pq.Enqueue("B", 5);
    pq.Enqueue("C", 1);

    var first = pq.Dequeue();

    Assert.AreEqual("A", first);
}
   

    // Add more test cases as needed below.


[TestMethod]
// Scenario: Multiple removals
// Expected Result: B, A, C (which is based on priority rules)
// Defect(s) Found:
public void TestPriorityQueue_3()
{
    var pq = new PriorityQueue();

    pq.Enqueue("A", 2);
    pq.Enqueue("B", 5);
    pq.Enqueue("C", 1);

    Assert.AreEqual("B", pq.Dequeue());
    Assert.AreEqual("A", pq.Dequeue());
    Assert.AreEqual("C", pq.Dequeue());
}
[TestMethod]
// Scenario: Dequeue from an empty queue
// Expected Result: InvalidOperationException with message "The queue is empty."
// Defect(s) Found:
public void TestPriorityQueue_Empty()
{
    var pq = new PriorityQueue();

    try
    {
        pq.Dequeue();
        Assert.Fail("Exception should have been thrown.");
    }
    catch (InvalidOperationException e)
    {
        Assert.AreEqual("The queue is empty.", e.Message);
    }
}
 [TestMethod]
// Scenario: Same priority items which maintains FIFO order
// Expected Result: A then B
// Defect(s) Found:
public void TestPriorityQueue_FifoOrder()
{
    var pq = new PriorityQueue();

    pq.Enqueue("A", 10);
    pq.Enqueue("B", 10);

    Assert.AreEqual("A", pq.Dequeue());
    Assert.AreEqual("B", pq.Dequeue());
}
}
