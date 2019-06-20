using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpHomework1
{
    public class Accounts
    {
        private List<AccountItem> _account =new List<AccountItem>();

        public void AddItem(AccountItem accountItem)
        {
            _account.Add(accountItem);
        }

        public Money TotalRevenue(DateTime datetime)
        {
            Money totalRevenue = new Money(0, _account[0].Amount.Currency);
            foreach (AccountItem item in _account)
            {
                if (item.OccuredTime.Month == datetime.Month)
                {
                    if (item.Category == Category.Income)
                    {
                        totalRevenue += item.Amount;
                    }
                    else
                    {
                        totalRevenue -= item.Amount;
                    }
                }
            }

            return totalRevenue;
        }

        public Money TotalExpenditure(DateTime datetime)
        {
            Money totalExpenditure = new Money(0, _account[0].Amount.Currency);
            foreach (AccountItem item in _account)
            {
                if (item.OccuredTime.Month == datetime.Month)
                {
                    if (item.Category == Category.Spending)
                    {
                        totalExpenditure += item.Amount;
                    }
                }
            }
            return totalExpenditure;
        }

        public Money TotalIncome(DateTime datetime)
        {
            Money totalIncome = new Money(0, _account[0].Amount.Currency);
            foreach (AccountItem item in _account)
            {
                if (item.OccuredTime.Month == datetime.Month)
                {
                    if (item.Category == Category.Income)
                    {
                        totalIncome += item.Amount;
                    }
                }
            }
            return totalIncome;
        }

        public string DisplayTotalRevenue(DateTime datetime)
        {

            string printResult =$"Month: {datetime.Month}\n"+
                                    $"TotalRevenue: {this.TotalRevenue(datetime).FaceValue} " + $"{this.TotalIncome(datetime).Currency}\n" +
                                     $"TotalExpenditure: {this.TotalExpenditure(datetime).FaceValue} " + $"{this.TotalIncome(datetime).Currency}\n" +
                                     $"TotalIncome: {this.TotalIncome(datetime).FaceValue} "+$"{this.TotalIncome(datetime).Currency}\n";
            return printResult;
        }

        public IEnumerable<AccountItem> DisplayAll(DateTime dateTime)
        {
            foreach (AccountItem item in _account)
            {
                if (item.OccuredTime.Month== dateTime.Month)
                {
                    yield return item;
                }
            }
        }
    }
}
