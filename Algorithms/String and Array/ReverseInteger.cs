using System;

public partial class Algorithm {    
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
