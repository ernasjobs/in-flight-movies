public class Movie
{
    private string title;
    private int runtime;
   
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public int Runtime
    {
        get { return runtime; }
        set { runtime = value; }
    }

    public override string ToString()
    {
        return  Title + " " + Runtime;
    }
   
   
   
}