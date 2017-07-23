using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionReverseInteger {
  //static void Main(string[] args) {
  //    int testInput = 187265;
  //    Console.WriteLine(ReverseInteger(testInput));
  //}
    
    
    public static int ReverseInteger(int inputString) {
        double numDigits = inputString.ToString().Length;
        
        double result = 0;
        
        double x = numDigits;
        
        for (int i = 0 ; i < numDigits; i++) {
               
            double currentDigit = Math.Floor((inputString / Math.Pow(10, i)) % 10);

            result = result + (currentDigit * Math.Pow(10, x-1));

            x--;
        }
        
        return (int)result;
    }
}
