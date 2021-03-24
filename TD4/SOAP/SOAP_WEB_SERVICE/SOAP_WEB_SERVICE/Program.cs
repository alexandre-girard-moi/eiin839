using System;
using ServiceReference1;

namespace SOAP_WEB_SERVICE
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsOperationsClient maths = new MathsOperationsClient();
            int a = maths.AddAsync(1, 10).Result;
            Console.WriteLine("Hello World! " +  a);
        }
    }
}
