using System;

namespace Model;

public class ProjectMember
{
    public string UserId { get; set; }
    public int ProjectId { get; set; }
    public bool Status { get; set; }
}