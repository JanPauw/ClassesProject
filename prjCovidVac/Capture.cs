using System;
using System.Collections.Generic;
using System.Text;

namespace prjCovidVac
{
    class Capture
    {
        public void setPatientInfo()
        {
            info x = new info();
            Console.Clear();

            for (int i = 0; i < x.ArraySize; i++)
            {
                Console.WriteLine("Please enter Patient ID:");
                string strID = Console.ReadLine();

                Console.WriteLine("Please enter Patient Medical Aid:");
                string strMedAid = Console.ReadLine();

                Console.WriteLine("Please enter Patient First Name:");
                string strName = Console.ReadLine();

                Console.WriteLine("Please enter Patient Surname:");
                string strSurname = Console.ReadLine();

                Console.WriteLine("Please enter Patient Referrer Dr:");
                string strRefDoc = Console.ReadLine();

                Console.WriteLine("Please enter Patient Allergies:");
                string strAllergies = Console.ReadLine();

                Console.WriteLine("Please enter Vaccine Administerred:");
                string strVaccine = Console.ReadLine();

                Console.WriteLine("Please enter Patient Blood Type:");
                char cBloodType = Console.ReadLine()[0];

                Console.WriteLine("Is Patient C-19 Positive?:");
                bool bHasCovid;
                switch (Console.ReadLine())
                {
                    case "true":
                    case "Yes":
                    case "yes":
                    case "YES":
                    case "True":
                    case "TRUE":
                    case "y":
                    case "Y":
                        bHasCovid = true;
                        break;
                    default:
                        bHasCovid = false;
                        break;
                }

                x.AddPatient(strID, strMedAid, strName, strSurname, strRefDoc, cBloodType, strAllergies, bHasCovid, strVaccine);
            }
        }
    }
}
