namespace ShortestPath
{
    using System;
    using System.Collections.Generic;

    public class Node
    {
        public string Name { get; set; }
        public Dictionary<string, Dictionary<string, int>> DistanceDict { get; set; }
        public Boolean Visited { get; set; }
        public List<Neighbour> Neighbours { get; set; }
    }
}
