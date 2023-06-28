using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Testimonial
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
    private string _content;

    public string Content
    {
        get { return _content; }
        set { _content = value; }
    }
    private string _icon;

    public string Icon
    {
        get { return _icon; }
        set { _icon = value; }
    }

    public Testimonial()
    {
    }
    public Testimonial(int id)
    {
        _id = id;
    }

    public Testimonial(string title, string content, string icon)
    {
        this._title = title;
        this._content = content;
        this._icon = icon;
    }

    public Testimonial(int id, string title, string content, string icon)
    {
        this._id = id;
        this._title = title;
        this._content = content;
        this._icon = icon;
    }


}