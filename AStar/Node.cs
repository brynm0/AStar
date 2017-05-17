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
        public List<int> connections { get; set; }
        public Node (Vector3f _position, List<int> _connections)
        {
            this.position = _position;
            this.connections = _connections;
        }
    }
}
