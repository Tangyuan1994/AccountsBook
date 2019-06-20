using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpHomework1
{
    public class AccountItem
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Content { get; set; }
        public string Note { get; set; }
        public Money Amount { get; set; }
        public DateTime OccuredTime { get; set; }

        public AccountItem(string name,Category category,string content,string note, Money amount, DateTime occuredTime)
        {
            this.Name = name;
            this.Category = category;
            this.Content = content;
            this.Note = note;
            this.Amount = amount;
            this.OccuredTime = occuredTime;
        }

        public override string ToString()
        {
            string printResult = $"Name: {this.Name}\n" +
                                 $"Category: {this.Category.ToString()}\n" +
                                 $" Content: {this.Content}\n" +
                                 $"Note: {this.Note}\n" +
                                 $"Amount: {this.Amount.FaceValue} {this.Amount.Currency}\n" +
                                 $"OccuredTime:{ this.OccuredTime.ToString("MMMM dd, yyyy")}\n";
            return printResult;
        }
    }

    public enum Category
    {
        Spending=0,
        Income=1
    }
}
