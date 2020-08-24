using System;
using Assignment_1.Interfaces; 

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq  
            Assignment_1.Linq.Linq.Queries();

            //Generics
            Assignment_1.Generics.Tester.Test();

            //INTERFACES

          
            ManagementAgency.type = ManagementAgencyType.AlwaysRunning;
            IManagementAgency runningAcency = ManagementAgency.Create();
            runningAcency.Sport = "Running";
            runningAcency.WorkingYears = 5; 
            runningAcency.AthleteAge = 25;
            runningAcency.Height = 190;

            ShowAthlete(runningAcency, runningAcency.WorkingYears);

            global::System.Console.WriteLine();


            ManagementAgency.type = ManagementAgencyType.SoccerSportGroup;
            IManagementAgency soccerAgency = ManagementAgency.Create();
            soccerAgency.Sport = "Soccer";
            soccerAgency.WorkingYears = 10;
            soccerAgency.AthleteAge = 32;
            soccerAgency.AthleteName = "Iker Casillas";

            ShowAthlete(soccerAgency, soccerAgency.WorkingYears);

            //string Sport { get; set; }
            //int Payment { get; set; }
            //int WorkingYears { get; set; }

            //public string SportName { get; set; }
            //public string AthleteAge { get; set; }
            //public string Height { get; set; }
          
            

        }



        private static void ShowAthlete(IManagementAgency managementAgency, int years)
        {
            Console.WriteLine($" {managementAgency.GetAgency()}");
            var athleteInformation = managementAgency.GetAthleteInformation();
            Console.WriteLine($"information:{athleteInformation.SportName} {athleteInformation.AthleteAge}" +
                $" {athleteInformation.AthleteName} {athleteInformation.Height}");



            var payment = managementAgency.calculatePayment(managementAgency.WorkingYears);
            Console.WriteLine($"The payment is: {payment}$ You worked {managementAgency.WorkingYears}$ years alredy");
        }
    }
}
