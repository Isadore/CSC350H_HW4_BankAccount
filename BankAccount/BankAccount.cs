class BankAccount {
    private int id;
    private string customerName;
    private double balance;
    private List<double> transactions = new List<double>();
    public BankAccount(string customerName, int id, double balance = 0) {
        this.customerName = customerName;
        this.balance = balance;
        this.id = id;
    }
    public int Id {
        get {return id;}
    }
    public string CustomerName {
        get {return customerName;}
    }
    public double Balance {
        get {return balance;}
    }
    public void deposit(double amount) {
        transactions.Add(amount);
        balance+=amount;
    }
    public void withdraw(double amount) {
        transactions.Add(-1*amount);
        balance-=amount;
    }
    public void display() {
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Account ID: " + id);
        Console.WriteLine("Balance: $" + balance);
        Console.Write("Transactions: [");
        for(int i = 0; i < transactions.Count; i++) {
            Console.Write(transactions[i]);
            if(i < (transactions.Count-1)) Console.Write(", ");
        }
        Console.Write("]");
    }


}