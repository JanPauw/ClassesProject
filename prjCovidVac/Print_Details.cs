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
            Console.WriteLine("Patient ID|Patient Name|Patient Surname|Patient Medical Aid|Patient Referring Dr.|Patient Blood Type|Patient Allergies|Patient has C-19|Vaccine Administerred");

            for (int i = 0; i < x.ArraySize; i++)
            {
                Console.Write(x.StrID[i] + "|" + x.StrName[i] + "|" + x.StrSurname[i] + "|" + x.StrMedAid[i] + "|" + x.StrRefDoc[i] + "|" + x.CBloodType[i] + "|" + x.StrAllergies[i] + "|" + x.BHasCovid[i] + "|" + x.StrVaccine[i]);
            }
        }
    }
}
