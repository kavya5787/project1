using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class PopularDestination
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
    private string _preview;

    public string Preview
    {
        get { return _preview; }
        set { _preview = value; }
    }
    private string _content;

    public string Content
    {
        get { return _content; }
        set { _content = value; }
    }
    private string _image;

    public string Image
    {
        get { return _image; }
        set { _image = value; }
    }

	public PopularDestination()
	{
		
	}
}