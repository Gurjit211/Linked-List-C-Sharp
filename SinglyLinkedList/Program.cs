using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
     class Program
    {
        static void Main()
        {
            SinglyLinkedList<int> myLL = new SinglyLinkedList<int>(); //here myLL means myLinkedList
            myLL.AddFirst(11);
            myLL.AddLast(06);
            myLL.AddFirst(93);
            myLL.RemoveLast();
            myLL.RemoveFirst();
            myLL.AddFirst(44);
            myLL.AddLast(295);
            myLL.AddLast(5911);
            myLL.AddFirst(47);
            myLL.AddFirst(26);
            myLL.RemoveLast();
   
            Node<int> current = myLL.HeadNode;
            while (current != null)
            {
                Console.WriteLine(current.NodeData);
                current = current.NextNode;
            }
            Console.ReadLine();
        }

    }
}
