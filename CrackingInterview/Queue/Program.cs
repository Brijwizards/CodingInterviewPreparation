using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            MovingAverage movingAverage = new MovingAverage(3);
            movingAverage.Next(1);
            movingAverage.Next(10);
            movingAverage.Next(3);
            movingAverage.Next(5);

            #region Queue
            Queue queue = new Queue(5);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.PrintQueue();
            queue.Dequeue();
            #endregion

            #region Circular Queue
         
            //Your MyCircularQueue object will be instantiated and called as such:
            MyCircularQueue obj = new MyCircularQueue(5);
            bool param_1 = obj.EnQueue(2);
            bool param_2 = obj.DeQueue();
            int param_3 = obj.Front();
            int param_4 = obj.Rear();
            bool param_5 = obj.IsEmpty();
            bool param_6 = obj.IsFull();

            #endregion
        }
    }

    public class Queue
    {
        public int[] queue;
        public int front;
        public int rear;
        public int max;

        public Queue(int size)
        {
            queue = new int[size];
            front = 0;
            max = size;
            rear = -1;
        }

        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue overflows.");
                return;
            }
            queue[++rear] = item;
        }

        public int Dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue empty.");
                return -1;
            }
            int p = queue[front++];
            return p;
        }

        public void PrintQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue empty.");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(queue[i]);
                }
            }
        }
    }

    public class MyCircularQueue
    {
        private int[] nums;
        private int front;
        private int rear;
        private int len;
        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            nums = new int[k];
            len = 0;
            rear = -1;
            front = 0;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }
            rear = (rear + 1) % nums.Length;
            nums[rear] = value;
            len++;
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            front = (front + 1) % nums.Length;
            len--;
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return nums[front];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return nums[rear];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return len == 0;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return len == nums.Length;
        }
    }

    public class MovingAverage
    {

        /** Initialize your data structure here. */
        double sum;
        Queue<int> queue = new Queue<int>();
        int count;
        public MovingAverage(int size)
        {
            sum = 0.0d;
            count = size;
        }

        public double Next(int val)
        {
            if (queue.Count == count)
            {
                sum = sum - queue.Dequeue() + val;
            }
            else
            {
                sum = sum + val;
            }
            queue.Enqueue(val);
            return sum / queue.Count;
        }
    }
}
