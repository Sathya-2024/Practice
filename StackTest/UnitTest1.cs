using Training;
namespace StackTest {
   [TestClass]
   public class UnitTest1 {
      TStack<int> myStack = new ();
      Stack<int> Stack = new ();

      [TestMethod]
      public void TestPeek () {
         for (int i = 1; i <= 5; i++) {
            myStack.Push (i);
            Stack.Push (i);
         }
         Assert.AreEqual (Stack.Peek (), myStack.Peek ());
         for (int i = 1; i <= 5; i++) Assert.AreEqual (myStack.Pop (), Stack.Pop ());
         Assert.ThrowsException<InvalidOperationException> (() => myStack.Peek ());
         Assert.ThrowsException<InvalidOperationException> (() => Stack.Peek ());
         Assert.IsTrue (myStack.IsEmpty);
      }

      [TestMethod]
      public void TestPop () {
         for (int i = 1; i <= 5; i++) {
            myStack.Push (i);
            Stack.Push (i);
         }
         Assert.AreEqual (Stack.Count, myStack.Count);
         for (int i = 1; i <= 5; i++) {
            myStack.Pop ();
            Stack.Pop ();
         }
         Assert.IsTrue (myStack.IsEmpty);
         Assert.ThrowsException<InvalidOperationException> (() => myStack.Pop ());
         Assert.ThrowsException<InvalidOperationException> (() => Stack.Pop ());
      }

      [TestMethod]
      public void TestPush () {
         for (int i = 1; i <= 5; i++) {
            myStack.Push (i);
            Stack.Push (i);
         }
         Assert.AreEqual (myStack.Count, Stack.Count);
         Assert.AreEqual (8, myStack.Capacity);
      }
   }
}