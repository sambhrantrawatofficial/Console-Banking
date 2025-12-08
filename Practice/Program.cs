
using Practice.Services;

Console.WriteLine("Welcome to the Practice Bank Console Application!");
Console.WriteLine("\n-------------------------------------------------");
Console.WriteLine("\n1. Login \n2. Register");

string input1 = Console.ReadLine()!;

if (input1 == "1")
{
    Console.Clear();
    Console.WriteLine("\n---------- Login ----------");
    Console.Write("\nEnter your username: ");
    string username = Console.ReadLine()!;
    Console.Write("Enter your password: ");
    string password = Console.ReadLine()!;

    var userService = new UserService();
    bool loginSuccess = userService.Login(username, password);

    Console.Clear();
    Console.WriteLine("1. View Account Details \n2. Transfer money \n3. Exit");
    string input2 = Console.ReadLine()!;

    if (input2 == "1")
    {
        var accountService = new AccountService();
        accountService.ViewAccountDetails(username);
    }

    if (input2.Contains("2"))
        {
        Console.WriteLine("1. Transfer via Account Number \n2. Transfer via Phone Number");

        if (input2 == "1")
        {
            Console.WriteLine("Enter Receiver's Account Number: ");
            string receiverAccountNo = Console.ReadLine()!;
            Console.WriteLine("Enter Amount to Transfer: ");
            int amount = int.Parse(Console.ReadLine()!);
            var TMviaAcc = new TransferMoneyService();
                TMviaAcc.TransferViaAccountNo(username, receiverAccountNo, amount);
        }
        else if (input2 == "2")
        {
            Console.WriteLine("Enter Receiver's Phone Number: ");
            string receiverPhoneNo = Console.ReadLine()!;
            Console.WriteLine("Enter Amount to Transfer: ");
            int amount = int.Parse(Console.ReadLine()!);
            var TMviaPh = new TransferMoneyService();
            TMviaPh.TransferViaPhoneNo(username, receiverPhoneNo, amount);
        }
    }


}


else if (input1 == "2")
{
    Console.Clear();
    Console.WriteLine("\n---------- Register ----------");

    Console.WriteLine("\nEnter your username: ");
    string username = Console.ReadLine()!;

    Console.WriteLine("Enter your email: ");
    string email = Console.ReadLine()!;

    Console.WriteLine("Enter your phone number: ");
    string phoneNumber = Console.ReadLine()!;

    Console.WriteLine("Enter your password: ");
    string password = Console.ReadLine()!;

    var registerService = new Registerservice();
    bool registerSuccess = registerService.Register(username, password, email, phoneNumber);
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
