using System;
using System.Collections.Generic;

namespace ProjectSem3.Models;

public partial class Interview
{
    public int Id { get; set; }

    public DateTime? InterDate { get; set; }

    public string? Static { get; set; }

    public string? FullName { get; set; }

    public virtual ICollection<CandidateList> CandidateLists { get; } = new List<CandidateList>();
}
