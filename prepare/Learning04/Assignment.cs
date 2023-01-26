using System;
class Assignment
{
    protected string name;
    protected string topic; 


    public Assignment()
    {

    }
    
    public Assignment(string _name,string _topic)
    {
        name =_name;
        topic = _topic;
    }


    public string getSumary()
    {
        return  $"Student: {name}, Topic: {topic}";
    }



}