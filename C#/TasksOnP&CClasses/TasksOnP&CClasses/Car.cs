using System;
using System.Collections.Generic;p
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TasksOnP_CClasses
{
    class Car
    {
        public string Name { get; set; }
        public double HeightSM { get; set; }
        public double WidthSM { get; set; }
        public double LengthSM { get; set; }
        public double WeightKG {  get; set; }
        public string ModelSeries {  get; set; }
        public Car(string name, double heightSM, double widthSM, double lengthSM, double weightKG, string modelSeries) 
        { 
            ModelSeries = modelSeries;
            Name = name;
            HeightSM = heightSM;
            WidthSM = widthSM;
            LengthSM = lengthSM;
            WeightKG = weightKG;
        }
    }
    class GermanCars : Car
    {
        public string ProductionPlant { get; set; }
        public GermanCars(string name, double heightSM, double widthSM, double lengthSM, 
            double weightKG, string modelSeries, string productionPlant) 
            : base(name,heightSM,widthSM,lengthSM,weightKG, modelSeries)
        {
            ProductionPlant = productionPlant;
        }
    }
    class AmericanCars : Car
    {
        public string EngineType { get; set; }
        public string TransmissionType { get; set; }
        public bool IsConvertible { get; set; }
        public int SeatingCapacity { get; set; }
        public bool HasNavigationSystem { get; set; }

        public AmericanCars(string name, double heightSM, double widthSM, double lengthSM, double weightKG, string modelSeries, 
            string engineType, string transmissionType, bool isConvertible, int seatingCapacity, bool hasNavigationSystem)
            : base(name, heightSM, widthSM, lengthSM, weightKG, modelSeries)
        {
            EngineType = engineType;
            TransmissionType = transmissionType;
            IsConvertible = isConvertible;
            SeatingCapacity = seatingCapacity;
            HasNavigationSystem = hasNavigationSystem;
        }
    }
    class FrenchCars : Car
    {
        public string EngineType { get; set; }
        public string FuelType { get; set; }
        public bool IsElectric { get; set; }
        public bool IsCompact { get; set; }
        public string SpecialFeature { get; set; }

        public FrenchCars(string name, double heightSM, double widthSM, double lengthSM, double weightKG, string modelSeries, 
            string engineType, string fuelType, bool isElectric, bool isCompact, string specialFeature)
            : base(name, heightSM, widthSM, lengthSM, weightKG, modelSeries)
        {
            EngineType = engineType;
            FuelType = fuelType;
            IsElectric = isElectric;
            IsCompact = isCompact;
            SpecialFeature = specialFeature;
        }
    }
    class JapaneseCars : Car
    {
        public string EngineType { get; set; }
        public int FuelEfficiencyMPG { get; set; }
        public bool IsHybrid { get; set; }
        public bool IsReliable { get; set; }

        public JapaneseCars(string name, double heightSM, string modelSeries, double widthSM, double lengthSM, double weightKG,
             string engineType, int fuelEfficiencyMPG, bool isHybrid, bool isReliable)
            : base(name, heightSM, widthSM, lengthSM, weightKG, modelSeries)
        {
            EngineType = engineType;
            FuelEfficiencyMPG = fuelEfficiencyMPG;
            IsHybrid = isHybrid;
            IsReliable = isReliable;
        }
    }
    class ChineseCars : Car
    {
        public string ElectricRange { get; set; }
        public bool IsAffordable { get; set; }
        public string AutonomousFeatures { get; set; }

        public ChineseCars(string name, double heightSM, double widthSM,string modelSeries, double lengthSM, 
            double weightKG,string electricRange, bool isAffordable, string autonomousFeatures)
            : base(name, heightSM, widthSM, lengthSM, weightKG, modelSeries)
        {
            ElectricRange = electricRange;
            IsAffordable = isAffordable;
            AutonomousFeatures = autonomousFeatures;
        }
    }
    class justClass
    {
        public string Name { get; set; }
        private string gender { get; set; }
        protected int Age {  set; get; }
        internal string LastName {  get; set; }
    }
}
