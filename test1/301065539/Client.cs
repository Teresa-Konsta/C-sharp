using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _301065539
{
    enum Service { Sensors, Cameras, Intercoms }

    class Client
    {
        const double PRICE_SENSOR = 5;
        const double PRICE_CAMERA = 3;
        const double PRICE_INTERCOM = 10;
        
        private string address;
        private bool isActive;
        private string name;
        private string phone;
        private int quantity;
        private Service service;

        public string Address
        { 
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public bool IsActive
        { 
            get
            {
                return isActive;
            }
            set
            {
                isActive = true;
            }
        }

    public string Name
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    public string Phone
        { 
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

    public int Quantity
        { 
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

    public Service Service
    { 
            get
            {
                return service;
            }
            set
            {
                service = value;
            }
    }
        public virtual double CalculatePrice()
        {
            double totalPrice = 0;
            switch (Service)
            {
                case Service.Sensors:
                    totalPrice = Quantity * PRICE_SENSOR;
                    break;
                case Service.Cameras:
                    totalPrice = Quantity * PRICE_CAMERA;
                    break;
                case Service.Intercoms:
                    totalPrice = Quantity * PRICE_INTERCOM;
                    break;
            }
            return totalPrice;
        }

        public double CalculatePrice(double discount)
        {
            double totalPrice = 0;
            switch (Service)
            {
                case Service.Sensors:
                    totalPrice = (Quantity * PRICE_SENSOR)*discount;
                    break;
                case Service.Cameras:
                    totalPrice = (Quantity * PRICE_CAMERA)*discount;
                    break;
                case Service.Intercoms:
                    totalPrice = (Quantity * PRICE_INTERCOM)*discount;
                    break;
            }
            return totalPrice;
        }

        public Client(Service service, int quantity)
        {
            Service = service;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"- {Name} located {Address} is paying {CalculatePrice()} per month";
        }

        public void SaveData(string fileName, Client client)
        {
            FileStream outFile = new FileStream($"{fileName}.json",
               FileMode.Create, FileAccess.Write);

            StreamWriter streamWriter = new StreamWriter(outFile);

            string json = JsonConvert.SerializeObject(fileName);

            streamWriter.WriteLine(json);

            streamWriter.Close();
            outFile.Close();
        }
    }
}
