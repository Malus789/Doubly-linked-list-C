using System;

namespace Doubly_linked_list
{
    class Program
    {





        class Node
        {
            private int data;
            private Node next;
            private Node previous;

            public int Data
            {
                get { return data; }
                set { data = value; }
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node Previous
            {
                get { return previous; }
                set { previous = value; }
            }

        }

        class List
        {
            public Node head = new Node();
            public Node tail = new Node();

            public List()
            {
                head = null;
                tail = null;
            }

            public void insertNode()
            {
                Node newNode = new Node();
                Console.Write("Enter the data of the node: ");
                newNode.Data = int.Parse(Console.ReadLine());
                if (head == null) {
                    head = newNode;
                    head.Next = null;
                    head.Previous = null;
                    tail = newNode;

                } else {
                    tail.Next = newNode;
                    newNode.Next = null;
                    newNode.Previous = tail;
                    tail = newNode;
                }

            }

            public void searchNode()
            {
                Node current = new Node();
                current = head;
                Console.Write("What do you want to look for?: ");
                int NodeToFind = int.Parse(Console.ReadLine());
                bool IsFind = false;
                while (IsFind == false)
                {
                    

                    if (current.Data == NodeToFind)
                    {
                        Console.WriteLine("Wanted: " + NodeToFind + " Found: " + current.Data);
                        Console.WriteLine("found node: " + current);
                        IsFind = true;
                    }

                    
                    else
                    {                 
                        if (current.Next == null)
                        {
                            Console.WriteLine("i didn't find anything");
                            break;

                        }                    

                    }
                    current = current.Next;
                }        
            }

            public void DeleteNode()
            {
                Node current = new Node();
                current = head;
                Console.Write("What do you want to look for?: ");
                int NodeToFind = int.Parse(Console.ReadLine());
                bool IsFind = false;
                while (IsFind == false)
                {
                    if (current.Data == NodeToFind)
                    {
                        Console.WriteLine("Wanted: " + NodeToFind + " Found: " + current.Data);

                        if (NodeToFind == head.Data)
                        {
                            head = current.Next;
                            current.Next.Previous = head;
                            Console.WriteLine("deleted node: " + current);
                            break;
                        }
                        else if (NodeToFind == tail.Data)
                        {
                            tail.Previous.Next = null;
                            Console.WriteLine("deleted node: " + current);
                            break;

                        }
                        else if (NodeToFind == current.Data)
                        {
                            current.Previous.Next = current.Next;
                            current.Next.Previous = current.Previous;
                            Console.WriteLine("deleted node: " + current);
                            break;
                        }

                    }
                    else
                    {

                        if (current.Next == null)
                        {
                            Console.WriteLine("i didn't find anything");
                            break;
                        }       
                    }

                    current = current.Next;
                }
            }
            


            public void print()
            {
                Node current = new Node();
                current = head;
                while (current != null)
                {
                    Console.WriteLine("" + current.Data);
                    current = current.Next;
                }

            }


            public void printR()
            {
                Node current = new Node();
                current = tail;
                while (current != null)
                {
                    Console.WriteLine("" + current.Data);
                    current = current.Previous;
                }

            }
        }

    
    static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List lista = new List();

            lista.insertNode();
            lista.insertNode();
            lista.insertNode();
            lista.insertNode();
            Console.WriteLine("Nodes:");
            lista.print();

            Console.WriteLine( "This is the Head: "+lista.head.Data);
            Console.WriteLine("This is the Tail: " + lista.tail.Data);

            lista.searchNode();
            lista.DeleteNode();
            lista.print();
            /*
            Console.WriteLine("1º) New Node" + "n" + "2º) Search Node" + "n" + "3º) Deleted Node" + "n" + "4º) Print" + "n" + "5º) Reverse Print" + "n" + "6º Exit" + "n" );
            Console.Write("Choose one: ");

            switch (Console.Read())
            {
                case '1':
                    Console.Write("New Node..");
                    lista.insertNode();
                    break;
                case '2':
                    Console.Write("Search Node..");
                    lista.searchNode();
                    break;
                case '3':
                    Console.Write("Deleted Node..");
                    lista.DeleteNode();
                    break;
                case '4':
                    Console.Write("Print..");
                    lista.print();
                    break;
                case '5':
                    Console.Write("Reverse print..");
                    lista.printR();
                    break;
                case '6':
                    Console.Write("Salir");
                    
                    break;
            }
            Console.ReadKey();
*/
        }


    }




 
}

