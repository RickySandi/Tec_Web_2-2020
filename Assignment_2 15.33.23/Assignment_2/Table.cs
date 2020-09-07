using System;
namespace Assignment_2
{
    public class Table
    {
        //private string name;
        //private string available;

        public string tableName { get; set; }
        public string isAvailable { get; set; }


         public static void setTable(Table table, string tName, string availability)
         {
            table.tableName = tName;
            table.isAvailable = availability;
         }


          
    }
}






