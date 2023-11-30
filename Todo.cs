public class Todo
{
    public bool Done { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Todo(string title, string description )
    {   
        Done = false;
        Title = title;
        Description = description;
    }
}