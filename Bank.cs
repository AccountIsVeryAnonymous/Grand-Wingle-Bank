using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Grand_Wingle_Bank
{
    internal class allTransactions
    {
        public List<Transaction> Transactions { get; set; }
        public allTransactions()
        {
            SqlConnection connection = new SqlConnection(Database.connection);
            string transactionsSql = "select * from [dbo].[transaction]";
            connection.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(transactionsSql, connection);
            DataTable bankTransactions = new DataTable();
            adaptor.Fill(bankTransactions);
            connection.Close();
            Transactions = new List<Transaction>();
            foreach (DataRow row in bankTransactions.Rows)
            {
                Transaction t = new Transaction(row);
                Transactions.Add(t);
            }
        }
    }
    internal class allAccounts
    {
        public List<Account> Accounts { get; set; }
        public allAccounts()
        {
            SqlConnection connection = new SqlConnection(Database.connection);
            string accountsSql = "select * from [dbo].[account]";
            connection.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(accountsSql, connection);
            DataTable bankAccounts = new DataTable();
            adaptor.Fill(bankAccounts);
            connection.Close();
            Accounts = new List<Account>();
            foreach (DataRow row in bankAccounts.Rows)
            {
                Account a = new Account(row);
                Accounts.Add(a);
            }
        }
    }
    internal class allSavers
    {
        public List<Saver> Savers { get; set; }
        public allSavers()
        {
            SqlConnection connection = new SqlConnection(Database.connection);
            string saversSql = "select * from [dbo].[saver]";
            connection.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(saversSql, connection);
            DataTable bankSavers = new DataTable();
            adaptor.Fill(bankSavers);
            connection.Close();
            Savers = new List<Saver>();
            foreach (DataRow row in bankSavers.Rows)
            {
                Saver s = new Saver(row);
                Savers.Add(s);
            }
        }
    }
    internal class allUsers
    {
        public List<User> Users { get; set; }
        public allUsers()
        {
            SqlConnection connection = new SqlConnection(Database.connection);
            string usersSql = "select * from [dbo].[user]";
            connection.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(usersSql, connection);
            DataTable bankUsers = new DataTable();
            adaptor.Fill(bankUsers);
            connection.Close();
            Users = new List<User>();
            foreach (DataRow row in bankUsers.Rows)
            {
                User a = new User(row);
                Users.Add(a);
            }
        }
    }
    class Database
    {
        public static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Harve\OneDrive\Documents\Grand Wingle Bank\Bank.mdf"";Integrated Security=True";
    }
}