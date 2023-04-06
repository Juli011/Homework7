
using static Thread1.Method;

namespace Thread1
{
    class Program
    {

        static void Main()
        {
            
            Method method1 = new Method(100000,0,50000);
            Method method2 = new Method(100000, 50000, 100000);
            
            var meth1 = new IntRoot(method1.intRootMethod);
            var meth2 = new IntRoot(method2.intRootMethod);

            //ParameterizedThreadStart intRoots2 = new(meth2);
            //ParameterizedThreadStart intRoots1 = new(meth1);

            //Thread thread1 = new Thread(intRoots1);
           // Thread thread2 = new Thread(intRoots2);

            Thread thread1 = new Thread(meth1);
            Thread thread2 = new Thread(meth2);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join(); 

            Console.WriteLine("Числа, що мають цілий корінь - "+string.Join(",", Method.intRoots));

        }
    }
}



