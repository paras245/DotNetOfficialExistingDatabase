using System;
using System.Collections.Generic;

namespace DotNetOfficialExistingDatabase.Models;

public partial class EmployeesAngular
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public long Phone { get; set; }

    public long Salary { get; set; }

    public string? Department { get; set; }
}
