using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maja
{
    class TransformNode : Nodes 
    {
        private static List<TransformNode> rootNodes;
        private static List<TransformNode> children;

        static TransformNode()
        {
            rootNodes = new List<TransformNode>();
        }
        public TransformNode() : this (
    }
}
