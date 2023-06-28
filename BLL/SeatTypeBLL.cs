using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class SeatTypeBLL
{
    public static readonly string TABLE_NAME = "ars_seat_type";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "SeatType does not exist.";

    public static int InsertSeatType(SeatType seatType)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISeatTypeDAO seatTypeDAO = new SeatTypeDAO(con, TABLE_NAME);

            if (seatTypeDAO.IsSeatTypeAvailableByTitle(seatType))
                throw new DuplicateRecordException("SeatType already exist.");

            return seatTypeDAO.Insert(seatType);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateSeatType(SeatType seatType)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISeatTypeDAO seatTypeDAO = new SeatTypeDAO(con, TABLE_NAME);

            if (!seatTypeDAO.IsSeatTypeAvailableById(seatType))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return seatTypeDAO.Update(seatType);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteSeatType(SeatType seatType)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISeatTypeDAO seatTypeDAO = new SeatTypeDAO(con, TABLE_NAME);

            if (!seatTypeDAO.IsSeatTypeAvailableById(seatType))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return seatTypeDAO.Delete(seatType);
        }
        catch
        {
            throw;
        }
    }

    public static SeatType GetSeatTypeById(SeatType seatType)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISeatTypeDAO seatTypeDAO = new SeatTypeDAO(con, TABLE_NAME);

            return seatTypeDAO.FindById(seatType.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<SeatType> GetAllSeatType()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISeatTypeDAO seatTypeDAO = new SeatTypeDAO(con, TABLE_NAME);

            return seatTypeDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

}