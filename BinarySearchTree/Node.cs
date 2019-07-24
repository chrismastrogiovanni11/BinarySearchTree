using com.sun.source.tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {

        public int data;
        public Node left;
        public Node right;
        public Node temp;
        BinarySearchTree bts = new BinarySearchTree();


        public Node(int number)
        {
            data = number;

            
            
        }
        public void addLeft()
        {
            if (data <= temp.data)
            {
                left = temp.Add;
            }
        }

        public void addRight()
        {
            if (data >= temp.data)
            {
                right = temp.
            }
        }
    }

}

