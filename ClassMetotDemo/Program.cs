namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Sena";
            customer1.Surname = "Karataş";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Serena";
            customer2.Surname = "Williams";

            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach(var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.DeleteCustomer(customer2);
        }
    }
}





    