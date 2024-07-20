using System;
using System.Collections.Generic;

namespace LibaryManagement.Models;

public partial class Management
{
    public int ManagementId { get; set; }

    public string BookId { get; set; } = null!;

    public string StudentId { get; set; } = null!;

    public int BorrowId { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual BorrowBook Borrow { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
