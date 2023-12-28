//using static ImersãoBalta.Program;

//namespace ImersãoBalta
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            var payments = new List<Payment>();
//            payments.Add(new Payment(1));
//            payments.Add(new Payment(2));
//            payments.Add(new Payment(3));
//            payments.Add(new Payment(4));
//            payments.Add(new Payment(5));

//            payments.AsEnumerable(); // o converte para IEnumerable
//            payments.ToList(); // o converte o IEnumerable Para uma lista caso se seja IEnum
//            payments.ToArray(); // o converte para Array

//            var paidPayments = new List<Payment>();
//            paidPayments.AddRange(payments);

//            var payment = payments.Where(x => x.Id == 2).FirstOrDefault();
//            Console.WriteLine(payment.Id);

//            //foreach(var item in payments)
//            //{
//            //   Console.WriteLine(item.Id);                
//            //}

//            //foreach (var item in payments.Where(x => x.Id == 2))
//            //{
//            //    Console.WriteLine(item);
//            //}
//        }

//        public class Payment
//        {
//            public int Id { get; set; }

//            public Payment(int id)
//            {
//                Id = id;
//            }
//        }
//    }
//}