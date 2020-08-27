using System;
namespace Assignment_2
{
    public  class TableList
    {
        //public int Side { get; set; }

        public static void Table()
       {

           

            var Dimension = setMatrixDimensions(3);
            string[,] tables = new string[Dimension, Dimension];
         


            
        }
        public static int setMatrixDimensions(int side)
        {

            return side;

        }

        public static void fillTables(string[,] tables, int side)
        {

            int cont = 1;

            for (int i = 0; i < side; i++)
            {

                for (int j = 0; j < side; j++)
                {

                    tables[i, j] = $"Table {cont}";
                    cont++; 
                }
            }

        }

        //public static void fillTables2(string[][] tables, int side)
        //{

        //    tables[0][0] = "Table"; 

        //}
        public static void showTables(string[,] tables, int side)
        {

            for (int i = 0; i < side; i++)
            {
                
                for (int j = 0; j < side; j++)
                {

                    Console.Write(tables[i, j] + " ");

                }
                Console.WriteLine();
                Console.WriteLine();
            }


        }
    }
}

