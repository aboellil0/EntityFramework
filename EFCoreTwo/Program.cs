using EFCoreTwoN;
using EFCoreTwoN.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        SendDataMohamed();
        Console.WriteLine("Hello, World!");
    }


    public static void SendDataMohamed()
    {
        using var context = new ApplicationDbContext();
        context.Database.EnsureCreated();

        var dataToSend = context.DataToSends.FirstOrDefault(p => p.Name == "mohamed55");
        if (dataToSend == null)
            context.DataToSends.Add(new DataToSend { Name = "mohamed55", Description = "aboellil55" });
    }
}