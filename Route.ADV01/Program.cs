using Route.ADV01._2_GenericInterfaces;
// using Route.ADV01._3_GenericConstraint;
using Route.ADV01._3_InAndOutKeyword;
using Route.ADV01._4_DefaultKeyWord;
using Route.ADV01._5_StaticWIthGenerics;
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


            //int a = 10, b = 20;
            //Utility.Swap(ref a, ref b);

            //double c = 10.5, d = 12.5;
            //Utility.Swap(ref c, ref d);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);


            //int[] numbers = [10, 30, 100, 60];
            //Console.WriteLine(Utility.FindMaxValue(numbers));
            // //                        102      97    109    115
            //string[] names = ["fady", "ali", "mai", "sameh"];
            //Console.WriteLine(Utility.FindMaxValue(names));

            #endregion

            #region 04 - Generic Interfaces

            /*
             * Generic interfaces define a type-safe contract for any entity.
             * IRepository<TEntity> -- Repository Pattern used in Clean Architecture.
             *
             */


            //ProductRepository productRepository = new ProductRepository();

            //Product product01 = new Product(1, "Laptop", 100000);
            //Product product02 = new Product(2, "PC", 100000);
            //Product product03 = new Product(3, "IPhone", 200000);

            //productRepository.Create(product01);
            //productRepository.Create(product02);
            //productRepository.Create(product03);

            //List<Product> products = productRepository.GetAll();

            //foreach(Product product in products)
            //{
            //    Console.WriteLine(product.Name);
            //    Console.WriteLine(product.Price);
            //}


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

            //Container<int> intContainer = new Container<int>(100);
            //Container<string> StringContainer = new Container<string>("hamada");


            //// General Primary  // special primary
            //// 1. Primary Constraint (class? , struct?, specific class?) => 0 , 1
            //// 2. Scondary Constraint (Interface Constraint) => 0 ,,, 1 or Many
            //// 3. Constructor Constraint => 0, 1


            //NumericalHolder<int> intHolder = new();
            //NumericalHolder<double> doubleHolder = new();
            //NumericalHolder<string> doubleHolder = new();
            //NumericalHolder<Product> doubleHolder = new();

            //AnimalShelter<Cat> animalShelter = new AnimalShelter<Cat>();

            //animalShelter.Add(new Cat("C01"));
            //animalShelter.Add(new Cat("C02"));
            //animalShelter.Add(new Cat("C03"));

            //animalShelter.Display();


            //AnimalShelter<Product> animalShelter1


            //Product[] products = new Product[]
            //{
            //    new Product(1, "Laptop", 100000),
            //    new Product(2, "PC", 100)
            //};

            //Console.WriteLine(Utility.FindMaxValue(products));


            //Factory<Person> factory = new Factory<Person>();
            //Person result = factory.Create();
            //Console.WriteLine(result.Id);



            #endregion

            #region 06 - Default Keyword

            /*
             * default(T) -- or just `default` -- returns the zero value for T at runtime:
             *   Value types  : 0, false, 0.0, '\0', etc.
             *   Reference types : null
             *
             * Used inside generic code when a "no value" result is needed
             * without knowing at compile time whether T is a value or reference type.
             *
             * SafeList<T>.GetElementAt(index) returns default instead of throwing
             * IndexOutOfRangeException when the index is invalid.
             * Caller uses ?? to substitute a fallback for nullable reference types.
             */


            //SafeList<string> safeList = new SafeList<string>();

            //safeList.Add("Ali"); // 0
            //safeList.Add("Mohamed"); // 1
            //safeList.Add("Mai"); // 2

            //Console.WriteLine(safeList.GetElementAt(2));
            //Console.WriteLine(safeList.GetElementAt(-2));
            //Console.WriteLine(safeList.GetElementAt(100));


            #endregion

            #region 07 - in and out Keywords (Variance)

            /*
             * Variance: ability to substitute a more-derived or more-general type
             *           where the interface's type parameter is declared.
             * Applies ONLY to generic interfaces and delegates -- NOT classes.
             *
             * out T -- Covariance
             *   T allowed in OUTPUT positions only (return value, getter).
             *   If Cat IS-A Animal => IProducer<Cat> can be used as IProducer<Animal>.
             *   Safe: caller expects Animal, receives Cat -- always valid.
             *
             * in T -- Contravariance
             *   T allowed in INPUT positions only (method parameter, setter).
             *   If Animal is handled => IConsumer<Animal> can be used as IConsumer<Cat>.
             *   Safe: a handler for any Animal certainly handles a Cat.
             *
             * Without variance keywords the compiler rejects these assignments.
             */

            //// Contravariance [IN]: Input position only
            //// child => parent
            //AnimalShelter animalShelter = new AnimalShelter();
            //Console.WriteLine(animalShelter.GetAnimal().Name);

            //// compilation time
            //IShelter<Cat> catShelter = new AnimalShelter();
            ////Cat cat = catShelter.GetAnimal(); // dog
            //catShelter.TreatAnimal(new Cat("C01"));

            // child => parent [ input position] => parameter, setter
            //IConsumer<Dog> consumer = new AnimalConsumer();
            //Dog dong = consumer.Print();

            //consumer.Consume(Cat("C01"));


            // Covariance [OUT]: 

            //CatShelter catShelter = new CatShelter();
            //IShelter<Animal> animalShelter = catShelter;

            //AnimalShelter catShelter = new AnimalShelter();

            // parent => child [output] return value from method, getter
            //IShelter<Animal> animalShelter = new AnimalShelter();

            ////animalShelter.TreatAnimal(new Dog("C01"));
            ///

            // Covariance 
            //IProducer<Animal> producer = new DogProducer();
            //producer.Print(new Cat("C01"));





            #endregion

            #region 08 - Static Members and Inheritance in Generics

            /*
             * Static members in generic classes:
             *   Each CLOSED type (Counter<int>, Counter<string>) owns its own static field.
             *   They DO NOT share a single counter -- this is different from ordinary classes.
             *
             * Inheritance patterns:
             *   1. Open  : class MyChildList<T> : MyList<T>     -- T passed through unchanged
             *   2. Closed: class IntList : MyList<int>           -- T fixed at int
             *   3. Mixed : class HalfList<T2> : MyPair<int, T2> -- one parameter fixed
             *
             *   Pattern 1 (open) is shown here: MyChildList<T> extends MyList<T>.
             */

            //Counter<int>.Increment();
            //Counter<int>.Increment();
            //Counter<int>.Increment();

            //Console.WriteLine(Counter<int>.Count); //3

            //Counter<string>.Increment();
            //Counter<string>.Increment();
            //Counter<string>.Increment();
            //Console.WriteLine(Counter<string>.Count); //3

            //Counter<double>.Increment();
            //Counter<double>.Increment();
            //Counter<double>.Increment();
            //Console.WriteLine(Counter<double>.Count); //3

            //Counter<int>.Increment();
            //Counter<int>.Increment();
            //Counter<int>.Increment();

            //Console.WriteLine(Counter<int>.Count); //6


           #endregion

        }

    }
}
