using static ImersãoBalta.Program;

namespace ImersãoBalta
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var payment = new Payment();
            var context = new DataContext<Payment>();
            context.Save(payment);
        }

        public class DataContext<T>
        {
            public void Save(T entity)
            {
            
            }
        }

        public class Person { }
        public class Payment { }
        public class Subcription { }
    }
}