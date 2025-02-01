using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        private Node<T> headNode;
        private Node<T> tailNode;
        private int count;

        public Node<T> HeadNode => headNode;
        public Node<T> TailNode => tailNode;
        public int Count => count;
        public void AddFirst(T nodeData)
        {
            Node<T> node = new Node<T>(nodeData);
            node.NextNode = headNode;
            headNode = node;

            if (count == 0)
            {
                tailNode = headNode;
            }

            count++;
        }

        public void AddLast(T nodeData)
        {
            Node<T> node = new Node<T>(nodeData);
            if (count == 0)
            {
                headNode = node;
            }
            else
            {
                tailNode.NextNode = node;
            }
            tailNode = node;
            count++;
        }

        public void RemoveFirst()
        {
            if (count != 0)
            {
                headNode = headNode.NextNode;
                count--;
                if (count == 0)
                {
                    tailNode = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (count != 0)
            {
                if (count == 1)
                {
                    headNode = null;
                    tailNode = null;
                }
                else
                {
                    Node<T> current = headNode;
                    while (current.NextNode != tailNode)
                    {
                        current = current.NextNode;
                    }
                    current.NextNode = null;
                    tailNode = current;
                }
                count--;
            }
        }

        
    } // class ends here
}// namespace ends here
