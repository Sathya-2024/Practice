﻿namespace Training {
   internal class Program {
      static void Main (string[] args) {
         // Fibonacci series
         Console.Write ("Enter a number n:");
         int n = int.Parse (Console.ReadLine ());
         int first = 0;
         int second = 1;
         int third = first + second;

         string fibonacci = string.Empty;
         for(int i =2; i <= n-1; i++) {
            third = first + second;
            first = second;
            second = third;
            fibonacci += third;
         }
         Console.WriteLine ($"Fibonacci of {n} is {fibonacci}"); 

      }
   }
}