using System;

using P01_Exercise_Lecture_Variant.Models;
using P01_Vehicles.Common;

namespace P01_Exercise_Lecture_Variant.Factories
{
    public class VehicleFactory
    {
        public VehicleFactory()
        {

        }

        public Vehicle CreateVehicle (string vehicleType, double fuelQuantity, double fuelConsumption)
        {
            Vehicle vehicle;

            if (vehicleType == "Car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumption);
            }
            else if (vehicleType == "Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption);
            }
            else
            {
                throw new InvalidOperationException(ExeptionMessages.INVALID_VEHICLE_TYPE);
            }

            return vehicle;
        } 
    }
}
