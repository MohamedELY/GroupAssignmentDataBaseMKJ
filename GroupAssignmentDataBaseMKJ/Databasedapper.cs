﻿using System;
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
        /// <summary>
        /// The connection string
        /// </summary>
        static string connString = "data source=.\\SQLEXPRESS; initial catalog = Webshop; persist security info = True; Integrated Security = True;";

        /// <summary>
        /// Shows all categories.
        /// </summary>
        /// <returns> a list of the class Category</returns>
        public static List<Models.Category> ShowAllCategories()
        {
            string sql = "SELECT * FROM categories";
            var categories = new List<Models.Category>();

            using (var connectin = new SqlConnection(connString))
            {
                categories = connectin.Query<Models.Category>(sql).ToList();
            }

            return categories;
        }

        /// <summary>
        /// Shows all carts.
        /// </summary>
        /// <returns>a list of the class Cart</returns>
        public static List<Models.Cart> ShowAllCart()
        {
            string sql = "SELECT * FROM Cart";
            var cart = new List<Models.Cart>();

            using (var connectin = new SqlConnection(connString))
            {
                cart = connectin.Query<Models.Cart>(sql).ToList();
            }

            return cart;
        }

        /// <summary>
        /// Shows all customers.
        /// </summary>
        /// <returns>a list of the class Customer</returns>
        public static List<Models.Customer> ShowAllCustomers()
        {
            string sql = "SELECT * FROM Customers";
            var customers = new List<Models.Customer>();

            using (var connectin = new SqlConnection(connString))
            {
                customers = connectin.Query<Models.Customer>(sql).ToList();
            }

            return customers;
        }

        /// <summary>
        /// Shows all shippers.
        /// </summary>
        /// <returns>a list of the class Shipper</returns>
        public static List<Models.Shipper> ShowAllShippers()
        {
            string sql = "SELECT * FROM Shippers";
            var shippers = new List<Models.Shipper>();

            using (var connectin = new SqlConnection(connString))
            {
                shippers = connectin.Query<Models.Shipper>(sql).ToList();
            }

            return shippers;
        }

        /// <summary>
        /// Shows all products.
        /// </summary>
        /// <returns>a list of the class product</returns>
        public static List<Models.Product> ShowAllProducts()
        {
            string sql = "SELECT * FROM Products";
            var products = new List<Models.Product>();

            using (var connectin = new SqlConnection(connString))
            {
                products = connectin.Query<Models.Product>(sql).ToList();
            }

            return products;
        }

        /// <summary>
        /// Shows specific category products.
        /// </summary>
        /// <returns>a list of the class product</returns>
        public static List<Models.Product> ShowSpecificProducts(int num)
        {
            string sql = $"SELECT * FROM Products WHERE CategoryID = {num}";
            var products = new List<Models.Product>();

            using (var connectin = new SqlConnection(connString))
            {
                products = connectin.Query<Models.Product>(sql).ToList();
            }

            return products;
        }

        /// <summary>
        /// Shows all inventory from the database
        /// </summary>
        /// <returns>a list of the class Inventory</returns>
        public static List<Models.Inventory> ShowAllInventory()
        {
            string sql = "SELECT * FROM Inventory";
            var inventory = new List<Models.Inventory>();

            using (var connectin = new SqlConnection(connString))
            {
                inventory = connectin.Query<Models.Inventory>(sql).ToList();
            }

            return inventory;
        }

        /// <summary>
        /// Shows all order details from the database
        /// </summary>
        /// <returns>a list of the class OrderDetail</returns>
        public static List<Models.OrderDetail> ShowAllOrderDetail()
        {
            string sql = "SELECT * FROM OrderDetails";
            var orderDetails = new List<Models.OrderDetail>();

            using (var connectin = new SqlConnection(connString))
            {
                orderDetails = connectin.Query<Models.OrderDetail>(sql).ToList();
            }

            return orderDetails;
        }

        /// <summary>
        /// Shows all orders from the database
        /// </summary>
        /// <returns>a list of the class Order</returns>
        public static List<Models.Order> ShowAllOrders()
        {
            string sql = "SELECT * FROM Orders";
            var order = new List<Models.Order>();

            using (var connectin = new SqlConnection(connString))
            {
                order= connectin.Query<Models.Order>(sql).ToList();
            }

            return order;
        }

        
    }
}
