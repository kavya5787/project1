using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class CustomerBLL
{
    public static readonly string TABLE_NAME = "ars_customer";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "Customer does not exist.";

    public static int InsertCustomer(Customer customer)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ICustomerDAO customerDAO = new CustomerDAO(con, TABLE_NAME);

            if (customerDAO.IsUserEmailOrUsernameAvailable(customer.Email, customer.Username))
                throw new DuplicateRecordException("Customer already exist. SignIn to continue..");

            return customerDAO.Insert(customer);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateCustomer(Customer customer)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ICustomerDAO customerDAO = new CustomerDAO(con, TABLE_NAME);

            if (!customerDAO.IsCustomerAvailableById(customer))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return customerDAO.Update(customer);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteCustomer(Customer customer)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ICustomerDAO customerDAO = new CustomerDAO(con, TABLE_NAME);

            return customerDAO.Delete(customer);
        }
        catch
        {
            throw;
        }
    }

    public static Customer GetCustomerById(Customer customer)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ICustomerDAO customerDAO = new CustomerDAO(con, TABLE_NAME);

            return customerDAO.FindById(customer.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<Customer> GetAllCustomer()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ICustomerDAO customerDAO = new CustomerDAO(con, TABLE_NAME);

            return customerDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

    public static Customer IsLoginSuccessful(string emailOrUsername, string password)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ICustomerDAO customerDAO = new CustomerDAO(con, TABLE_NAME);

            return customerDAO.IsLoginSuccessful(emailOrUsername, password);
        }
        catch
        {
            throw;
        }
    }

    public static bool IsUserEmailOrUsernameAvailable(string email, string username)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ICustomerDAO customerDAO = new CustomerDAO(con, TABLE_NAME);

            return customerDAO.IsUserEmailOrUsernameAvailable(email, username);
        }
        catch
        {
            throw;
        }
    }
    public static void UpdatePassword(Customer t)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ICustomerDAO customerDAO = new CustomerDAO(con, TABLE_NAME);

            customerDAO.UpdatePassword(t);
        }
        catch
        {
            throw;
        }
    }

}