using System;
using System.Collections.Generic;

namespace ProjectSem3.Models;

public partial class Account
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Role { get; set; }

    public virtual ICollection<Candidate> Candidates { get; } = new List<Candidate>();
}
