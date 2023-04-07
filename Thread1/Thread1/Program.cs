
namespace Thread1
{
    class Params
    {
        public int From { get; set; }
        public int To { get; set; }
    }
    class Program
    {

        static void Main()
        {
            int[] array = new int[100000];
            for (int i = 0; i<100000; i++)
            {
                array[i] = i;
            }
            List<int> result = new List<int>();

            var t1 = new Thread(p =>
            {
                if (p==null) return;

                var par = (Params)p;
                intRootMeth(par, array, result);
            });
            var t2 = new Thread(p =>
            {
                if (p==null) return;

                var par = (Params)p;
                intRootMeth(par, array, result);
            });

            var par1 = new Params()
            {
                From=0,
                To = 50000
            };
            var par2 = new Params()
            {
                From=50000,
                To = 100000
            };
            static void intRootMeth(Params p, int[] array, List<int> result)
            {
                for (int i = p.From; i<p.To; i++)
                {
                    if (Math.Sqrt(array[i])%1==0)
                    {
                        result.Add(array[i]);
                    }

                }
            }
            t1.Start(par1);
            t2.Start(par2);

            t1.Join();
            t2.Join();

            Console.WriteLine("Числа, що мають цілий корінь - "+string.Join(",", result));

        }
    }
}



