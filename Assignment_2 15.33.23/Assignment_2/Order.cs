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
       

        public string getTableName(Table table)
        {
            return table.tableName; 
        }

        public  List<Order> addCombo(string name, Table table, Combo combos) {

            var result = new List<Order>();

            result.Add(new Order() { clientName = name, OrderTable = table, Combos = combos });
            table.isAvailable = "not available";

            if(combos.comboName == "Combo 1" )
            combos.comboPrice = 10;
            else
            combos.comboPrice = 18;



            return result; 

        }

        public void showOrder(Table table, Combo combo) {

            Console.WriteLine($"--ORDER--");
            Console.WriteLine($"Client: {clientName}");
            Console.WriteLine($"Table: {table.tableName}");
            Console.WriteLine($"Combo: {combo.comboName} Price: {combo.comboPrice}$");
            Console.WriteLine("----*----");
           

        }

        public void selectedCombo(Combo combo)
        {

            if (combo.comboName == "Combo 1") { Console.WriteLine("You ordered Combo 1"); }
            else if (combo.comboName == "Combo 2") { Console.WriteLine("You ordered Combo 2"); }
            else { Console.WriteLine("Invalid Combo selected. Please try again"); }
            //Assignment_2.Program.showMenu(); 


        }






    }
}
