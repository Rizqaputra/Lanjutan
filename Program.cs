using System;
public class Canon : IPrinterWindows
{
    public void show()
    {
        Console.WriteLine("Canon Display dimension : 9.5*12");
    }

    public void print()
    {
        Console.WriteLine("Canon printer printing ...");
    }
}
public class Epson : IPrinterWindows
{
    public void show()
    {
        Console.WriteLine("Epson Display dimension : 10*11");
    }

    public void print()
    {
        Console.WriteLine("Epson printer printing ...");
    }
}
public class LaserJet : IPrinterWindows
{
    public void show()
    {
        Console.WriteLine("Laserjet Display dimension : 12*12");
    }

    public void print()
    {
        Console.WriteLine("LaserJet printer printing ...");
    }
}
interface IPrinterWindows
{
    void show();
    void print();
}

namespace Polymorphism_Interface_2685
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinterWindows printer;

            Console.WriteLine("Pilih Printer!!!");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet/\n");

            Console.Write("Nomor Printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.show();
            printer.print();

            Console.ReadKey();


        }
    }
}

