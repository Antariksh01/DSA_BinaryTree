using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BinaryTree
{
    public class BinaryTree
    {
        int idx = -1;
        public Node? BuildTree(int[] nodes)
        {
            idx++;
            if (idx >= nodes.Length || nodes[idx] == -1)
            {
                return null;
            }

            Node newNode = new Node(nodes[idx]);
            newNode.leftNode = BuildTree(nodes);
            newNode.rightNode = BuildTree(nodes);

            return newNode;

        }
    }
}
