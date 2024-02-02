// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to compute several basic statistical operations:
// It will accept numbers from the user and after each input
// It will display their sum, average, minimum and maximum. 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Print their sum, average, maximum and minimum value</summary>
   internal class Program {
      static void Main (string[] args) {
         List<int> list = new ();
         int sum = 0;
         for (; ; ) {
            Console.Write ("Enter a number : ");
            string input = Console.ReadLine ();
            if (int.TryParse (input, out int number)) {
               list.Add (number);
               sum += number;
               float average = (float)sum / list.Count;
               int max = list.Count > 0 ? list.Max () : 0;
               int min = list.Count > 0 ? list.Min () : 0;
               Console.WriteLine ($"Sum : {sum}");
               Console.WriteLine ($"Average : {average}");
               Console.WriteLine ($"Maximum : {max}");
               Console.WriteLine ($"Minimum : {min}");
            } else Console.WriteLine ("Invalid input . Please enter a number ");
         }
      }
   }
   #endregion
}