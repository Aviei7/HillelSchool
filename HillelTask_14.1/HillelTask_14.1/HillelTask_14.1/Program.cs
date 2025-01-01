using HillelTask_14._1;

Account yuriiAccount = new Account("Yurii account", 200);

yuriiAccount.Deposit(100);
Console.WriteLine("Balance Yurii is now: " + yuriiAccount.Balance);
yuriiAccount.Withdrawal(120);
Console.WriteLine("Balance Yurii is now: " + yuriiAccount.Balance);