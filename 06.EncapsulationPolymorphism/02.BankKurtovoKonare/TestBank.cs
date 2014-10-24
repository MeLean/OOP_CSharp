namespace _02.KurtovoKonareBank
{
    using System;

    public class TestBank
    {
        public static void Main()
        {
            Individual Pesho = new Individual("Pesho");
            Mortgage PeshoMortgage = new Mortgage(Pesho, 1000m, 1.7m);
            Console.WriteLine(PeshoMortgage);
            PrintDeptor(PeshoMortgage, 8);
            
            PeshoMortgage.MakeDeposit(100);
            Console.WriteLine("After deposit of {0:C2}", 100);
            PrintDeptor(PeshoMortgage, 7);
        
            Company GoshoSoft = new Company("Gosho Soft Industies");
            Loan GoshoSoftLoan = new Loan(GoshoSoft, 20000m, 0.5m);
            Console.WriteLine(GoshoSoftLoan);
            PrintDeptor(GoshoSoftLoan, 13);

            GoshoSoftLoan.MakeDeposit(100);
            Console.WriteLine("After deposit of {0:C2}", 100);
            PrintDeptor(GoshoSoftLoan, 12);

            Individual milen = new Individual("Milen");
            Deposit MilenDeposit = new Deposit(milen, 2000m, 0.3m);
            Console.WriteLine(MilenDeposit);
            PrintDeptor(MilenDeposit, 12);
            Console.WriteLine("After deposit of {0:C2} and withdraw {1:C2}", 100, 2000);
            MilenDeposit.MakeDeposit(100);
            MilenDeposit.Withdraw(2000);
            PrintDeptor(MilenDeposit, 10);
            PrintDeptor(MilenDeposit, 12);
        }

        private static void PrintDeptor(Account deptorAccount, int months)
        {
            string hoMustPay = "myst pay";
            string forOrAfter = "for";

            if (deptorAccount.GetType().Name.Equals("Deposit"))
            {
                hoMustPay = "will have";
                forOrAfter = "after";
            }
            
            Console.WriteLine(string.Format("{0} {1} {2:C2} {3} {4} moths.",
                deptorAccount.Customer.CustomerName,
                hoMustPay,
                deptorAccount.CalculateInterestInMonths(months),
                forOrAfter,
                months));
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
