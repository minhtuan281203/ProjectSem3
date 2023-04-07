using System;
using System.Collections.Generic;

namespace ProjectSem3.Models;

public partial class Job
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public double Wage { get; set; }

    public string Image { get; set; } = null!;

    public DateTime DateCreate { get; set; }

    public DateTime? Modification { get; set; }

    public string? JobDescription { get; set; }

    public string? Vacancy { get; set; }

    public string? Address { get; set; }

    public string? Tag { get; set; }

    public int? CatId { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<CandidateList> CandidateLists { get; } = new List<CandidateList>();

    public virtual Category? Cat { get; set; }

    public virtual Company? Company { get; set; }
}
