using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _301065539
{
    enum BusinessType { Store, Office, ApartmentBuilding, Government}


    class Business : Client
    {
        const double PRICE_STORE = 2;
        const double PRICE_OFFICE = 4;
        const double PRICE_APARTMENT = 7;
        const double PRICE_GOVERNMENT = 9;
        
        private BusinessType businessType;

        public BusinessType BusinessType
        {
            get
            {
                return businessType;
            }
            set
            {
                businessType = value;
            }
        }

        public override double CalculatePrice()
        {
            double totalPrice = base.CalculatePrice();
            switch(BusinessType)
            {
                case BusinessType.Store:
                    totalPrice += PRICE_STORE;
                    break;
                case BusinessType.Office:
                    totalPrice += PRICE_OFFICE;
                    break;
                case BusinessType.ApartmentBuilding:
                    totalPrice += PRICE_APARTMENT;
                    break;
                case BusinessType.Government:
                    totalPrice += PRICE_GOVERNMENT;
                    break;
            }
            return totalPrice;
        }

        public Business(BusinessType businessType, Service service, int quantity) : base(service, quantity)
        {
            BusinessType = businessType;
            Service = service;
            Quantity = quantity;
        }
    }
}
