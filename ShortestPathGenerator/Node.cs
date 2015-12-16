namespace ShortestPathGenerator {

    using System;

    public class Node : IComparable
    {
        public Node(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }
        public double Distance { get; set; }
        public Node PreviousNode { get; set; }

        public int CompareTo(object otherNode)
        {
            return this.Distance.CompareTo((otherNode as Node).Distance);
        }
    }
}
