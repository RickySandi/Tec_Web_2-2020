using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Assignment_1.general_classes;

namespace Assignment_1.Linq
{
    public static class Tester
    {
        public static void Test()
        {

        }

        public static List<Athlete> PopulateRunners()
        {
            var result = new List<Athlete>();

            result.Add(new Runner() { Id = 1, AthleteName = "Ana", AthleteAge = 22 });
            result.Add(new Runner() { Id = 2, AthleteName = "Donald", AthleteAge = 77 });
            result.Add(new Runner() { Id = 3, AthleteName = "David", AthleteAge = 18 });
            result.Add(new Runner() { Id = 4, AthleteName = "Gerald", AthleteAge = 60 });
            result.Add(new Runner() { Id = 5, AthleteName = "Xavier", AthleteAge = 32 });

            return result;
        }

        public static List<Athlete> PopulateSoccerPlayers()
        {
            var result = new List<Athlete>();

            result.Add(new SoccerPlayer() { Id = 6, AthleteName = "David", AthleteAge = 40 });
            result.Add(new SoccerPlayer() { Id = 7, AthleteName = "Carl", AthleteAge = 18 });
            result.Add(new SoccerPlayer() { Id = 8, AthleteName = "Harnold", AthleteAge = 41 });
            result.Add(new SoccerPlayer() { Id = 9, AthleteName = "Ana", AthleteAge = 34 });
            result.Add(new SoccerPlayer() { Id = 10, AthleteName = "Bob", AthleteAge = 22 });

            return result;
        }
    }
}
