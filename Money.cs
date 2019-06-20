using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpHomework1
{
    public class Money
    {

        public double FaceValue { get; set; }
        public Currency Currency;

        public Money()
        {
            this.FaceValue = 0;
            this.Currency = Currency.RMB;
        }

        public Money(double faceValue)
        {
            this.FaceValue = faceValue;
            this.Currency = Currency.RMB;
        }

        public Money(double faceValue, Currency currency)
        {
            this.FaceValue = faceValue;
            this.Currency = currency;
        }

        public static Money operator +(Money money1, Money money2)
        {
            return new Money(money1.FaceValue + money2.FaceValue,money1.Currency);
        }

        public static Money operator -(Money money1, Money money2)
        {
            return new Money(money1.FaceValue - money2.FaceValue, money1.Currency);
        }

     
    }

    public enum Currency
    {
        RMB = 0,
        USD = 1,
        EUR = 2,
    }
}
