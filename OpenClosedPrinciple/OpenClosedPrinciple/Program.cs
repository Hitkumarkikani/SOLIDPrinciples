using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment Rs:- {amount}");
        }
    }

    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment Rs:- {amount}");
        }
    }

    public class BankTransferPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing bank transfer payment Rs:- {amount}");
        }
    }

    public class PaymentProcessor
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void MakePayment(decimal amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 :- Open - Closed Principle :->");
            Console.WriteLine("");

            Console.WriteLine("Payment Processing System :->");
            Console.WriteLine("");

            IPaymentMethod creditCardPayment = new CreditCardPayment();
            PaymentProcessor creditCardProcessor = new PaymentProcessor(creditCardPayment);
            creditCardProcessor.MakePayment(1000);
            
            IPaymentMethod payPalPayment = new PayPalPayment();
            PaymentProcessor payPalProcessor = new PaymentProcessor(payPalPayment);
            payPalProcessor.MakePayment(200);
           
            IPaymentMethod bankTransferPayment = new BankTransferPayment();
            PaymentProcessor bankTransferProcessor = new PaymentProcessor(bankTransferPayment);
            bankTransferProcessor.MakePayment(5000);
            Console.WriteLine("");
        }
    }
}