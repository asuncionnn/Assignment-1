using System;

class Student
{
    public string studentID;
    public string name;
    public string course;

    // Constructor
    public Student(string id, string name, string course)
    {
        this.studentID = id;
        this.name = name;
        this.course = course;
    }

    // Method to display info
    public void displayInfo()
    {
        Console.WriteLine("Student ID: " + studentID);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Course: " + course);
        Console.WriteLine();
    }
}

class BankAccount
{
    private string accountNumber;
    private string accountHolder;
    private double balance;

    // Constructor
    public BankAccount(string accNum, string holder, double initialBalance)
    {
        accountNumber = accNum;
        accountHolder = holder;
        balance = initialBalance;
    }

    public void deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposit Successful!");
    }

    public void withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawal Successful!");
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }

    public void displayBalance()
    {
        Console.WriteLine("Current Balance: " + balance.ToString("F2"));
    }
}

class Program
{
    static void Main()
    {
        // ---- Student Objects ----
        Student student1 = new Student("2023001", "Maria Santos", "BS Computer Science");
        Student student2 = new Student("2023002", "Juan Dela Cruz", "BS Information Technology");

        student1.displayInfo();
        student2.displayInfo();

        // ---- BankAccount Object ----
        BankAccount account = new BankAccount("123456", "Maria Santos", 5000);

        account.deposit(1000);
        account.withdraw(1500);
        account.displayBalance();
    }
}
