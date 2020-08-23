using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1.Interfaces
{
    public interface IManagementAgency
    {
        string Sport { get; set; }
        int Payment { get; set; }
        int WorkingYears { get; set; }
        int AthleteAge { get; set; }
        int Height { get; set; }
        string AthleteName { get; set; }


        string GetAgency();
        ManagedAthleteInfo GetAthleteInformation();
        int calculatePayment(int years);
    }
}
