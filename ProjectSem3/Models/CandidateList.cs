using System;
using System.Collections.Generic;

namespace ProjectSem3.Models;

public partial class CandidateList
{
    public int Id { get; set; }

    public int? JobId { get; set; }

    public int? CanId { get; set; }

    public int? InterviewId { get; set; }

    public virtual Candidate? Can { get; set; }

    public virtual Interview? Interview { get; set; }

    public virtual Job? Job { get; set; }
}
