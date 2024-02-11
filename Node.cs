using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BinaryTree
{
    public class Node
    {
        public int? data;
        public Node? leftNode;
        public Node? rightNode;

        public Node(int data)
        {
            this.data = data;
            this.leftNode = null;
            this.rightNode = null;
        }
    }
}
