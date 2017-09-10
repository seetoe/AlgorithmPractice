using System;

public class SolutionMinesweeper {
	//In the game of Minesweeper you are given a grid of size L x W that has a variable number of mines, M, in random locations within the grid.
    //Write a function that generates random mine locations within the grid.

	//Change your code if you also had to generate the tile numbers (the number on a non-mine tile should represent the number of mines in adjacent tiles)

	//inputs:
	//L - int
	//W - int
	//M - int

	//output:
	//array[][] mines


	//public static void Main (string[] args) {
	//    int length = 5;
	//    int width = 6;
	//    int numOfMines = 20;
	//    Minesweeper (length, width, numOfMines);
	//}

	public static int[,] Minesweeper(int l, int w, int m) {
    
        int[,] grid = new int[l,w];
        
        // initialize all counts in grid to 0 mines
        for (int j = 0; j < l; j++) {
            for (int k = 0; k < w; k++) {
                grid[j,k] = 0;
            }
        }
        
        int i = 0;
        
        // place mines
        while (i < m) {
            Random randomLocation = new Random();
            
            int firstIndex = randomLocation.Next(0, l-1);
            int secondIndex = randomLocation.Next(0, w-1);
            
            // if grid location is empty, valid spot for new mine. use value -1 to flag as mine
            if (grid[firstIndex, secondIndex] != -1) {
                grid[firstIndex, secondIndex] = -1;            
                i++;
                
                // update tiles around this mine (increment by 1)
                for (int p = firstIndex-1; p <= firstIndex+1; p++) {
                    for (int r = secondIndex-1; r <= secondIndex+1; r++) {
                        //          check if current location is in bounds of grid
                        if (p >= 0 && p < l && r >= 0 && r < w) {
                            // if current location is NOT mine location, THEN increment count
                            if (grid[p,r] != -1) {
                                grid[p,r] = grid[p,r] + 1; 
                            }
                        }
                    }
                }
            }
        }
        
        return grid;
    }
}