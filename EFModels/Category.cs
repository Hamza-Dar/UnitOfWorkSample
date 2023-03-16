using System;
using System.Collections.Generic;

namespace UnitOfWork.EFModels;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? CategoryDescription { get; set; }

    public virtual ICollection<Vendor> Vendors { get; } = new List<Vendor>();
}
