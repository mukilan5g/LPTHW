using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace stack
{
    public class stackExercise 
    {
        string[] elements;
        int state;
        public stackExercise()
        {
            elements = new string[10];
            state = -1;
        }
        public void push(string name)
        {
            try
            {
                if (name != null)
                {
                    if (state < elements.Length)
                    {
                        if (isEmpty() == true)
                        {
                            state++;
                            elements[state] = name;
                        }
                        else
                        {
                            elements[state] = name;
                        }

                    }
                    else
                    {
                        throw new StackOverflowException();
                    }
                }
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string pop()
        {
            try
            {
                if (isEmpty() == false)
                {
                    
                    return elements[state--];
                }
                else
                {
                    throw new InsufficientExecutionStackException("StackEmpty");
                }
            }
            catch (InsufficientExecutionStackException e)
            {
                return e.Message;
            }


        }

        public string top()
        {
            try
            {
                if (isEmpty() == false)
                {
                    return elements[state];
                }
                else
                {
                    throw new InsufficientExecutionStackException("StackEmpty");
                }
            }
            catch (InsufficientExecutionStackException e)
            {
                return e.Message;
            }
        }
        public bool isEmpty()
        {
            if (state == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
