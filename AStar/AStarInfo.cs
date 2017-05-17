using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace AStar
{
    public class AStarInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "AStar";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("4f2e0526-de73-4ccd-b428-fbd852d5ac8f");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
