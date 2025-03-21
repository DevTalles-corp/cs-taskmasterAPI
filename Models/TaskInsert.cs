using System;

namespace TaskMasterAPI.Models;

public class TaskInsert
{
  public string Title { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
}
