using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node rootNode;

        public BinarySearchTree()
        {
            rootNode = null;
        }

        public void AddNode(Node nodeToAdd)
        {
            if (rootNode == null)
            {
                rootNode = nodeToAdd;
            }
            else
            {
                Node currentNode = rootNode;
                while (true)
                {
                    if (nodeToAdd.data < currentNode.data)
                    {
                        if (currentNode.leftNode == null)
                        {
                            currentNode.leftNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.leftNode;
                        }
                    }
                                                                //now can do the inverse with greater than/rightNode
                    else if(nodeToAdd.data > currentNode.data)
                    {
                        if (currentNode.rightNode == null)
                        {
                            currentNode.rightNode = nodeToAdd;
                            break;
                        }

                        else
                        {
                            currentNode = currentNode.rightNode;
                        }
                    }
                }
            }
        }

    }
}
