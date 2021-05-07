using System;

namespace Todo.Crud.Models
{
  public class TodoItem
  {
    public long ID { get; set; }
    public string CreatedBy { get; set; }

    public bool IsCompleted { get; set; }

    public string Todo { get; set; }  

    public DateTime DateCreated { get; set; }

    public DateTime DateCompleted { get; set; }
    
  }
}