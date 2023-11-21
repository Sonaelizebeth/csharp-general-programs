using System;
using System.Dynamic;

namespace MyApp{
    class Node{
        public int data{get; set;}
        public Node? next{get; set;}
        public Node(int data){
            this.data=data;
            next=null;
        }
    }
    
    class LinkedList{
        public Node? head;
        public void Add(int data){
            Node? node = new Node(data);
            if(head==null)
                head=node;
            else{
                Node temp=head;
                while(temp.next!=null)
                {
                    temp=temp.next;
                }
                temp.next=node;
            }
            Console.WriteLine("{0} is inserted",node.data);
        }
        public void Display(){
        Node? temp = head;
        if(temp==null){
            Console.WriteLine("List is empty");
            return;
        }
        while(temp!=null){
            Console.WriteLine(temp.data+"");
            temp=temp.next;

        }

        }

    }
    class Stack{
       public Node top;
       public void Push(int data){
         Node node = new Node(data);
         node.next=top;
         top=node;
       }
       public int Pop(){
         if(IsEmpty()){
            Console.WriteLine("Stack is empty");
         }
         int data =top.data;
         top=top.next;
         return data;
       }
       public int Peek(){
         if(IsEmpty()){
            Console.WriteLine("Stack is empty");
         }
         return top.data;
       }
       public bool IsEmpty(){
         return top==null;
       }
       public void sdisplay(){
         Node temp=top;
         Console.WriteLine("Stack elements:");
         while(temp!=null){
            Console.WriteLine(temp.data);
            temp=temp.next;
         }
       }
        
    }
    
    class Program{
        static void Main(string[] args){
           
            LinkedList list1 = new LinkedList();
            Stack stack = new Stack();
            try
            {
                Console.WriteLine("Enter the number of numbers:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the numbers:");
                for (int i = 1; i <= n; i++)
                {
                    int m = Convert.ToInt32(Console.ReadLine());
                    list1.Add(m);
                }
                Console.WriteLine("Linked list data:");
                list1.Display();

                Node? temp = list1.head;
                while (temp != null)
                {
                    stack.Push(temp.data);
                    temp = temp.next;
                }

                stack.sdisplay();
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = stack.Pop();
                }
                Console.WriteLine("Reversed elements are :");
                foreach (int e in arr)
                {
                    Console.WriteLine(e);
                }

                Console.WriteLine("Enter element to search:");
                int element = Convert.ToInt32(Console.ReadLine());
                int index = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == element)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    Console.WriteLine($"Element{element} found at {index}");
                }
                else
                {
                    Console.WriteLine($"Element {element} not found");
                }

            }
            catch(FormatException){
                Console.WriteLine("Invalid Input Format");

            }



        }
    }
}
