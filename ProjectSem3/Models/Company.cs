using System;
using System.Collections.Generic;

namespace ProjectSem3.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Job> Jobs { get; } = new List<Job>();
}
