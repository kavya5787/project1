using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class RecordNotFoundException : Exception
{
    public RecordNotFoundException()
        : this("Record does not exist!")
    {

    }

    public RecordNotFoundException(string message)
        : base(message)
    {
    }

    public RecordNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }

}