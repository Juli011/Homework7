using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Thread1
{
    public class Method
    {
        public static List<int> intRoots = new List<int>();
        public delegate void IntRoot(object c);
        
        int a = 0;
        int b = 0;

        int[] array = new int[100000];
        private int amount = 0;
        public void createArray()
        {
            for (int i = 0; i<amount; i++)
            {
                array[i] = i;
            }
        }

        public Method(int amount, int a, int b)
        {
            this.amount = amount;
            this.a = a;
            this.b = b;
            createArray();
        }
        public void intRootMethod(object c)
        {
            for (int i = a; i<b; i++)
            {
                if (Math.Sqrt(array[i])%1==0)
                {
                    intRoots.Add(array[i]);
                }

            }
        }

    }
}
