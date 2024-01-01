﻿using System;
using System.Collections.Generic;

namespace DotNetOfficialExistingDatabase.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
