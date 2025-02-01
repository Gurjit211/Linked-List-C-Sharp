using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class Node<T>
    {
        public Node<T> NextNode { get; set; }
        public T NodeData { get; set; }

        public Node(T data)
        {
            NodeData = data;
            NextNode = null;
        }
    }
}
