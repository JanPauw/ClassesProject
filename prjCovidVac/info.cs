using System;
using System.Collections.Generic;
using System.Text;

namespace prjCovidVac
{
    class info
    {
        #region Special Student Variables
        private static int iArraySize = 0;
        private static int iCounter = 0;
        #endregion

        #region Hospital Info
        private static string strHospitalName;
        private static string strHospitalAddress;
        private static bool bType;
        private static char cProvince;
        #endregion

        #region Hospital Info Getter and Setters
        public string Hospital_Name { get => strHospitalName; set => strHospitalName = value; }
        public string Hospital_Address { get => strHospitalAddress; set => strHospitalAddress = value; }
        public bool BType { get => bType; set => bType = value; }
        public char CProvince { get => cProvince; set => cProvince = value; }
        #endregion

        #region Patient Info
        private static string[] strID;
        private static string[] strMedAid;
        private static string[] strName;
        private static string[] strSurname;
        private static string[] strRefDoc;
        private static char[] cBloodType;
        private static string[] strAllergies;
        private static bool[] bHasCovid;
        private static string[] strVaccine;
        #endregion

        #region Set Array's Size
        public void setArrays(int size)
        {
            strID = new string[size];
            strMedAid = new string[size];
            strName = new string[size];
            strSurname = new string[size];
            strRefDoc = new string[size];
            strAllergies = new string[size];
            strVaccine = new string[size];

            cBloodType = new char[size];
            bHasCovid = new bool[size];
        }
        #endregion

        public static void AddPatient(string newID, string newMedAid, string newName, string newSurname, string newRefDoc, char newBloodType, string newAllergies, bool newHadCovid, string newVaccine)
        {
            strID[iCounter] = newID;
            strMedAid[iCounter] = newMedAid;
            strName[iCounter] = newName;
            strSurname[iCounter] = newSurname;
            strRefDoc[iCounter] = newRefDoc;
            cBloodType[iCounter] = newBloodType;
            strAllergies[iCounter] = newAllergies;
            bHasCovid[iCounter] = newHadCovid;
            strVaccine[iCounter] = newVaccine;

            iCounter++;
        }

    }
}
