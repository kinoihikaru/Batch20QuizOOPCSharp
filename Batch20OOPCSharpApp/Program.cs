using Batch20OOPCSharpApp.Base;
using Batch20OOPCSharpApp.DataCollection;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new VehicleDataCollection();
            var repoManager = new RepoManager(collection);

            //---------------- Summary -----------------
            Console.WriteLine("TotalVehicleSuv {0}", repoManager.Summary.GetTotalVechile("Suv"));
            Console.WriteLine("TotalVehicleTaxi {0}", repoManager.Summary.GetTotalVechile("Taxi"));
            Console.WriteLine("TotalVehiclePrivateJet {0}", repoManager.Summary.GetTotalVechile("PrivateJet"));
            Console.WriteLine("TotalVehicleAll {0}", repoManager.Summary.GetTotalVechileAll());

            Console.WriteLine("TotalIncomeVehicle Suv : {0}", repoManager.Summary.GetTotalIncomeVechile("SUV"));
            Console.WriteLine("TotalIncomeVehicle Taxi : {0}", repoManager.Summary.GetTotalIncomeVechile("Taxi"));
            Console.WriteLine("TotalIncomeVehicle PrivateJet : {0}", repoManager.Summary.GetTotalIncomeVechile("PrivateJet"));
            Console.WriteLine("totalincomevehicle all : {0}", repoManager.Summary.GetTotalIncomeVechileAll());
        }
    }
}