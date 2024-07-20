using System;
using System.Collections.Generic;

namespace LibaryManagement.Models;

public partial class BorrowBook
{
    public int BorrowId { get; set; }

    public string BookId { get; set; } = null!;

    public string StudentId { get; set; } = null!;

    public DateTime? BorrowedDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual ICollection<Management> Managements { get; set; } = new List<Management>();

    public virtual Student Student { get; set; } = null!;
}
