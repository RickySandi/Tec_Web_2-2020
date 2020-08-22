using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1.Interfaces
{
    public enum ManagementAgencyType
    {
        SoccerSportGroup,
        AlwaysRunning
    }

    public static class ManagementAgency
    {

        public static ManagementAgencyType type;
        public static IManagementAgency Create()
        {
            switch (type)
            {
                case ManagementAgencyType.SoccerSportGroup:
                    return new SoccerSportGroupAgency(); //una clase
                case ManagementAgencyType.AlwaysRunning:
                    return new AlwaysRunningAgency(); // otra clase
                default:
                    return null;
            }
        }
    }
}
