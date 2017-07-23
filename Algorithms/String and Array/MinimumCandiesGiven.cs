using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionMinimumCandiesGiven {
  //static void Main(string[] args) {
  //  int result = MinimumCandiesGiven (new int[] {1, 3, 4, 1});
  //    Console.WriteLine (result);
  //}
    
    // N children standing in a line
    // Each child is assigned a rating value
    // Each child must have at least one candy
    // Children with a higher rating get more candies than their neighbors
    static int MinimumCandiesGiven (int[] childrenRatings) {
        
        if (childrenRatings == null || childrenRatings.Length == 0) {
            return 0;
        }
        
        int[] childrenCandies = new int[childrenRatings.Length];
        childrenCandies[0] = 1;
        
        //Console.WriteLine("Index: 0, Candies: 1");
        
        // left to right
        for (int i = 1; i < childrenRatings.Length; i++) {
            // if ascending order
            if (childrenRatings[i] > childrenRatings[i-1]) {
                childrenCandies[i] = childrenCandies[i-1] + 1;
            }
            else {
                childrenCandies[i] = 1;
            }
            
            //Console.WriteLine("Index: " + i + ", Candies: " + childrenCandies[i]);
        }
        
        int result = childrenCandies[childrenCandies.Length-1];
        
        // right to left
        for (int i = childrenRatings.Length-2; i >= 0; i--) {
            if (childrenRatings[i] < childrenRatings[i+1]) {
                childrenCandies[i+1] = childrenCandies[i+1] + 1;
            }
            
            //Console.WriteLine("Index: " + i + ", Candies: " + childrenCandies[i]);
            
            result += childrenCandies[i];
        }
        
        return result;
    }
}
