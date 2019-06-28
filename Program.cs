using System;

namespace Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit(Eyes.Blue, Fur.Brown, Gender.Male, new DateTime(1993 ,06, 02));
            Console.WriteLine(rabbit.BirthDate);
            
        }
    }
}
