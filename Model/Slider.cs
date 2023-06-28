using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Slider
{
    private int _id;

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

    private string _image;

    public string Image
    {
        get { return _image; }
        set { _image = value; }
    }
    private string _category;

    public string Category
    {
        get { return _category; }
        set { _category = value; }
    }

    public Slider()
    {
    }

}