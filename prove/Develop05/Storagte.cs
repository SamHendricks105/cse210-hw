class Storage
{
    //member varibles
    public int totalPoints;
    public List<Goal> goals;

    //constuctors

    public Storage()
    {

    }  

    //methods

    public void dispalyTotalPoints()
    {
        Console.WriteLine($"You have {totalPoints} points");
    }


}