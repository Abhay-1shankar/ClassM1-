using System;

namespace CLASS_M1
{
  public class BankCustomer
  {
    // Fields will be added here later
    public BankCustomer()
    {
      Console.WriteLine("BankCustomer created");
    }

    public BankCustomer(string firstname, string lastname){
      Console.WriteLine($"Bankcustomer created:{firstname} {lastname} ");
    }
  }
}
