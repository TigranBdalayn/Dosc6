// Task 1: Bank Account System with Custom Object Comparisons
// Task: Develop a BankAccount class that supports:
// 1. Custom String Representation (ToString() Override)
// Format: "Account: [AccountNumber], Balance: [Balance] USD"
// 2. Equality Check (Equals() and GetHashCode())
// Two accounts are equal if they have the same AccountNumber.
// 3. Overloaded + and - Operators for Transactions
// + should deposit money.
// - should withdraw money but prevent overdraft.
// 4. Comparison Operators (>, <, >=, <=)
// Compare accounts based on balance.

using System;


class BankAccount {

    private int _accountNumber;
    public int Account {
        get {return _accountNumber;}
        set {_accountNumber = value;}
    }
    private decimal _balance;

    public decimal Balance {
        get {return _balance;}
        set {_balance = value;}
    }

    public BankAccount (int accountNumber, decimal balance) {
        _accountNumber = accountNumber;
        _balance = balance;
    }

    public override string ToString() {

        return $"\nAccount: {_accountNumber}\nBalance: {Balance} USD\n";
    }

    public override bool Equals (object? obj) {

        if (obj is  BankAccount other) {

            return this._accountNumber == other._accountNumber;
        }
        return false;
    }
    public override int GetHashCode () {
        return _accountNumber.GetHashCode () ^ 7;
    }

    public static BankAccount operator +(BankAccount bankAccount, decimal balance) {
        bankAccount.Balance += balance;
        return bankAccount;
    }

    public static bool operator > (BankAccount acc1, BankAccount acc2) {
        return acc1.Balance > acc2.Balance;
    }

    public static bool operator < (BankAccount acc1, BankAccount acc2) {
        return acc1.Balance < acc2.Balance;
    }

    public static bool operator >= (BankAccount acc1, BankAccount acc2) {
        return acc1.Balance >= acc2.Balance;
    }

    public static bool operator <= (BankAccount acc1, BankAccount acc2) {
        return acc1.Balance <= acc2.Balance;
    }



}

class Program {
    static void Main (string[] args) {
        BankAccount Bank = new BankAccount (100, 200);
        BankAccount Bank2 = new BankAccount(2, 500);

        Console.WriteLine (Bank.ToString());
        Console.Write (Bank2.ToString());
        Bank += 100;
        Console.WriteLine (Bank.Balance);
        Console.WriteLine (Bank2.Balance);
        Console.WriteLine (Bank > Bank2);
        Console.WriteLine (Bank2 > Bank);

    }
}