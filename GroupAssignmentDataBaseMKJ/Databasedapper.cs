using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace GroupAssignmentDataBaseMKJ
{
    public class Databasedapper
    {
       
        static string connString = "data source=.\\SQLEXPRESS; initial catalog = Webshop; persist security info = True; Integrated Security = True;";
        /// <summary>
        /// Shows all Inventory from databse
        /// </summary>
        /// <returns></returns>
        public static List<Models.Inventory> ShowAllInventory()
        {
            var sql = "select * from Inventory";
            var inventory = new List<Models.Inventory>();

            using (var connection = new SqlConnection(connString))
            {
                inventory = connection.Query<Models.Inventory>(sql).ToList();
            }
            return inventory;
        }
        /// <summary>
        /// Shows all order details from database
        /// </summary>
        /// <returns></returns>
        public static List<Models.OrderDetail> ShowAllOrderDetail()
        {
            var sql = "select * from OrderDetails";
            var orderDetail = new List<Models.OrderDetail>();

            using (var connection = new SqlConnection(connString))
            {
                orderDetail = connection.Query<Models.OrderDetail>(sql).ToList();
            }
            return orderDetail;
        }
        /// <summary>
        /// Shows all orders from database
        /// </summary>
        /// <returns></returns>
        public static List<Models.Order> ShowAllOrder()
        {
            var sql = "select * from Orders";
            var order = new List<Models.Order>();

            using (var connection = new SqlConnection(connString))
            {
                order = connection.Query<Models.Order>(sql).ToList();
            }
            return order;
        }
    }
}
