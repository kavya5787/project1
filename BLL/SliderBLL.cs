using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class SliderBLL
{
    public static readonly string TABLE_NAME = "ars_slider";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "Slider does not exist.";

    public static int InsertSlider(Slider slider)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISliderDAO sliderDAO = new SliderDAO(con, TABLE_NAME);

            if (sliderDAO.IsSliderAvailableByTitle(slider))
                throw new DuplicateRecordException("Slider already exist.");

            return sliderDAO.Insert(slider);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateSlider(Slider slider)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISliderDAO sliderDAO = new SliderDAO(con, TABLE_NAME);

            if (!sliderDAO.IsSliderAvailableById(slider))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return sliderDAO.Update(slider);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteSlider(Slider slider)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISliderDAO sliderDAO = new SliderDAO(con, TABLE_NAME);

            if (!sliderDAO.IsSliderAvailableById(slider))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return sliderDAO.Delete(slider);
        }
        catch
        {
            throw;
        }
    }

    public static Slider GetSliderById(Slider slider)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISliderDAO sliderDAO = new SliderDAO(con, TABLE_NAME);

            return sliderDAO.FindById(slider.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<Slider> GetAllSlider()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISliderDAO sliderDAO = new SliderDAO(con, TABLE_NAME);

            return sliderDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

    public static List<Slider> FindAllSliderByCategory(string category) {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            ISliderDAO sliderDAO = new SliderDAO(con, TABLE_NAME);

            return sliderDAO.FindAllSliderByCategory(category);
        }
        catch
        {
            throw;
        }
    }

}