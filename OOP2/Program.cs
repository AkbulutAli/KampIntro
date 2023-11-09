namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Engin Demiroğ
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.TcNumber = "1234567890";
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";

            //Kodlama.io

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.TaxNumber = "1234567890";
            customer2.CampanyName = "Kodlama.io";

            Customer customer3 = new CoorporateCustomer();
            Customer customer4 = new IndividualCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}