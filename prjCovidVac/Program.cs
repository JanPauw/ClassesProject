using System;

namespace prjCovidVac
{
    class Program
    {
        static void Main(string[] args)
        {
            info x = new info();

            Console.WriteLine("Please enter the Hospital Name");
            x.Hospital_Name = Console.ReadLine();

            Console.WriteLine("Please enter the Hospital Address");
            x.Hospital_Address = Console.ReadLine();

            Console.WriteLine("Is the Hospital Private/Public?");
            switch (Console.ReadLine())
            {
                case "Public":
                case "PUBLIC":
                    x.BType = true;
                    break;
                default:
                    x.BType = false;
                    break;
            }

            Console.WriteLine("In what Province is the Hospital Located?");
            x.CProvince = Console.ReadLine()[0];

            Console.WriteLine("How many Patients are being helped?");
            x.setArrays(int.Parse(Console.ReadLine()));

            Capture c = new Capture();
            c.setPatientInfo();

            Print_Details p = new Print_Details();
            p.printDetails();
        }
    }
}
