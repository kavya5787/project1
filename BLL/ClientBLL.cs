using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class ClientBLL
{
    public static readonly string TABLE_NAME = "ars_client";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "Client does not exist.";

    public static int InsertClient(Client client)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IClientDAO clientDAO = new ClientDAO(con, TABLE_NAME);

            if (clientDAO.IsClientAvailableByTitle(client))
                throw new DuplicateRecordException("Client already exist.");

            return clientDAO.Insert(client);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateClient(Client client)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IClientDAO clientDAO = new ClientDAO(con, TABLE_NAME);

            if (!clientDAO.IsClientAvailableById(client))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return clientDAO.Update(client);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteClient(Client client)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IClientDAO clientDAO = new ClientDAO(con, TABLE_NAME);

            if (!clientDAO.IsClientAvailableById(client))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return clientDAO.Delete(client);
        }
        catch
        {
            throw;
        }
    }

    public static Client GetClientById(Client client)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IClientDAO clientDAO = new ClientDAO(con, TABLE_NAME);

            return clientDAO.FindById(client.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<Client> GetAllClient()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IClientDAO clientDAO = new ClientDAO(con, TABLE_NAME);

            return clientDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

}