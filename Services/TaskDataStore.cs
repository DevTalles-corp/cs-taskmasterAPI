namespace TaskMasterAPI.Services;

public class TaskDataStore
{
  public List<Models.Task> Tasks { get; set; }

  public static TaskDataStore Current { get; } = new TaskDataStore();

  public TaskDataStore()
  {
    Tasks =
    [
      new Models.Task(){
            Id = 1,
            Title = "Aprender C#",
            Description = "Aprender los fundamentos C#",
            IsCompleted = false,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        },
        new Models.Task(){
            Id = 2,
            Title = "Aprender ASP.NET Core",
            Description = "Aprender los fundamentos ASP.NET Core",
            IsCompleted = false,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        },
        new Models.Task(){
            Id = 3,
            Title = "Aprender Entity Framework Core",
            Description = "Aprender los fundamentos Entity Framework Core",
            IsCompleted = false,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        }
    ];
  }
}