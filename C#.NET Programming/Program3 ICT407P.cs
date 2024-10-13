using System;

namespace ICT407P_Assignment3
{
    abstract class Account 
    {
        public abstract void withdraw(float amount);
        public abstract void deposit(float amount);
        public abstract void calc_interest();
        public abstract void get_total_amount();
    }
    
    class SavingsAccount: Account
    {
        private int rate_percent = 4; // defining rate percentage
        private float acc_balance; // defines the balance present in the account
        private string userName; // stores the user name
        
        public SavingsAccount(float amount, string name)
        {
            acc_balance = amount;
            userName = name;
        }
        
        public override void calc_interest()
        {
            Console.WriteLine("Hi there, " + userName + "!, your interest born on the balance is " + acc_balance* rate_percent/100);
        }
        
        public override void get_total_amount()
        {
            Console.WriteLine("Hi there, " + userName + "!, your account balance is currently " + acc_balance);
        }
        
        public override void withdraw(float amt)
        {
            if(amt > acc_balance)
            {
                Console.WriteLine("Transaction Failure Alert! Insufficient funds.");
            }
            else
            {
                acc_balance -= amt;
                Console.WriteLine("Withdrawal successful! Current balance is " + acc_balance);
            }
        }
        
        public override void deposit(float amt)
        {
            acc_balance += amt;
            Console.WriteLine("Deposit successfully made! Current balance is " + acc_balance);
        }
    }
    
    class CurrentAccount: Account
    {
        private float acc_balance; // defines the balance present in the account
        private string userName; // stores the user name
        private float overdraft_limit = 500; // defining overdraft limit for account
        private float overdraft; // defining overdraft amount used
        
        public CurrentAccount(float amount, string name)
        {
            acc_balance = amount;
            userName = name;
            overdraft = 0;
        }
        
        public override void calc_interest()
        {
            Console.WriteLine("Sorry but no interest applicable for this account");
        }
        
        public override void get_total_amount()
        {
            Console.WriteLine("Hi there, " + userName + "!, your account balance is currently " + acc_balance);
        }
        
        public override void withdraw(float amt)
        {
            if(amt > acc_balance)
            {
                if (acc_balance > 0)
                {
                    overdraft += (amt - acc_balance);
                    acc_balance = -overdraft;
                }
                else if ((overdraft + amt) > overdraft_limit)
                {
                    Console.WriteLine("Transaction Failure Alert, Overdraft limit exceeded!");
                    return;
                }
                else
                {
                    overdraft += amt;
                }
            }
            else
            {
                acc_balance -= amt;
            }
            Console.WriteLine("Withdrawal successful! Current balance is " + acc_balance);
        }
        
        public override void deposit(float amt)
        {
            acc_balance += amt;
            Console.WriteLine("Deposit successfully made! Current balance is " + acc_balance);
        }
    }
    
    class OOPSDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Savings Account");
            SavingsAccount s1 = new SavingsAccount(1000, "Pranav");
            s1.calc_interest();
            s1.get_total_amount();
            s1.withdraw(500);
            s1.deposit(1000);
            
            
            Console.WriteLine();
            Console.WriteLine("Current Account");
            CurrentAccount s2 = new CurrentAccount(1750, "Prince");
            s2.calc_interest();
            s2.get_total_amount();
            s2.withdraw(1500);
            s2.withdraw(500);
            s2.withdraw(350);
            s2.deposit(1000);
        }   
    }
}