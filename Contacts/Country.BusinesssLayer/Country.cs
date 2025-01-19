using Country.DataAccessLayer;
using System;
using System.Data;

namespace Country.BusinessLayer
{
    public class ClsCountry
    {
        enum enMode
        {
            AddNew = 1,
            Update
        }
        public int CountryID { get; private set; }
        public string CountryName { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;

        enMode Mode { get; set; }

        public ClsCountry()
        {
            CountryID = -1;
            Mode = enMode.AddNew;
        }

        ClsCountry(int countryID, string countryName, string code)
        {
            CountryID = countryID;
            CountryName = countryName;
            Code = code;
            Mode = enMode.Update;
        }

        public static ClsCountry Find(int ID)
        {
            var countryData = new CountryData.stCountryData();
            return (CountryData.Find(ID, ref countryData)) ? new ClsCountry(countryData.CountryID, countryData.CountryName, countryData.Code) : null;
        }
        public static ClsCountry Find(string Name)
        {
            var countryData = new CountryData.stCountryData();
            return (CountryData.Find(Name, ref countryData)) ? new ClsCountry(countryData.CountryID, countryData.CountryName, countryData.Code) : null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    return (_AddCountry()) ? true : false;
                case enMode.Update:
                    return (_UpdateCountry()) ? true : false;
            }
            return false;
        }

        private bool _UpdateCountry()
        {
            return CountryData.UpdateCountry(new CountryData.stCountryData() { CountryID = this.CountryID, CountryName = this.CountryName, Code = this.Code });
        }

        private bool _AddCountry()
        {
            return CountryData.AddCountry(new CountryData.stCountryData() { CountryID = this.CountryID, CountryName = this.CountryName, Code = this.Code });
        }

        public static bool DeleteCountry(int ID)
        {
            return CountryData.DeleteCountry(ID);
        }

        public static DataTable GetAllCountry()
        {
            return CountryData.GetAllCountry();
        }

        public static bool IsCountryExist(int ID)
        {
            return CountryData.IsCountryExist(ID);
        }

        public static bool IsCountryExist(string Name)
        {
            return CountryData.IsCountryExist(Name);
        }
    }
}

