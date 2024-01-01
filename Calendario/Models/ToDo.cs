using Calendario.Models;

namespace Calendario.Models;

public class ToDo
{
    public int IdToDo { get; set; }
    public string Content { get; set; } = null!;
    public DateTime? InitialDate { get; set; }
    public DateTime? CloseDate { get; set; }
    public DateTime? LastModifiedDate { get; set;}

}

