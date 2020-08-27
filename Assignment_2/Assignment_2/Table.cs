using System;
namespace Assignment_2
{
    public class Table
    {
        private string name;
        private bool available;

        public string tableName { get; set; }
        public bool isAvailable { get; set; }





         public static void setTable(Table table, string tName, bool availability)
         {
            table.tableName = tName;
            table.isAvailable = availability;
         }


          
    }
}






