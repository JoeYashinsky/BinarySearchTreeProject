﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node leftNode;
        public Node rightNode;

        public Node(int data)
        {
            this.data = data;
            leftNode = null;
            rightNode = null;
        }

    }
}
