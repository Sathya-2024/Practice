// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ---------------------------------------------------------------------------- CUILib ---
// Program.cs
// Classes TStack<T>
// Implement a Stack<T> class using arrays as the underlying data structure.
// The Stack<T> should start with an  initial capacity of 4 and double its capacity when needed.
// Use the template shown below for implementation. Throw exceptions when necessary.
// class TStack<T> 
// public void Push (T a) { }
// public T Pop () { }
// public T Peek () { }
// public bool IsEmpty { get; }
// InvalidOperationException: This exception should be thrown when attempting to pop or peek an empty stack. 
// ---------------------------------------------------------------------------------------
namespace Training {
   internal class Program {
      static void Main (string[] args) { }
   }

   #region TStack ------------------------------------------------------------------------
   /// <summary>Create Tstack</summary>
   /// <typeparam name="T"> Datatype </typeparam>
   public class TStack<T> {
      #region Properties --------------------------------------------
      /// <summary>Length of the array</summary>
      public int Capacity => mArray.Length;

      /// <summary>Count of the array</summary>
      public int Count => mCount;

      /// <summary>The count is zero</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Methods -----------------------------------------------
      /// <summary>Check the empty stack</summary>
      /// <exception cref="InvalidOperationException"></exception>
      void CheckException () {
         if (IsEmpty) throw new InvalidOperationException ("Empty stack");
      }

      /// <summary>Order of the elements</summary>
      /// <returns>Return which order of the last element</returns>
      public T Peek () {
         CheckException ();
         return mArray[mCount - 1];
      }

      /// <summary>Remove the elements</summary>
      /// <returns>Return Remove the elements</returns>
      public T Pop () {
         CheckException ();
         T i = mArray[mCount - 1];
         mArray[--mCount] = default;
         return i;
      }

      /// <summary>Add all the elements</summary>
      /// <param name="a"></param>
      public void Push (T a) {
         if (mCount == mArray.Length) Array.Resize (ref mArray, mArray.Length * 2);
         mArray[mCount++] = a;
      }
      #endregion 

      #region Private data ------------------------------------------
      /// <summary>Declare and intialize the array</summary>
      T[] mArray = new T[4];
      int mCount = 0;
      #endregion 
   }
   #endregion 
}