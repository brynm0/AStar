using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Rhino.Geometry;


namespace AStar
{
    public class Node
    {
        public Vector3f position { get; set; }
        public List<int> neighbours { get; set; }
        public float gScore { get; set; }
        public float fScore { get; set; }
        public Node cameFrom { get; set; }

        public Node (Vector3f _position, List<int> _connections)
        {
            this.gScore = float.PositiveInfinity;
            this.fScore = float.PositiveInfinity;
            this.position = _position;
            this.neighbours = _connections;
            this.cameFrom = null;
        }
    }
}
