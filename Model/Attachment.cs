using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Attachment
{
    private int _id = -1;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private string _title;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }
    private string _path;

    public string Path
    {
        get { return _path; }
        set { _path = value; }
    }

    public Attachment()
    {

    }

    public bool IsAvailable() {
        if (_id == -1 || string.IsNullOrEmpty(_title) || string.IsNullOrEmpty(_path)) {
            return false;
        }

        return true;
    }

}