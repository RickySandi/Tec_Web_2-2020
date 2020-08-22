using System;
using System.Collections.Generic;
using System.Text;
using Assignment_1.Generics;
namespace Assignment_1.general_classes
{
    public class DelegatesAndLambdas
    {
        public DelegatesAndLambdas()
        {

            Action<Athlete, string, int> setAthlete = (athelete, name, age) =>
            {

                athelete.AthleteName = name;
                athelete.AthleteAge = age;
            };


            Func<Athlete, string, int, string> getAthlete = (athelete, name, age) =>
            {

                athelete.AthleteName = name;
                athelete.AthleteAge = age;
                return $"{athelete.GetInfo()} and {athelete.Skill()}";
            };

            var soccerPlayer = new SoccerPlayer();
            setAthlete(soccerPlayer, "Manuel Neuer", 30);

            var getSoccerPlayer = getAthlete(soccerPlayer, "Manuel Neuer", 30);




        //FALTA GENERICS.CS PARA CORRES DELEGATES AND LAMBDAS 

        }
    }

}
