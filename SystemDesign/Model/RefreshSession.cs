using System;

namespace Model;

public class RefreshSession
{
    public string Token { get; set; }
    public DateTime ExpiresIn { get; set; }
    public string Fingerprint { get; set; }
    public string UserId { get; set; }
}