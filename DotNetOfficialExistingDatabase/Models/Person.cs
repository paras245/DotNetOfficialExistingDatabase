using System;
using System.Collections.Generic;

namespace DotNetOfficialExistingDatabase.Models;

public partial class Person
{
    public int PersonId { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? PersonDescription { get; set; }

    public string? Gender { get; set; }
}
