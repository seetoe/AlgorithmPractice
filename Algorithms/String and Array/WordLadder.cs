using System;
using System.Collections.Generic;
using System.Linq;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionWordLadder {
  //static void Main(string[] args) {
  //    HashSet<string> dict = new HashSet<string>();
  //    dict.Add("hot");
  //    dict.Add("dot");
  //    dict.Add("dog");
  //    dict.Add("lot");
  //    dict.Add("log");

  //    Console.Write(WordLadder ("hit", "cog", dict));
  //}
    
   // Given two words (start and end), and a dictionary, find the length of shortest transformation sequence from start to end, such that only one letter can be changed at a time and each intermediate word must exist in the dictionary. all words have the same length
    static int WordLadder(string startWord, string endWord, HashSet<string> dict) {
       
        if (dict.Count == 0) {
            return 0;
        }
        if (startWord == endWord) {
            return 0;
        }
        
        Queue<string> words = new Queue<string>();
        Queue<int> distances = new Queue<int>();
        
        words.Enqueue(startWord);
        distances.Enqueue(1);
        
        int? minSequenceLength = null;
        
        while (words.Count > 0) {
            string currentWord = words.Dequeue();// cat
            int currentDistance = distances.Dequeue();//1
            
            if (currentWord == endWord) {
                if (minSequenceLength == null) {
                    minSequenceLength = currentDistance;
                }
                else if (minSequenceLength > currentDistance) {
                    minSequenceLength = currentDistance;
                }
            }
            
            for (int i = 0; i < currentWord.Length; i++) {
                
                for (char j = 'a'; j <= 'z'; j++) {
  
                    char[] currentWordArray = currentWord.ToArray();
                    
                    currentWordArray[i] = j;
                    string newWord = new string(currentWordArray);
                    
                    
                    if (newWord == endWord) {
                        if (minSequenceLength == null) {
                            minSequenceLength = currentDistance + 1;
                        }
                        else if (minSequenceLength > currentDistance) {
                            minSequenceLength = currentDistance + 1;
                        }
                    }
                    
                    if (dict.Contains(newWord)) {
                        
                        words.Enqueue(newWord);
                        distances.Enqueue(currentDistance + 1);
                        
                        dict.Remove(newWord);
                    }    
                    
                }    
            }
        }
        
        if (minSequenceLength != null) {
            return (int)minSequenceLength;
        }
        else {
            return 0;    
        }
        
    }
}
