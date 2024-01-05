using System;
using System.Collections.Generic;

namespace ImersãoBalta
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var payment = new Payment();
            var subcription = new Subcription();
            var context = new DataContext<Person, Payment, Subcription>();

            context.Save(payment);
            context.Save(person);
            context.Save(subcription);

            var payments = new List<Payment>
            {
                new Payment(),
                new Payment(),
                new Payment()
            };

        }

        public class DataContext<P, PA, S>
            where P : Person
            where PA : Payment
            where S : Subcription
        {
            public void Save(P entity)
            {
                Console.WriteLine($"Salvando {typeof(P).Name}");
            }

            public void Save(PA entity)
            {
                Console.WriteLine($"Salvando {typeof(PA).Name}");
            }

            public void Save(S entity)
            {
                Console.WriteLine($"Salvando {typeof(S).Name}");
            }
        }

        public class Payment
        {
           
        }
        public class Person { }
        public class Subcription { }

    }
}