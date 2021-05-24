using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lab11._2.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }

        public override string ToString()
        {
            return $"{id} {name}  {description}  {price}  {category}";
        }
        static public List<Product> GetAllItems() 
        {
            MySqlConnection dab = new MySqlConnection("Server=127.0.0.1;Database=coffeehouse;Uid=root;Password=abc123");
            return dab.GetAll<Product>().ToList();
        }

    }
}
