using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class UserBLL
{
    public static readonly string TABLE_NAME = "ars_user";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "User does not exist.";

    public static int InsertUser(User user)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IUserDAO userDAO = new UserDAO(con, TABLE_NAME);

            if (userDAO.IsUserUsernameAvailable(user.Username))
                throw new DuplicateRecordException("User already exist.");

            return userDAO.Insert(user);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateUser(User user)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IUserDAO userDAO = new UserDAO(con, TABLE_NAME);

            if (!userDAO.IsUserAvailableById(user))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return userDAO.Update(user);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteUser(User user)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IUserDAO userDAO = new UserDAO(con, TABLE_NAME);

            if (!userDAO.IsUserAvailableById(user))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return userDAO.Delete(user);
        }
        catch
        {
            throw;
        }
    }

    public static User GetUserById(User user)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IUserDAO userDAO = new UserDAO(con, TABLE_NAME);

            return userDAO.FindById(user.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<User> GetAllUser()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IUserDAO userDAO = new UserDAO(con, TABLE_NAME);

            return userDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

    public static User IsLoginSuccessful(string emailOrUsername, string password) {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IUserDAO userDAO = new UserDAO(con, TABLE_NAME);

            return userDAO.IsLoginSuccessful(emailOrUsername, password);
        }
        catch
        {
            throw;
        }
    }

    public static bool IsUserUsernameAvailable(string username)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IUserDAO userDAO = new UserDAO(con, TABLE_NAME);

            return userDAO.IsUserUsernameAvailable(username);
        }
        catch
        {
            throw;
        }
    }
    public static void UpdatePassword(User t) {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IUserDAO userDAO = new UserDAO(con, TABLE_NAME);

            userDAO.UpdatePassword(t);
        }
        catch
        {
            throw;
        }
    }

}