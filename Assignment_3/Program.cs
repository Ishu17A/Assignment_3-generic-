using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{

    public class first <T>
    {
      public T value1;
      public first(T value)
      {
        this.value1 = value;
      }

    }

    public class second<T> : first<T>
    {
      public T value2;
      public second(T first, T second):base(first)
      {
        this.value2 = second;
       
      }
    }

    public class third<T> : second<T> 
    {
        public T value3;
        public third (T first, T second , T third) : base (first , second)
        {
          this.value3 = third;
        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            /* Assignment_3*/
            first<int> first = new first<int>(14);
            second<int> second = new second<int>(10 , 17);
            third<int> third = new third<int>(45, 54, 87);
            Console.WriteLine(first.value1);
            Console.WriteLine(second.value2);
            Console.WriteLine(third.value3);
            Console.ReadLine();


        }
    }
}
