using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class TestimonialBLL
{
    public static readonly string TABLE_NAME = "ars_testinomial";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "Testimonial does not exist.";

    public static int InsertTestimonial(Testimonial testimonial)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ITestimonialDAO testimonialDAO = new TestimonialDAO(con, TABLE_NAME);

            return testimonialDAO.Insert(testimonial);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateTestimonial(Testimonial testimonial)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ITestimonialDAO testimonialDAO = new TestimonialDAO(con, TABLE_NAME);

            if (!testimonialDAO.IsTestimonialAvailableById(testimonial))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return testimonialDAO.Update(testimonial);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteTestimonial(Testimonial testimonial)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ITestimonialDAO testimonialDAO = new TestimonialDAO(con, TABLE_NAME);

            if (!testimonialDAO.IsTestimonialAvailableById(testimonial))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return testimonialDAO.Delete(testimonial);
        }
        catch
        {
            throw;
        }
    }

    public static Testimonial GetTestimonialById(Testimonial testimonial)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ITestimonialDAO testimonialDAO = new TestimonialDAO(con, TABLE_NAME);

            return testimonialDAO.FindById(testimonial.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<Testimonial> GetAllTestimonial()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ITestimonialDAO testimonialDAO = new TestimonialDAO(con, TABLE_NAME);

            return testimonialDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

}