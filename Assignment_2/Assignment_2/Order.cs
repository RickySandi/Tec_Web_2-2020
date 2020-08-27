using System;
using System.Collections.Generic;
namespace Assignment_2
{
    public class Order
    {
        
        public int Id { get; set; }
        public string ClientName { get; set; }
        public Table OrderTable { get; set; }
        public List<Combo> Combos { get; set; }


       


        public  List<Order> addCombo(string name, Table table, List<Combo> combos) {

            var result = new List<Order>();

            result.Add(new Order() { ClientName = name, OrderTable = table, Combos = combos }); 


            return result; 

        }

        public void showOrder() {

            Console.WriteLine($"Client: {this.ClientName} Table: {this.OrderTable} Combos: {this.Combos}"); 

       
        }


        



    }
}
