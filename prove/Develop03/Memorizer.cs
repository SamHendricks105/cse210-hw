using System;

class Memorizer
{
    private Scripture scripture;

    private List<string> scriptureTextList;

    public Memorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scriptureTextList = new List<string>();
        convertTexttolist();
    }

    private void convertTexttolist()
    {
        scriptureTextList =scripture.toString().Split(' ').ToList();
    }

    public void removeWordsFromList()
    {
        int numWordsToRemove = new Random().Next(2,4);
        int wordsRemved = 0;

        do
        {
            int random = new Random().Next(0, scriptureTextList.Count());
            if(scriptureTextList[random].Contains('_') == false)    
            {
            scriptureTextList[random] = new string('_', scriptureTextList[random].Length);
            wordsRemved++;
            }
        }while (wordsRemved != numWordsToRemove);
    }

    public string toString()
    {
        return string.Join(' ', scriptureTextList);
    }

    public bool hasWordsLeft()
    {
        bool retvalue= false;
        foreach(string word in scriptureTextList)
        {
            if (word.Contains("_") == false)
            {
                retvalue = true;
                break;
            }
        }

        return retvalue;
    }

}