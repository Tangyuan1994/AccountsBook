using System;

namespace CSharpHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts accounts = new Accounts();
            AccountItem accountItem1 =
                new AccountItem("Food", Category.Spending, "cake", "For birthday", new Money(100, Currency.USD), new DateTime(2019, 5, 20));
            AccountItem accountItem2 =
                new AccountItem("Salary", Category.Income, "Salary", "June Income", new Money(50000, Currency.USD), new DateTime(2019, 6, 20));
            AccountItem accountItem3 =
                new AccountItem("Home Rent", Category.Spending, "Home Rent", "For June", new Money(3500, Currency.USD), new DateTime(2019, 6, 20));
            AccountItem accountItem4 =
                new AccountItem("Cloth", Category.Spending, "T-Shirts", "pink", new Money(100, Currency.USD), new DateTime(2019, 6, 10));
            accounts.AddItem(accountItem1);
            accounts.AddItem(accountItem2);
            accounts.AddItem(accountItem3);
            accounts.AddItem(accountItem4);
            string totalRevenue = accounts.DisplayTotalRevenue(new DateTime(2019, 6, 10));
            Console.WriteLine(totalRevenue);
            foreach (var item in accounts.DisplayAll(new DateTime(2019, 6, 10)))
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
