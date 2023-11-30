var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
var app = builder.Build();

List<Todo> TodoList = new List<Todo>();
Todo todo1 = new Todo("Final Project","Work on final project");
TodoList.Add(todo1);

app.UseCors(policy => {
    policy
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod();
});

app.MapGet("/", () => {
    return TodoList.ToArray();
});

app.MapPost("/TodoList", async (Todo todo) => {
    TodoList.Add(todo);
});

app.Run();
