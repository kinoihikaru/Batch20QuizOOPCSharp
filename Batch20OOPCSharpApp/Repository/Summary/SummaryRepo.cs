using Batch20OOPCSharpApp.DataCollection;
using Batch20OOPCSharpApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch20OOPCSharpApp.Repository.Summary
{
    internal class SummaryRepo : ISummaryRepo
    {
        private IVehicleDataCollection _vehicles;
        public SummaryRepo(IVehicleDataCollection vehicles)
        {
            _vehicles = vehicles;
        }

        public double GetTotalIncomeVechile(string vehicle)
        {
            double totalIncome = 0;

            foreach (AVehicle vhc in _vehicles.FetchAll())
            {
                if (vehicle.ToLower() == "suv" && vhc.GetType().Name.ToLower() == vehicle.ToLower())
                {
                    SUV suv = (SUV)vhc;
                    totalIncome += suv.Total;
                }

                if (vehicle.ToLower() == "taxi" && vhc.GetType().Name.ToLower() == vehicle.ToLower())
                {
                    Taxi taxi = (Taxi)vhc;
                    totalIncome += taxi.Total;
                }

                if (vehicle.ToLower() == "privatejet" && vhc.GetType().Name.ToLower() == vehicle.ToLower())
                {
                    PrivateJet jet = (PrivateJet)vhc;
                    totalIncome += jet.Total;
                }
            }

            return totalIncome;
        }

        public double GetTotalIncomeVechileAll()
        {

            double totalIncome = 0;

            foreach (AVehicle vehicle in _vehicles.FetchAll())
            {
                if (vehicle is SUV)
                {
                    SUV suv = (SUV)vehicle;
                    totalIncome += suv.Total;
                }

                if (vehicle is Taxi)
                {
                    Taxi taxi = (Taxi)vehicle;
                    totalIncome += taxi.Total;
                }

                if (vehicle is PrivateJet)
                {
                    PrivateJet jet = (PrivateJet)vehicle;
                    totalIncome += jet.Total;
                }
            }

            return totalIncome;
        }

        public int GetTotalVechile(string Vehicle)
        {
            int totalCount = 0;

            foreach (AVehicle vhc in _vehicles.FetchAll())
            {
                if (Vehicle.ToLower() == "suv" && vhc.GetType().Name.ToLower() == Vehicle.ToLower())
                {
                    SUV suv = (SUV)vhc;
                    totalCount += 1;
                }

                if (Vehicle.ToLower() == "taxi" && vhc.GetType().Name.ToLower() == Vehicle.ToLower())
                {
                    Taxi taxi = (Taxi)vhc;
                    totalCount += 1;
                }

                if (Vehicle.ToLower() == "privatejet" && vhc.GetType().Name.ToLower() == Vehicle.ToLower())
                {
                    PrivateJet jet = (PrivateJet)vhc;
                    totalCount += 1;
                }
            }

            return totalCount;
        }

        public int GetTotalVechileAll()
        {
            int totalCount = 0;

            foreach (AVehicle vehicle in _vehicles.FetchAll())
            {
                totalCount += 1;
            }

            return totalCount;
        }
    }
}
