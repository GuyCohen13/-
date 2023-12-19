using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using מבחן_גיא_כהן;

namespace מבחן_גיא_כהן
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> head = new Node<int>(2);
            Node<int> node2 = new Node<int>(5);
            Node<int> node3 = new Node<int>(2);
            Node<int> node4 = new Node<int>(5);
            Node<int> node5 = new Node<int>(2);
            Node<int> node6 = new Node<int>(5);

            head.SetNext(node2);
            node2.SetNext(node3);
            node3.SetNext(node4);
            node4.SetNext(node5);
            node5.SetNext(node6);

            bool gig = RoyalLst(head);
            Console.WriteLine(gig);
        }

        public static bool RoyalLst(Node<int> head)
        {
            if (head != null)
            {
                int len = 0;
                int dig1, dig2;

                Node<int> initialHead = head;

                dig1 = initialHead.GetValue();
                dig2 = initialHead.GetNext().GetValue();

                // Calculate the length
                while (head != null)
                {
                    len++;
                    head = head.GetNext();
                }

                if (len % 2 == 0)
                {
                    int checks = 0;
                    head = initialHead;

                    for (int i = 0; i < len / 2; i++)
                    {
                        if (dig1 == head.GetValue() && dig2 == (head.GetNext().GetValue()))
                        {
                            head = head.GetNext()?.GetNext();
                            checks++;
                        }
                    }

                    return checks == len / 2;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}