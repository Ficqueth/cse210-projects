public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {

    }
    public void GetRandomPrompt()
    {
        Random random = new Random();

    }
    public List<string> GetListFromUser()
    {
        return _prompts;
    }

}