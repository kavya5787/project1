using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class SeatBLL
{
    public static readonly string TABLE_NAME = "ars_seat";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "Seat does not exist.";

    public static int InsertSeat(Seat seat)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISeatDAO seatDAO = new SeatDAO(con, TABLE_NAME);

            if (seatDAO.IsSeatAvailableByTitle(seat))
                throw new DuplicateRecordException("Seat already exist.");

            return seatDAO.Insert(seat);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateSeat(Seat seat)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISeatDAO seatDAO = new SeatDAO(con, TABLE_NAME);

            if (!seatDAO.IsSeatAvailableById(seat))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return seatDAO.Update(seat);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteSeat(Seat seat)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISeatDAO seatDAO = new SeatDAO(con, TABLE_NAME);

            if (!seatDAO.IsSeatAvailableById(seat))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return seatDAO.Delete(seat);
        }
        catch
        {
            throw;
        }
    }

    public static Seat GetSeatById(Seat seat)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISeatDAO seatDAO = new SeatDAO(con, TABLE_NAME);

            return seatDAO.FindById(seat.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<Seat> GetAllSeat()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISeatDAO seatDAO = new SeatDAO(con, TABLE_NAME);

            return seatDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

    public static List<Seat> GetAllSeatBySeatType(SeatType seatType)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISeatDAO seatDAO = new SeatDAO(con, TABLE_NAME);

            return seatDAO.GetAllSeatBySeatType(seatType);
        }
        catch
        {
            throw;
        }
    }

}