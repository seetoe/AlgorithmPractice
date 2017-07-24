using System;
using System.Collections.Generic;

// design and implement a data structure for LRU cache
// it should support get and set
public class LRUCache {
    
    private int capacity;
    private LinkedList<int> cache = new LinkedList<int> ();
    private Dictionary<int, int> cacheData = new Dictionary<int, int>();
    
    // constructor
    public LRUCache (int capacity) {
        this.capacity = capacity;
    }
    
    public int get (int key) {
        if (cache.Contains(key)) {
            return cacheData[key];
        }
        else {
            return -1;
        }
    }
    
    public void set (int key, int value) {
        // key is present, set value
        if (cache.Contains(key)) {
            cacheData[key] = value;
        }
        // key is not present, insert the value
        else {
            // if capacity reached, need to remove first
            if (cache.Count == capacity) {
                // remove LRU item
                cacheData.Remove(cache.First.Value);
                cache.RemoveFirst();
            }
            cache.AddLast(key);
            cacheData.Add(key, value);    
        }
    }
}
