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
        enMode Mode { get; set; }

        public ClsCountry()
        {
            CountryID = -1;
            Mode = enMode.AddNew;
        }

        ClsCountry(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
            Mode = enMode.Update;
        }

        public static ClsCountry Find(int ID)
        {
            var countryData = new ClsCountryDataAccessLayer.stCountryData();
            return (ClsCountryDataAccessLayer.FindByID(ID, ref countryData)) ? new ClsCountry(countryData.CountryID, countryData.CountryName) : null;
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
            return ClsCountryDataAccessLayer.UpdateCountry(new ClsCountryDataAccessLayer.stCountryData() { CountryID = this.CountryID, CountryName = this.CountryName });
        }

        private bool _AddCountry()
        {
            return ClsCountryDataAccessLayer.AddCountry(new ClsCountryDataAccessLayer.stCountryData() { CountryID = this.CountryID, CountryName = this.CountryName });
        }

        public static bool DeleteCountry(int ID)
        {
            return ClsCountryDataAccessLayer.DeleteCountry(ID);
        }

        public static DataTable GetAllCountry()
        {
            return ClsCountryDataAccessLayer.GetAllCountry();
        }

        public static bool IsCountryExist(int ID)
        {
            return ClsCountryDataAccessLayer.IsCountryExist(ID);
        }
    }
}

