using Route.ADV01.Generics;

namespace Demo06Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 01 - Generic Classes

            /*
             * Problem: without generics you write one class per type (BoxInt, BoxString, ...).
             * Generic class: declare T as a placeholder resolved at compile time.
             * Each closing (Box<int>, Box<string>) is compiled as a separate type.
             *
             * Naming conventions: T (single), T1/T2 (multiple), TKey/TValue, TEntity, TResult.
             *
             */

            //Box<int> box = new Box<int>(10);
            //Console.WriteLine(box.Value);

            //Box<string> stringBox = new Box<string>("Rawan");
            //stringBox.PrintOld(10);
            //stringBox.PrintOld("Rawan");


            //MyStack<int> stackOfInts = new(5);
            //stackOfInts.Push(1);
            //stackOfInts.Push(2);
            //stackOfInts.Push(3);
            //stackOfInts.Push(4);

            //Console.WriteLine(stackOfInts.Count);


            //MyStack<string> myStackOfString = new(3);
            //myStackOfString.Push("Ali");
            //myStackOfString.Push("Ahmed");
            //myStackOfString.Push("Rana");

            //Console.WriteLine(myStackOfString.Count);
            //Console.WriteLine(myStackOfString.Peek());

            //Console.WriteLine("After removing the last element");

            //Console.WriteLine(myStackOfString.Pop());
            //Console.WriteLine(myStackOfString.Peek());
            //Console.WriteLine(myStackOfString.Count);







            #endregion

            #region 02 - Generic Multiple Type Parameters

            /*
             * A generic class can declare more than one type parameter.
             * T1 and T2 are independent -- can be the same type or different types.
             */


            //EmployeePair<string, int> firstPair = new("Rawan", 20);
            //Console.WriteLine(firstPair);

            //EmployeePair<string, string> secondPair = new("Rawan", "Ahmed");
            //Console.WriteLine(secondPair);

            //EmployeePair<string, string> thirdPair = new("Rawan", "Tare");


            EmployeeTriple<int, string, double, DateTime> employee = new(10, "Ali", 3000, DateTime.Now);
            Console.WriteLine(employee.Fourth);



            #endregion

            #region 03 - Generic Methods

            /*
             * Generic methods: the type parameter belongs to the method, not the class.
             * The enclosing class does NOT need to be generic.
             * Type inference: compiler deduces T from arguments -- Swap(ref x, ref y) not Swap<int>(...).
             *
             * Constraints on methods work the same as on classes (where T : ...).
             */

            // Swap integers


            #endregion

            #region 04 - Generic Interfaces

            /*
             * Generic interfaces define a type-safe contract for any entity.
             * IRepository<TEntity> -- Repository Pattern used in Clean Architecture.
             *
             */



            #endregion

            #region 05 - Generic Constraints

            /*
             * Constraints restrict which types T can represent and unlock members inside the class.
             *
             * Three kinds (must appear in this order when combined):
             *   1. Primary constraint  (0..1)
             *      General : where T : class   or   where T : struct
             *      Special : where T : Animal  (T must be Animal or subclass)
             *
             *   2. Secondary constraint (0..many) -- interface constraints
             *      where T : IComparable<T>, ICloneable
             *
             *   3. Constructor constraint (0..1)
             *      where T : new()  -- T must have a public parameterless constructor
             *
             */


            #endregion
        }
    }
}
