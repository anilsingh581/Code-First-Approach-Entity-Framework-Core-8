using CodeFirstApproach.DatabaseContext;
using CodeFirstApproach.Entities;

namespace CodeFirstApproach
{
    public class TestCFA
    {
        public static void TestDB()
        {
            var context = new DatabaseContext.DatabaseContext();
            context.Database.EnsureDeleted();//Deleted databse at start point if it exists (This is Optional)
            context.Database.EnsureCreated();//Ensuring new database is Created if not exists


            List<Customer> customers = new List<Customer>()
            {
                new Customer
                {
                    Name= "Anil",
                    Age=40
                },
                new Customer
                {
                    Name= "Reena",
                    Age=35
                }
            };
            context.Customers.AddRange(customers);

            List<Item> items = new List<Item>()
            {
                new Item
                {
                    Name = "TShirt",
                    Price=350,
                    Quantity=2
                }
            };

            context.Items.AddRange(items);

            context.SaveChanges();


        }
    }
}
