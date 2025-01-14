﻿using Country.DataAccessLayer;

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

        public static ClsCountry FindByID(int ID)
        {
            var countryData = new ClsCountryDataAccessLayer.stCountryData();
            return (ClsCountryDataAccessLayer.FindByID(ID, ref countryData)) ? new ClsCountry(countryData.CountryID, countryData.CountryName) : null;
        }

    }
}
