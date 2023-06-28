using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class BookingBLL
{
    public static readonly string TABLE_NAME = "ars_booking";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "Booking does not exist.";

    public static int InsertBooking(Booking booking)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBookingDAO bookingDAO = new BookingDAO(con, TABLE_NAME);

            return bookingDAO.Insert(booking);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateBooking(Booking booking)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBookingDAO bookingDAO = new BookingDAO(con, TABLE_NAME);

            if (!bookingDAO.IsBookingAvailableById(booking))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return bookingDAO.Update(booking);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteBooking(Booking booking)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBookingDAO bookingDAO = new BookingDAO(con, TABLE_NAME);

            if (!bookingDAO.IsBookingAvailableById(booking))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return bookingDAO.Delete(booking);
        }
        catch
        {
            throw;
        }
    }

    public static Booking GetBookingById(Booking booking)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBookingDAO bookingDAO = new BookingDAO(con, TABLE_NAME);

            return bookingDAO.FindById(booking.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<Booking> GetAllBooking()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBookingDAO bookingDAO = new BookingDAO(con, TABLE_NAME);

            return bookingDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

    public static bool IsSeatAlreadyBooked(int seat, int flight)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBookingDAO bookingDAO = new BookingDAO(con, TABLE_NAME);

            return bookingDAO.IsSeatAlreadyBooked(seat, flight);
        }
        catch
        {
            throw;
        }
    }

    public static bool IsSeatAlreadyBooked(int seat)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBookingDAO bookingDAO = new BookingDAO(con, TABLE_NAME);

            return bookingDAO.IsSeatAlreadyBooked(seat);
        }
        catch
        {
            throw;
        }
    }

    public static void CancelBooking(Booking t)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBookingDAO bookingDAO = new BookingDAO(con, TABLE_NAME);

            bookingDAO.CancelBooking(t);
        }
        catch
        {
            throw;
        }
    }

    public static bool IsBookingAlreadyCanceled(Booking b)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBookingDAO bookingDAO = new BookingDAO(con, TABLE_NAME);

            return bookingDAO.IsBookingAlreadyCanceled(b);
        }
        catch
        {
            throw;
        }
    }


    public static List<Booking> GetAllBookingByCustomer(Customer customer)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBookingDAO bookingDAO = new BookingDAO(con, TABLE_NAME);

            return bookingDAO.GetAllBookingByCustomer(customer);
        }
        catch
        {
            throw;
        }
    }
}