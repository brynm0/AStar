using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace AStar
{
    public class AStarComponent : GH_Component
    {
        /// <summary>
        /// Each implementation of GH_Component must provide a public 
        /// constructor without any arguments.
        /// Category represents the Tab in which the component will appear, 
        /// Subcategory the panel. If you use non-existing tab or panel names, 
        /// new tabs/panels will automatically be created.
        /// </summary>
        public AStarComponent()
          : base("AStar", "Nickname",
              "Description",
              "Category", "Subcategory")
        {
        }

        public List<int> AStarSearch (List<Node> nodes, int startIndex, int targetIndex)
        {
            List<Node> closedSet = new List<Node>();
            List<Node> openSet = new List<Node>();
            openSet.Add(nodes[startIndex]);

            nodes[startIndex].gScore = 0;
            nodes[startIndex].fScore = costEstimate(nodes[startIndex], nodes[targetIndex]);

            while (openSet.Count > 0)
            {
                int currentIndex = getLowestFScore(nodes);

                if (currentIndex == targetIndex)
                {
                    return reconstructPath(current);
                }
            }



        }

        public List<int> reconstructPath(int current)
        {

        }

        public int getLowestFScore(List<Node> nodes)
        {
            int recordIndex;
            float record = float.PositiveInfinity;

            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].fScore < record)
                {
                    record = nodes[i].fScore;
                    recordIndex = i;
                }
            }
            return recordIndex;
        }
        public float costEstimate (Node start, Node goal)
        {
            float xDif = (start.position.X - goal.position.Y);
            float yDif = (start.position.Y - goal.position.Y);
            float zDif = (start.position.Z - goal.position.Z);
            float distance = (float)Math.Sqrt(xDif * xDif + yDif * yDif + zDif * zDif);
            return distance;
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object can be used to retrieve data from input parameters and 
        /// to store data in output parameters.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
        }

        /// <summary>
        /// Provides an Icon for every component that will be visible in the User Interface.
        /// Icons need to be 24x24 pixels.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                // You can add image files to your project resources and access them like this:
                //return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Each component must have a unique Guid to identify it. 
        /// It is vital this Guid doesn't change otherwise old ghx files 
        /// that use the old ID will partially fail during loading.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("{fdcc259e-e398-48c3-963d-1ae15b398837}"); }
        }
    }
}
