using OOP_Example_21;

class Program
{
    static void Main(string[] args)
    {
        MangeUser mange = new MangeUser(new YahooSender());
        mange.RecoveryPassword();
    }
}