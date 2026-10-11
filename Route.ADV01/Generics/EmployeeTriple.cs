using System;
using System.Collections.Generic;
using System.Text;

namespace Route.ADV01.Generics
{
    internal class EmployeeTriple<T1, T2, T3, T4>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
        public T3 Third { get; set; }
        public T4 Fourth { get; set; }

        public EmployeeTriple(T1 first, T2 second, T3 third, T4 fourth )
        {
            First = first;
            Second = second;
            Third = third;
        }
    }
}
