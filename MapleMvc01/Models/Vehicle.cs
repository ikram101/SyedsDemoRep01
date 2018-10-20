using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapleMvc01.Models
{


    public interface IVehicle
    {
          string name { get; set; }
          int price { get; set; }
          int model { get; set; }

          string Speed();
    }


    public class Vehicle:IVehicle
    {
        public int VehicleId { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int model { get; set; }

        public string Speed()
        {
            return "Vehical main class";
        }
    }

    public class car : IVehicle
    {
        public int CarId { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int model { get; set; }

        public string Speed()
        {
            return "Car Class";
        }

    }

    public class Truck : IVehicle
    {
        public int TruckID { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int model { get; set; }
        

        public string Speed()
        {
            return "Truck class";
        }
    }

    public class Mycar : Vehicle
    {

        public string MyCarSpeed()
        {
            return "My car speed class";
        }
    }
}


