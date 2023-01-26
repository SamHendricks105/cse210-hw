using System;

class MathAssignment : Assignment
{
    protected string textBookSection;
    protected string problems;



    public MathAssignment(string _name, string _topic, string _textBookSection, string _problems) : base(_name, _topic) 
    {
        textBookSection = _textBookSection;
        problems = _problems;
    } 

    public string getHomeworkList()
    {
        return $"Section: {textBookSection} Problems: {problems}";
    }




}