using static ImersãoBalta.Program;

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
            context.Save(Person);
            context.Save(Subcription);
        }

        public class DataContext<P, PA, S>
            where P : Person
            where PA : Payment
            where S : Subcription
        {
            public void Save(P entity)
            {
                
            }
            public void Save(PA entity)
            {

            }
            public void Save(S entity)
            {

            }
        }


        public class Person { }
        public class Payment { }
        public class Subcription { }
    }
}