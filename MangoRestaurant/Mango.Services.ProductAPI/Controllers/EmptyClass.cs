using System;
namespace Mango.Services.ProductAPI.Controllers
{
    public sealed class singleton
    {
        private singleton() { }

        private static singleton instance = new singleton();

        public static singleton GetInstance()
        { 
            return instance;
        }
    }
}

//Library Starts
interface IprintingSolution
{
    string GetPrintFloor();
    string FileType();
}

class A4Print : IprintingSolution
{
    public string FileType()
    {
        return "A4 Prints";
    }

    public string GetPrintFloor()
    {
        return "A4 Print Floor";
    }
}

class visitingCard : IprintingSolution
{
    public string FileType()
    {
        return "Visiting Card Prints";
    }

    public string GetPrintFloor()
    {
        return "Visiting Card Print Floor";
    }
}

class postCard : IprintingSolution
{
    public string FileType()
    {
        return "Post Card Prints";
    }

    public string GetPrintFloor()
    {
        return "Post Card Print Floor";
    }
}
//Library Ends

public class PrinterFactory
{
    public IprintingSolution Instance { get; set; }

    public IprintingSolution printingObject(string type)
    {
        switch (type)
        {
            case "A4":
                Instance = new A4Print();
                break;
            case "VC":
                Instance = new visitingCard();
                break;
            case "PC":
                Instance = new postCard();
                break;
            default:
                break;
        }

        return Instance;
    }
}


class caller
{
    public static void MainMethod()
    {
        Console.WriteLine("Enter what you want to Print (A4/ VC / PC)");


        string type = Console.ReadLine();

        //if (type = "A4")
        //{
        //    printingSolution p = new printingSolution();
        //    p.fileType();
        //    p.getPrintfloor();
        //}
        //else if (type = "VC")
        //{
        //    VCprintingSolution p = new VCprintingSolution();
        //    p.fileType();
        //    p.getPrintfloor();
        //}
        //else
        //{
        //    VCprintingSolution p = new VCprintingSolution();
        //    p.fileType();
        //    p.getPrintfloor();
        //}

        PrinterFactory p = new PrinterFactory();

        IprintingSolution obj = p.printingObject(type);
        obj.FileType();
        obj.GetPrintFloor();


    }
}

