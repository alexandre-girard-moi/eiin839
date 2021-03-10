using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServiceReference1;

namespace SOAP_WEB_SERVICE
{
    class Calculator : CalculatorSoap
    {
        public Task<int> AddAsync(int intA, int intB)
        {
            throw new NotImplementedException();
        }

        public Task<int> SubtractAsync(int intA, int intB)
        {
            throw new NotImplementedException();
        }

        public Task<int> MultiplyAsync(int intA, int intB)
        {
            throw new NotImplementedException();
        }

        public Task<int> DivideAsync(int intA, int intB)
        {
            throw new NotImplementedException();
        }
    }
}
