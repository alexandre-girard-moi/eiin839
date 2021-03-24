using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathsLibrary
{
        public class MathsOperations : IMathsOperations
    {

        public int Add(int nb1, int nb2)
        {
            return nb1 + nb2;
        }

        public int Multiply(int nb1, int nb2)
        {
            return nb1 * nb2;
        }

        public int Substract(int nb1, int nb2)
        {
            return nb1 - nb2;
        }

        public double divide(double nb1, double nb2)
        {
            return nb1 / nb2;
        }
    }
}
