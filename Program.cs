﻿// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Classes MYLIST<T>
// public MyList () { } 
// public int Count { get; }
// public int Capacity { get; }
// public T this[int index] { get; set; }
// public void Add (T a) { }
// public bool Remove (T a) { }
// public void Clear () { }
// public void Insert (int index, T a) { }
// public void RemoveAt (int index) { } 
// Implement a custom MyList<T> class using arrays as the underlying data structure.
// The MyList<T> should start with an initial capacity of 4 and double its capacity when needed.
// Use the template shown below for implementation. Throw exceptions when necessary.
// IndexOutOfRangeException: This exception should be thrown when attempting to access an index that is out of the valid range. 
// InvalidOperationException: This exception should be thrown when attempting to remove an item that is not found in the list. 
// --------------------------------------------------------------------------------------------
using System;
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary> Classes MyList<T> </summary>
   internal class Program {
      /// <summary> Create MyList </summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
      }
   }
   #endregion
   #region MyList------------------------------------------------------------------------------
   /// <summary> Create MyList </summary>
   /// <typeparam name="T"></typeparam>
   public class MyList<T> {
      #region Properties------------------------------------------------------------------------------
      /// <summary> count of the array </summary>
      public int Count => mCount;
      /// <summary> Length of the array </summary>
      public int Capacity => mArray.Length;
      /// <summary> Set a index value </summary>
      /// <param name="index"></param>
      /// <returns> Return the items from list using its index </returns>
      public T this[int index] {
         get {
            CheckException (index);
            return mArray[index];
         }
         set {
            CheckException (index);
            mArray[index] = value;
         }
      }
      #endregion
      #region Methods ------------------------------------------------------------------------------
      /// <summary> Add all the elements </summary>
      /// <param name="item"></param>
      public void Add (T item) {
         if (mCount == mArray.Length) Array.Resize (ref mArray, mArray.Length * 2);
         mArray[mCount++] = item;
      }
      /// <summary> Clear all the element </summary>
      public void Clear () {
         Array.Clear (mArray, 0, mCount);
         mCount = 0;
      }
      /// <summary> Insert an element </summary>
      /// <param name="index"></param>
      /// <param name="item"></param>
      /// <exception cref="IndexOutOfRangeException"></exception>
      public void Insert (int index, T item) {
         CheckException (index);
         if (mCount == mArray.Length) Array.Resize (ref mArray, mArray.Length * 2);
         for (int i = mCount; i > index; i--) mArray[i] = mArray[i - 1];
         mArray[index] = item;
         mCount++;
      }
      /// <summary> Remove the element </summary>
      /// <param name="item"></param>
      /// <returns> true </returns>
      public bool Remove (T item) {
         int index = Array.IndexOf (mArray, item, 0, mCount);
         if (index == -1) return false;
         for (int i = index; i < mCount - 1; i++) mArray[i] = mArray[i + 1];
         mArray[--mCount] = default;
         return true;
      }
      /// <summary> Remove the element at a specific index </summary>
      /// <param name="index"></param>
      /// <exception cref="ArgumentOutOfRangeException"></exception>
      public void RemoveAt (int index) {
         ArgumentOutOfRangeException (index);
         var item = mArray[index];
         Remove (item);
      }
      /// <summary> Check the index out of range exception </summary>
      /// <param name="index"></param>
      /// <returns> true </returns>
      /// <exception cref="IndexOutOfRangeException"></exception>
      public bool CheckException (int index) {
         if (index < 0 || index >= mCount) throw new IndexOutOfRangeException ("Index is out of the valid range.");
         return true;
      }
      /// <summary> Check argument out of range exception </summary>
      /// <param name="index"></param>
      /// <returns></returns>
      /// <exception cref="ArgumentOutOfRangeException"></exception>
      public bool ArgumentOutOfRangeException (int index) {
         if (index < 0 || index >= mCount) throw new ArgumentOutOfRangeException ("Index is out of the valid range.");
         return true;
      }
      #region Private data------------------------------------------------------------------------------
      /// <summary> Declare and initialize the array </summary>
      T[] mArray = new T[4];
      int mCount = 0;
      #endregion
   }
   #endregion 
}
#endregion