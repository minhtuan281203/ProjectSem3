using System;
using System.Collections.Generic;

namespace ProjectSem3.Models;

public partial class Candidate
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public int Age { get; set; }

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Literacy { get; set; }

    public string? Majors { get; set; }

    public string? Graduate { get; set; }

    public string? Vacancy { get; set; }

    public string? Description { get; set; }

    public int? AccountId { get; set; }

    public string? File { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<CandidateList> CandidateLists { get; } = new List<CandidateList>();
}
