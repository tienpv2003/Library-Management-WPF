using System;
using System.Collections.Generic;

namespace LibaryManagement.Models;

public partial class Book
{
    public string BookId { get; set; } = null!;

    public string? BookName { get; set; }

    public int? Amount { get; set; }

    public int? CategoryId { get; set; }

    public string? AuthorId { get; set; }

    public string? PublisherId { get; set; }

    public virtual Author? Author { get; set; }

    public virtual ICollection<BorrowBook> BorrowBooks { get; set; } = new List<BorrowBook>();

    public virtual BookCategory? Category { get; set; }

    public virtual ICollection<Management> Managements { get; set; } = new List<Management>();

    public virtual Publisher? Publisher { get; set; }
}
