using System;
using System.Collections.Generic;
namespace Assignment_2
{
    public class Order
    {
        
        public int Id { get; set; }
        //public string ClientName { get; set; }
        public string clientName { get; set; }
        public Table OrderTable { get; set; }
        public Combo Combos { get; set; }

        //public const string clientName2 = "Ricky"; 


        public string getTableName(Table table)
        {
            return table.tableName; 
        }

     


        public  List<Order> addCombo(string name, Table table, Combo combos) {

            var result = new List<Order>();

            result.Add(new Order() { clientName = name, OrderTable = table, Combos = combos });
            table.isAvailable = "not available"; 
              //result.Add(new Order() { clientName = name});


            return result; 

        }

        public void showOrder(Table table, Combo combo) {

            //Console.WriteLine($"Client: {clientName} Table: {OrderTable.tableName} Combos: {Combos}");
             Console.WriteLine($"Client: {clientName}");

            //string tableName = getTableName(table);
            Console.WriteLine($"Table: {table.tableName}");
            Console.WriteLine($"Combo: {combo.comboName}");


        }


        



    }
}
