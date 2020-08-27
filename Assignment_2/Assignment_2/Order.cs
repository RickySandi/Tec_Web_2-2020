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
        public List<Combo> Combos { get; set; }

        //public const string clientName2 = "Ricky"; 


       


        public  List<Order> addCombo(string name, Table table, List<Combo> combos) {

            var result = new List<Order>();

            //result.Add(new Order() { ClientName = name, OrderTable = table, Combos = combos });
              result.Add(new Order() { clientName = name});


            return result; 

        }

        public void showOrder() {

            //Console.WriteLine($"Client: {this.ClientName} Table: {this.OrderTable} Combos: {this.Combos}");
             Console.WriteLine($"Client: {clientName}");


        }


        



    }
}
