using System;
using System.Collections.Generic;
using System.Text;
using Assignment_1;
using Assignment_1.general_classes;

namespace Assignment_1.Generics
{
    public class List<T>
    {
        private T[] array;

        public List(int size)
        {
            array = new T[size];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
            //value.Skill();
        }


    }

    public static class Tester
    {
        public static void Test()
        {
            var runners = new List<Runner>(2);

            runners.setItem(0, new Runner()
            {
                AthleteName = "Usain Bolt",
                AthleteAge = 30
            });

            runners.setItem(1, new Runner()
            {
                AthleteName = "Bruno Rojas",
                AthleteAge = 25
            });

            for (int i = 0; i < 2; i++)
            {
                var runner = runners.getItem(i);

                Console.WriteLine(runner.GetInfo());
                Console.WriteLine(runner.Skill());
            }


            var soccerPlayers = new List<SoccerPlayer>(2);

            soccerPlayers.setItem(0, new SoccerPlayer()
            {
                AthleteName = "Iker Casillas",
                AthleteAge = 34
            });

            soccerPlayers.setItem(1, new SoccerPlayer()
            {
                AthleteName = "Luka Modric",
                AthleteAge = 32
            });

            for (int i = 0; i < 2; i++)
            {
                var players = soccerPlayers.getItem(i);

                Console.WriteLine(players.GetInfo());
                Console.WriteLine(players.Skill());
            }


        }

    }

}
