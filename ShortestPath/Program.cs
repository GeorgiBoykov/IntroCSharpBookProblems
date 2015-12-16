using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize neighbors using predefined dixtionary
            foreach (Node node in graph)
            {
                node.Neighbours = new List<Neighbour>();
                foreach (KeyValuePair<string, Dictionary<string, int>> neighbor in node.DistanceDict)
                {
                    Neighbour newNeightbor = new Neighbour();
                    foreach (Node graphNode in graph)
                    {
                        if (graphNode.Name == neighbor.Key)
                        {
                            newNeightbor.Node = graphNode;
                            newNeightbor.Distance = neighbor.Value.Values.Sum();
                            node.Neighbours.Add(newNeightbor);
                            break;
                        }
                    }
                }
            }

            TransverNode(graph[0]);
            foreach (Node node in graph)
            {
                Console.WriteLine("Node : {0}", node.Name);
                foreach (string key in node.DistanceDict.Keys.OrderBy(x => x))
                {
                    Console.WriteLine(" Path to node {0} is {1}", key, string.Join(",", node.DistanceDict[key].ToArray()));
                }
            }
        }

        //A connected to B
        //B connected to A, C , D
        //C connected to B, D
        //D connected to B, C , E
        //E connected to D.
        static List<Node> graph = new List<Node>() {
            new Node {Name = "A", DistanceDict = new Dictionary<string, Dictionary<string, int>>()
            {
                {"B", new Dictionary<string, int>(){{"B", 2}}}
            }, 
                Visited = false},
            new Node {Name = "B", DistanceDict = new Dictionary<string,Dictionary<string, int>>()
            {
                {"A",new Dictionary<string, int>{{"A", 3}}}, {"C",new Dictionary<string, int>{{"C", 4}}}, {"D",new Dictionary<string, int>{{"D", 5}}}
            },
                Visited = false},
            new Node {Name = "C", DistanceDict = new Dictionary<string,Dictionary<string, int>>(){
                {"B",new Dictionary<string, int>{{"B", 4}}}, {"D",new Dictionary<string, int>{{"D", 1}}}}
                ,
                Visited = false},
            new Node {Name = "D", DistanceDict = new Dictionary<string,Dictionary<string, int>>()
            {
                {"B",new Dictionary<string, int>{{"B", 4}}}, {"C",new Dictionary<string, int>{{"C", 2}}}, {"E",new Dictionary<string, int>{{"E", 5}}}
            },
                Visited = false},
            new Node {Name = "E", DistanceDict = new Dictionary<string,Dictionary<string, int>>(){
                {"D",new Dictionary<string, int>{{"D", 4}}}},
                Visited = false}
        };
       
        static void TransverNode(Node node)
        {
            if (!node.Visited)
            {
                node.Visited = true;
                foreach (Neighbour neighbour in node.Neighbours)
                {
                    TransverNode(neighbour.Node);
                    string neighborName = neighbour.Node.Name;
                    int neighborDistance = neighbour.Distance;
                    
                    //compair neighbours dictionary with current dictionary
                    //update current dictionary as required
                    
                    foreach (string key in neighbour.Node.DistanceDict.Keys)
                    {
                        if (key != node.Name)
                        {
                            int neighborKeyDistance = neighbour.Node.DistanceDict[key].Count;
                            
                            if (node.DistanceDict.ContainsKey(key))
                            {
                                int currentDistance = node.DistanceDict[key].Count;
                                if (neighborKeyDistance + neighborDistance < currentDistance)
                                {
                                    List<string> nodeList = new List<string>();
                                    nodeList.AddRange(neighbour.Node.DistanceDict[key].Keys.ToArray());
                                    nodeList.Insert(0, neighbour.Node.Name);
                                    node.DistanceDict[key] = new Dictionary<string,int>{{key, nodeList.Count}};
                                }
                            }
                            else
                            {
                                List<string> nodeList = new List<string>();
                                nodeList.AddRange(neighbour.Node.DistanceDict[key].Keys.ToArray());
                                nodeList.Insert(0, neighbour.Node.Name);
                                node.DistanceDict.Add(key, new Dictionary<string,int>{{key, nodeList.Count}});
                            }
                        }
                    }
                }
            }
        }
    }
}
