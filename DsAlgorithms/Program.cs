using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void PirntArray(List<int> enu )
        {
            for (int i = 0; i < enu.Count; i++)
            {
                if (i != 0)
                {
                    Console.Write(",");
                }
                Console.Write(enu[i]);
            }
        }

        public static void CompareArrayAndLists()
        {
            int cap = 1015000;
            int insertCap = 14500;
            int intCap = 1000000;
            List<int> list = new List<int>(cap);
            int[] arr = new int[cap];

            Console.WriteLine("Time Before populating into Array: " + DateTime.Now.ToString());
            var beforeTime = DateTime.Now;
            for (int i = 0; i < intCap; i++)
            {
                arr[i] = i + 1;
            }
            var diff = DateTime.Now - beforeTime;
            Console.WriteLine("Took " + diff.TotalMilliseconds);
            Console.WriteLine("Time After populating into Array: " + DateTime.Now.ToString());
            //Console.WriteLine("Array:");
            //PirntArray(arr.ToList());


            Console.WriteLine("Time Before populating into List: " + DateTime.Now.ToString());
            beforeTime = DateTime.Now;
            for (int i = 0; i < intCap; i++)
            {
                list.Add(i + 1);
            }
            diff = DateTime.Now - beforeTime;
            Console.WriteLine("Took " + diff.TotalMilliseconds);
            Console.WriteLine("Time After populating into List: " + DateTime.Now.ToString());
            //Console.WriteLine("List:");
            //PirntArray(list);

            var randomarr = new int[insertCap];
            var ran = new Random();
            for (int i = 0; i < insertCap; i++)
            {
                randomarr[i] = ran.Next(100000);
            }

            Console.WriteLine("Time Before Inserting into Array: " + DateTime.Now.ToString());
            beforeTime = DateTime.Now;
            for (int i = 0; i < insertCap; i++)
            {
                var val = ran.Next(200000, 300000);
                //Console.WriteLine("Inserting "+ val + " into Array at index:" + randomarr[i] +  " at" + DateTime.Now.ToString());
                var temp = arr[randomarr[i]]; ;

                for (int k = randomarr[i]; k < arr.Length; k++)
                {
                    temp = arr[k];
                    arr[k] = val;
                    val = temp;
                }
            }
            diff = DateTime.Now - beforeTime;
            Console.WriteLine("Took " + diff.TotalMilliseconds);
            Console.WriteLine("Time After Inserting into Array: " + DateTime.Now.ToString());
            //Console.WriteLine("Array:");
            //PirntArray(arr.ToList());

            Console.WriteLine("Time Before Inserting into List: " + DateTime.Now.ToString());
            beforeTime = DateTime.Now;
            for (int i = 0; i < insertCap; i++)
            {
                var val = ran.Next(200000, 300000);
                //Console.WriteLine("Inserting "+ val+" into List at index:" + randomarr[i] + " at" + DateTime.Now.ToString());
                list.Insert(randomarr[i], val);
            }
            diff = DateTime.Now - beforeTime;
            Console.WriteLine("Took " + diff.TotalMilliseconds);
            Console.WriteLine("Time After Inserting into List: " + DateTime.Now.ToString());
            //Console.WriteLine("List:");
            //PirntArray(list);


            Console.WriteLine("Time Before Reading Array: " + DateTime.Now.ToString());
            beforeTime = DateTime.Now;
            var num = 0;
            for (int i = 0; i < insertCap; i++)
            {
                num = arr[randomarr[i]];
            }
            diff = DateTime.Now - beforeTime;
            Console.WriteLine("Took " + diff.TotalMilliseconds);
            Console.WriteLine("Time After Reading Array: " + DateTime.Now.ToString());


            Console.WriteLine("Time Before populating into List: " + DateTime.Now.ToString());
            beforeTime = DateTime.Now;
            for (int i = 0; i < insertCap; i++)
            {
                num = list[randomarr[i]];
            }
            diff = DateTime.Now - beforeTime;
            Console.WriteLine("Took " + diff.TotalMilliseconds);
            Console.WriteLine("Time After populating into List: " + DateTime.Now.ToString());

            Console.ReadLine();
        }
    }
}
