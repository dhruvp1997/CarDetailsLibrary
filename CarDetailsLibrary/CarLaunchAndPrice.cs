using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace CarDetailsLibrary
{
    class CarLaunchAndPrice : CarEngine
    {
        public DateTime YearOfLaunch { get; set; }
        public double ApproxPrice { get; set; }
        public CarLaunchAndPrice(string companyName, string modelName,string engine, int topSpeed, DateTime yearOfLaunch, double approxPrice)
        {
            CompanyName = companyName; 
            ModelName = modelName;
            Engine = engine;
            TopSpeed = topSpeed;
            YearOfLaunch = yearOfLaunch; 
            ApproxPrice = approxPrice;
        }
        
    }
}
