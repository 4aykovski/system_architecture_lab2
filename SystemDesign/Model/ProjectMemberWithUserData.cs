namespace Model;

public class ProjectMemberWithUserData
{
    public string UserId { get; set; }
    public int ProjectId { get; set; }
    public bool Status { get; set; }
    public User UserData { get; set; }
}