using System;
using System.Collections.Generic;
using System.Text;

namespace prjCovidVac
{
    class Print_Details
    {
        public void printDetails()
        {
            info x = new info();
            Console.Clear();

            Console.WriteLine("Welcome to " + x.Hospital_Name + " hospital.");
            Console.WriteLine("============================================");
            Console.WriteLine("Hospital Info:");
            Console.WriteLine("Address: " + x.Hospital_Address);
            Console.WriteLine("Private/Public?: " + x.BType);
            Console.WriteLine("Province: " + x.CProvince);
            Console.WriteLine("============================================");
            Console.WriteLine("Patient ID\t\tPatient Name\t\tPatient Surname\t\tPatient Medical Aid\t\tPatient Referring Dr.\t\tPatient Blood Type\t\tPatient Allergies\t\tPatient has C-19\t\tVaccine Administerred");

            for (int i = 0; i < x.ArraySize; i++)
            {
                Console.Write(x.StrID[i] + "\t\t" + x.StrName[i] + "\t\t" + x.StrSurname[i] + "\t\t" + x.StrMedAid[i] + "\t\t" + x.StrRefDoc[i] + "\t\t" + x.CBloodType[i] + "\t\t" + x.StrAllergies[i] + "\t\t" + x.BHasCovid[i] + "\t\t" + x.StrVaccine[i]);
            }
        }
    }
}
