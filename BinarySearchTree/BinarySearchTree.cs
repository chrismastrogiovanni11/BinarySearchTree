using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
   public class BinarySearchTree
    {
        
        public Node root;

        public Node temp;

        public BinarySearchTree()
        {
            root = null;
            temp = null;

            
        }

        public void Add(Node node)
        {

            if (root == null) 
            {
                root = node;
                return;
            }

            temp = root;

            while (true)
            {



                if (node.data <= temp.data)
                {
                    if (temp.left == null)
                    {
                        temp.left = node;
                        break;
                    }
                    else
                    {
                        temp = temp.left;
                    }

                }
                else
                {
                    if (temp.right == null)
                    {
                        temp.right = node;
                        break;
                    }
                    else
                    {
                        temp = temp.right;
                    }
                }
            }
        }

        public void Search(Node node)
        {

        }
    }

}
