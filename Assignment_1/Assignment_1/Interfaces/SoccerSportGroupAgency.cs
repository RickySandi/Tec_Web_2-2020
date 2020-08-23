using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1.Interfaces
{
    public class SoccerSportGroupAgency : IManagementAgency
    {
        private string sport;
        private int payment;
        private int workingYears;
        private int athleteAge;
        private int height;
        private string athleteName;
        private const string agency = "Soccer Sport Group";


        public string Sport
        {
            get { return sport; }
            set { sport = value; }

        }

        public int Payment
        {
            get { return payment; }
            set { payment = calculatePayment(workingYears); }

        }

        public int WorkingYears
        {
            get { return workingYears; }
            set { workingYears = value; }

        }

        public int Height
        {
            get { return height; }
            set { height = value; }

        }

        public int AthleteAge
        {
            get { return athleteAge; }
            set { athleteAge = value; }

        }

        public string AthleteName
        {
            get { return athleteName; }
            set { athleteName = value; }

        }

        public string GetAgency()
        {
            return $"Agency Name: {agency}";
        }

        public ManagedAthleteInfo GetAthleteInformation()
        {
            return new ManagedAthleteInfo()
            {
                //Revisar que poner aca
                SportName = $"Sport:{sport}",
                AthleteAge = $"Age: {athleteAge}",
                AthleteName = $"Athlete Name:{athleteName}"

            };
        }

        public int calculatePayment(int years)
        {

            int paymentAux;

            if (years <= 5)
            {
                paymentAux = 1000;
            }

            else if (years <= 10)
            {
                paymentAux = 3000;
            }

            else
            {
                paymentAux = 5000;

            }

            return paymentAux * years;


        }

    }
}
