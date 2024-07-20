using System;
using System.Collections.Generic;

namespace LibaryManagement.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public int RoleId { get; set; }

    public int? ManagementId { get; set; }

    public virtual Management? Management { get; set; }

    public virtual Role Role { get; set; } = null!;
}
