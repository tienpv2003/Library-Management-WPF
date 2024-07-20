using System;
using System.Collections.Generic;

namespace LibaryManagement.Models;

public partial class Publisher
{
    public string PublisherId { get; set; } = null!;

    public string? PublisherName { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
