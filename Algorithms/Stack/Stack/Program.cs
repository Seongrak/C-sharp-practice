using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack theStack = new Stack(4);
            theStack.push("Star Wars");
            theStack.push("Jaws");
            theStack.push("Jaws 2");
            theStack.push("Titanic");
            theStack.push("Rocky");
            

            WriteLine("===================== \n About to peek:\n");
            WriteLine("'" + theStack.peek() + "'" + " is at the top of the stock.\n");

            WriteLine("===================== \n The Stack Contains:\n");
            while(!theStack.isEmpty())
            {
                string movie = theStack.pop();
                WriteLine(movie);
            }

            ReadLine();
        }
    }

    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void push(string m)
        {
            if (isFull())
            {
                WriteLine("This stack is full");
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }

        public string pop()
        {
            if(isEmpty())
            {
                WriteLine("The stack is empty.");
                return "--";
            }
            else
            {
                int old_top = top;
                top--;
                return stackArray[old_top];
            }
        }
        
        public string peek()
        {
            return stackArray[top];
        }

        private bool isFull()
        {
            return (maxSize - 1 == top);
        }

        public bool isEmpty()
        {
            return (top == -1);
        }
    }
}
