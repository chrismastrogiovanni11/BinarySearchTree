using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarysearchtree = new BinarySearchTree();
            Node thing = new Node(93);
            Node thing2 = new Node(72);
            Node thing3 = new Node(111);
            binarysearchtree.Add(thing);
            binarysearchtree.Add(thing2);
            binarysearchtree.Add(thing3);
            binarysearchtree.Search(thing2);

        }
    }
}
