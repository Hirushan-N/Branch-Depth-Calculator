using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch_Depth_Calculator
{
    public class Branch
    {
        public List<Branch> branches = new List<Branch>();

        public int CalculateDepth()
        {
            int depth = 1;
            int maxDepth = 0;
            foreach (Branch b in this.branches)
            {
                int d = b.CalculateDepth();
                if (d > maxDepth)
                {
                    maxDepth = d;
                }
            }
            depth += maxDepth;
            return depth;
        }
    }
}
