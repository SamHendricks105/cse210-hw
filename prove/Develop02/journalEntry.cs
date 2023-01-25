// The journalEntry class will be used store induvidual enteries.
public class journalEntry 
{
    // member varibles
    public string _entry= "";
    public string _date ="";
    public string _prompt ="";

    //constructor
    public journalEntry()
    {
    }

    // functions
    
    // The Get entry function will be used to get a new entry from the user.
    public int getEntryPrompt()
       {
           // A randrom number fro 0-4 will be gerrated to determine the prompt
            Random ran = new Random();
            int prom = ran.Next(5);
           return prom;
            
        }
    
    public void displayEntry()
    {
         Console.WriteLine($"{_date}"); 
         Console.WriteLine($"{_prompt}"); 
         Console.WriteLine($"{_entry}");
    }
}
//.....................................................