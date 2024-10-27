using System;

namespace Model;

public class PrivateTask
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
    public DateTime Deadline { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int BoardId { get; set; }
    public int CategoryId { get; set; }
    public string UserId { get; set; }
}