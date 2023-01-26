using System;

class WritingAssignment : Assignment
{
    protected string title;


    public WritingAssignment(string _name, string _topic, string _title ) : base(_name, _topic)
    {
        title = _title;
    }

    public string getWritingInfo()
    {
        return $"Title: {title}";
    }



}