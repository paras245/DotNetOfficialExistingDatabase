using System;
using System.Collections.Generic;

namespace DotNetOfficialExistingDatabase.Models;

public partial class Student
{
    public int Id { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentEmail { get; set; } = null!;

    public string StudentAddress { get; set; } = null!;

    public int StudentAge { get; set; }
}
