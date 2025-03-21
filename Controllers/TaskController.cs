using Microsoft.AspNetCore.Mvc;
using TaskMasterAPI.Services;

namespace TaskMasterAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
//api/task
public class TaskController : ControllerBase
{
  [HttpGet]
  public ActionResult<IEnumerable<Models.Task>> GetTasks()
  {
    return Ok(TaskDataStore.Current.Tasks);
  }
  [HttpGet("{id}")]
  public ActionResult<Models.Task> GetTask(int id)
  {
    var task = TaskDataStore.Current.Tasks.FirstOrDefault(t => t.Id == id);
    if (task == null)
    {
      return NotFound("No se encontró la tarea");
    }
    return Ok(task);
  }
  [HttpPost]
  public ActionResult<Models.Task> CreateTask(Models.TaskInsert taskInsert)
  {
    var newTask = new Models.Task
    {
      Id = TaskDataStore.Current.Tasks.Max(t => t.Id) + 1,
      CreatedAt = DateTime.Now,
      UpdatedAt = DateTime.Now,
      IsCompleted = false,
      Title = taskInsert.Title,
      Description = taskInsert.Description
    };
    TaskDataStore.Current.Tasks.Add(newTask);
    return Ok(newTask);
  }
}
