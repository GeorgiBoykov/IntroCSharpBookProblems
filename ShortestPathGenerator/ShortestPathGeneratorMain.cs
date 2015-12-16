// 3. Using the described methodology of creating solutions to programming
// problems, solve the following problem: a map of a city is given. At this
// map there are given roads and crossroads. For every road a length is
// given. One crossroad can connect a couple of roads. Your program must
// find the shortest path from one crossroad to another (the shortest
// path is measured as the sum of the lengths of all includes roads).
// A sample map is given below. At this map the shortest path between the
// crossings A and D has length of 70 and it is shown on the figure with
// bold lines. As you can see, this is not the only path from A to D: there are
// more paths with different lengths. Note that not always the first shortest
// road considered as current next node leads to finding the shortest path,
// neither does the lowest count of roads. Between some crossings there
// may not even be a road. This creates a very interesting problem.

namespace ShortestPathGenerator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ShortestPathGeneratorMain
    {

        public static void Main()
        {
            string filePath = "../../map.txt";

            Dictionary<Node, List<Edge>> graph = new Dictionary<Node, List<Edge>>();
            List<string> requests = new List<string>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line = sr.ReadLine();

                while (line != string.Empty)
                {
                    InsertEdge(graph, line);

                    line = sr.ReadLine();
                }

                line = sr.ReadLine();

                while (line != string.Empty && line != null)
                {
                    requests.Add(line);

                    line = sr.ReadLine();
                }
            }

            GenerateShortestPaths(graph, requests);
        }

        private static void GenerateShortestPaths(Dictionary<Node, List<Edge>> graph, List<string> requests)
        {

            foreach (string request in requests)
            {
                string[] points = request.Split(' ');
                string pointA = points[0];
                string pointB = points[1];

                Node sourceNode = graph.Keys.First(k => k.Id == pointA);
                Node destinationNode = graph.Keys.First(k => k.Id == pointB);

                if (!double.IsPositiveInfinity(destinationNode.Distance))
                {
                    ApplyDijkstraAlgorithm(graph, sourceNode);
                    List<Node> path = FindPath(graph, destinationNode);
                    string pathStr = string.Join("", path.Select(node => node.Id));
                    Console.WriteLine("{0} {1}", destinationNode.Distance, pathStr);
                }
                else
                {
                    Console.WriteLine("No path!");
                }
            }
        }

        private static void InsertEdge(Dictionary<Node, List<Edge>> graph, string edge)
        {

            string[] parameters = edge.Split(' ');
            string leftNode = parameters[0];
            string rightNode = parameters[1];

            int distance = int.Parse(parameters[2]);

            if (!graph.Keys.Any(n => n.Id == rightNode))
            {
                graph[new Node(rightNode)] = new List<Edge>();
            }

            if (!graph.Keys.Any(n => n.Id == leftNode))
            {
                graph[new Node(leftNode)] = new List<Edge>();
            }

            graph[graph.Keys.First(n => n.Id == leftNode)].Add(new Edge(graph.Keys.First(n => n.Id == rightNode), distance));
        }

        private static void ApplyDijkstraAlgorithm(Dictionary<Node, List<Edge>> graph, Node sourceNode)
        {
            PriorityQueue<Node> queue = new PriorityQueue<Node>();

            foreach (KeyValuePair<Node, List<Edge>> node in graph)
            {
                node.Key.Distance = double.PositiveInfinity;
            }
            sourceNode.Distance = 0.0d;
            queue.Enqueue(sourceNode);

            while (queue.Count != 0)
            {
                Node currentNode = queue.Dequeue();

                if (double.IsPositiveInfinity(currentNode.Distance))
                {
                    // All nodes processed --> algorithm finished
                    break;
                }

                foreach (Edge childEdge in graph[currentNode])
                {
                    double newDistance = currentNode.Distance + childEdge.Distance;

                    if (newDistance < childEdge.Node.Distance)
                    {
                        childEdge.Node.Distance = newDistance;
                        childEdge.Node.PreviousNode = currentNode;
                        queue.Enqueue(childEdge.Node);
                    }
                }
            }
        }

        private static List<Node> FindPath(Dictionary<Node, List<Edge>> graph, Node node)
        {
            List<Node> path = new List<Node>();

            while (node != null)
            {
                path.Add(node);
                node = node.PreviousNode;
            }

            path.Reverse();
            return path;
        }
    }
}