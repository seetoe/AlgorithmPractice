using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

public class SolutionCloneGraph
{
  //static void Main(string[] args) {
  //    GraphNode node1 = new GraphNode(1);
  //    GraphNode node2 = new GraphNode(2);
  //    GraphNode node0 = new GraphNode(0);
  //    node0.Neighbors.Add(node1);
  //    node0.Neighbors.Add(node2);
  //    node1.Neighbors.Add(node2);
  //    node2.Neighbors.Add(node2);
      
  //    //PrintGraph(node0);
      
  //    GraphNode copyNode = CloneGraph(node0);
      
  //    PrintGraph(copyNode);
  //}
    
    public static void PrintGraph (GraphNode node) {
        HashSet<GraphNode> nodesPrinted = new HashSet<GraphNode> ();
        Queue <GraphNode> nodesToVisit = new Queue<GraphNode> ();
        nodesToVisit.Enqueue(node);
        
        while (nodesToVisit.Count > 0) {
            GraphNode currentNode = nodesToVisit.Dequeue();
            
            if (!nodesPrinted.Contains(currentNode)) {
                
                Console.Write("node: " + currentNode.Label + " , neighbors: ");    
                nodesPrinted.Add(currentNode);
                
                foreach (GraphNode gn in currentNode.Neighbors) {
                    Console.Write(gn.Label + " ");
                    nodesToVisit.Enqueue (gn);
                }
                
                Console.WriteLine();
            }
        }
        
        
    }
    
    // clone graph
  public static GraphNode CloneGraph (GraphNode node) {
      // traverse graph using BFS
      Queue<GraphNode> nodesToVisit = new Queue<GraphNode>();
      Dictionary<GraphNode, GraphNode> visitedNodes = new Dictionary<GraphNode, GraphNode>();
      
      GraphNode nodeCopy = new GraphNode(node.Label);
      visitedNodes.Add(node, nodeCopy);
      
      nodesToVisit.Enqueue(node);
      
      while (nodesToVisit.Count > 0) {
          
          GraphNode currentNode = nodesToVisit.Dequeue();
          
          foreach (GraphNode gn in currentNode.Neighbors) {
              // if have not copied node
              if (!visitedNodes.ContainsKey(gn)) {
                  GraphNode copy = new GraphNode(gn.Label);
                  visitedNodes.Add(gn, copy);
                  
                  visitedNodes[currentNode].Neighbors.Add(copy);
                  
                  nodesToVisit.Enqueue (gn);
              }
              else {
                  visitedNodes[currentNode].Neighbors.Add(visitedNodes[gn]);
              }
          }
      }
      
      return nodeCopy;
  }
}

public class GraphNode {
    private int label;
    private List<GraphNode> neighbors = new List<GraphNode> ();
    
    // constructor
    public GraphNode (int label) {
        this.label = label;
        //this.neighbors = neighbors;
    }
    
    public List<GraphNode> Neighbors {
        get {
            return this.neighbors;
        }
    }
    
    public int Label {
        get {
            return this.label;
        }
    }
}