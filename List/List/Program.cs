using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            const int size = 19;
            const int index = 4;
            int[] array = new int[size];
            array[index] = 32323;
            var arrayElement = array[index];
            //List
            List<int> list = new List<int>();//optional size
            list[index] = 32323;
            var listElement = list[index];
            //Stack
            Stack<int> stack = new Stack<int>();//optional size
            stack.Push(34344);
            var stackItem = stack.Pop();
            //Queue
            Queue<int> queue = new Queue<int>();//optional size
            queue.Enqueue(123123);
            var queueItem = queue.Dequeue();
            //Hashset
            HashSet<int> hashSet = new HashSet<int>();//optional size
            hashSet.Add(5);
            var containsInSet = hashSet.Contains(5);
            //Dictionary
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("vladAge", 23);
            var fromDict = dict["vladAge"];//23
            if(dict.TryGetValue("vladAge", out int vladAge))
            {
                //vlad age = 23
            }

        }
    }
}
