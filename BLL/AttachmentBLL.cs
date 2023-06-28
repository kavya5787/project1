using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class AttachmentBLL
{
    public static readonly string TABLE_NAME = "ars_attachment";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "Attachment does not exist.";

    public static int InsertAttachment(Attachment attachment)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IAttachmentDAO attachmentDAO = new AttachmentDAO(con, TABLE_NAME);

            if (attachmentDAO.IsAttachmentAvailableByTitle(attachment))
                throw new DuplicateRecordException("Attachment already exist.");

            return attachmentDAO.Insert(attachment);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateAttachment(Attachment attachment)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IAttachmentDAO attachmentDAO = new AttachmentDAO(con, TABLE_NAME);

            if (!attachmentDAO.IsAttachmentAvailableById(attachment))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return attachmentDAO.Update(attachment);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteAttachment(Attachment attachment)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IAttachmentDAO attachmentDAO = new AttachmentDAO(con, TABLE_NAME);

            if (!attachmentDAO.IsAttachmentAvailableById(attachment))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return attachmentDAO.Delete(attachment);
        }
        catch
        {
            throw;
        }
    }

    public static Attachment GetAttachmentById(Attachment attachment)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IAttachmentDAO attachmentDAO = new AttachmentDAO(con, TABLE_NAME);

            return attachmentDAO.FindById(attachment.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<Attachment> GetAllAttachment()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IAttachmentDAO attachmentDAO = new AttachmentDAO(con, TABLE_NAME);

            return attachmentDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

}