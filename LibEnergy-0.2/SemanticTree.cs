using System;
using System.Collections.Generic;
using System.Text;

namespace Energy_cs
{
    namespace semanticTree
    {
        class SemanticTree
        {
            public class treeNode
            {
                public string data { get; set; }
                public List<treeNode> children;

                public treeNode(string data)
                { }

                public void addChild(treeNode n)
                {
                    children.Add(n);
                }
            }

            private treeNode root;

            public SemanticTree()
            {
                root.data = "root";
                
            }



        }
    }
}
