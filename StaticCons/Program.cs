using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCons
{
    class Bank
    {
        int accno;
        string accname;
        double bal;
        static string Bankname;
        static string BankLoc;
        static long BankPhone;
        //static varibale are used to assign static values under static constructor.

        static Bank()
        {
            Bankname = "ICICI";
            BankLoc = "Hyd";
            BankPhone = 12345687970;
        }
        internal Bank(int accno, string accname,double bal)
        {
            this.accno = accno;
            this.accname = accname;
            this.bal = bal;
           
        }
        public void CreateAccount(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("Account created sucessfully");
            Console.WriteLine("Account num is " + accno);
            Console.WriteLine("Account name is "+accname);
            Console.WriteLine("Account bal is "+bal);
        }
        //public void DepositAmount(int IntAmt)
        //{
        //  bal= bal + IntAmt;
        //    Console.WriteLine("Updated amount is" + bal);
        //}
        public void Withdraw(int Amount)
        {
            if(bal>Amount)
            {
                bal = bal - Amount;
                Console.WriteLine("your updated bal is" + bal);
            }
            else
            {
                Console.WriteLine("Insufficeint funds");
            }
        }
        public static void DisplayBankInfo()
        {
            Console.WriteLine("Bank name is"+Bankname);
            Console.WriteLine("Bank loc is "+BankLoc);
            Console.WriteLine("Bank phone is"+BankPhone);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank(45678, "Sai", 90000);
            b.CreateAccount(100000);
            b.Withdraw(80000);
            Bank.DisplayBankInfo();
           
            Bank obj = new Bank(1234, "RK", 0);
            obj.CreateAccount(100000);
            obj.Withdraw(20000);
            Bank.DisplayBankInfo();
            Bank bk = new Bank(1111, "Kumar", 10000);
            bk.CreateAccount(10000);
            bk.Withdraw(5000);
            Bank.DisplayBankInfo();

        }
    }
}
