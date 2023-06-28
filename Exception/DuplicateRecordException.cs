using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class DuplicateRecordException : Exception
{
    public DuplicateRecordException()
        : this("Record already exist!")
    {

    }

    public DuplicateRecordException(string message)
        : base(message)
    {
    }

    public DuplicateRecordException(string message, Exception inner)
        : base(message, inner)
    {
    }

}