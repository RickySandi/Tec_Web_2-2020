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
            //Linq
            var registeredRunners = PopulateRunners();
            var registeredSoccerPlayers = PopulateSoccerPlayers();

            /*
            foreach (var runner in registeredRunners)
            {
                Console.WriteLine(runner.GetInfo());
            }

            Console.WriteLine("------------------------------------"); 

            foreach (var soccerPlayer in registeredSoccerPlayers)
            {
                Console.WriteLine(soccerPlayer.GetInfo());
            }

            Console.WriteLine("------------------------------------");

            //runners by age
            var runnersByAge = from element in registeredRunners
                               group element by element.AthleteAge;

            //soccerPlayers by age
            var soccerPlayersByAge = from element in registeredSoccerPlayers
                                     group element by element.AthleteAge;
            */

            //Runners filter by age criteria

            var runnersLessThan30 = registeredRunners.Where(e => e.AthleteAge < 30); //debug

             foreach(var runner in runnersLessThan30)
             {

                Console.WriteLine(runner.GetInfo()); 
             }

            

            var runnersBetween10And20 = registeredRunners.Where(e => e.AthleteAge >= 10 && e.AthleteAge <= 20); //debug


            foreach (var runner in runnersLessThan30)
            {

                Console.WriteLine(runner.GetInfo());
            }

            //Soccer Players filter by age criteria

            var soccerPlayersLessThan30 = registeredSoccerPlayers.Where(e => e.AthleteAge < 30); //debug
            var soccerPlayersBetween10And20 = registeredSoccerPlayers.Where(e => e.AthleteAge >= 10 && e.AthleteAge <= 20); //debug




        }

        public static List<Athlete> PopulateRunners()
        {
            var result = new List<Athlete>();

            result.Add(new Runner() { Id = 1, AthleteName = "Runner 1", AthleteAge = 22 });
            result.Add(new Runner() { Id = 2, AthleteName = "Runner 2", AthleteAge = 77 });
            result.Add(new Runner() { Id = 3, AthleteName = "Runner 3", AthleteAge = 18 });
            result.Add(new Runner() { Id = 4, AthleteName = "Runner 4", AthleteAge = 60 });
            result.Add(new Runner() { Id = 5, AthleteName = "Runner 5", AthleteAge = 32 });

            return result;
        }

        public static List<Athlete> PopulateSoccerPlayers()
        {
            var result = new List<Athlete>();

            result.Add(new SoccerPlayer() { Id = 6, AthleteName = "SoccerPlayer 1", AthleteAge = 40 });
            result.Add(new SoccerPlayer() { Id = 7, AthleteName = "SoccerPlayer 2", AthleteAge = 18 });
            result.Add(new SoccerPlayer() { Id = 8, AthleteName = "SoccerPlayer 3", AthleteAge = 41 });
            result.Add(new SoccerPlayer() { Id = 9, AthleteName = "SoccerPlayer 4", AthleteAge = 34 });
            result.Add(new SoccerPlayer() { Id = 10, AthleteName = "SoccerPlayer 5", AthleteAge = 22 });

            return result;
        }

        public static List<Institution> PopulateInstitutions()
        {
            var result = new List<Institution>();

            result.Add(new Institution() { InstitutionName = "World Athletics", InstitutionCountry = "France",  AthleteId = 1 });
            result.Add(new Institution() { InstitutionName = "World Athletics", InstitutionCountry = "France", AthleteId = 3 });
            result.Add(new Institution() { InstitutionName = "World Athletics", InstitutionCountry = "France", AthleteId = 5 });
            result.Add(new Institution() { InstitutionName = "World Athletics", InstitutionCountry = "France", AthleteId = 7 });
            result.Add(new Institution() { InstitutionName = "World Athletics", InstitutionCountry = "France", AthleteId = 9 });

            result.Add(new Institution() { InstitutionName = "FC Bayern Munchen", InstitutionCountry = "Germany", AthleteId = 2 });
            result.Add(new Institution() { InstitutionName = "PSG ", InstitutionCountry = "France", AthleteId = 4 });
            result.Add(new Institution() { InstitutionName = "PSG", InstitutionCountry = "France", AthleteId = 6 });
            result.Add(new Institution() { InstitutionName = "PSG ", InstitutionCountry = "France", AthleteId = 8 });
            result.Add(new Institution() { InstitutionName = "FC Bayern Munchen", InstitutionCountry = "Germany", AthleteId = 10 });
            

            return result;
        }
    }
}
