using System;
using System.Collections.Generic;

namespace newapp.Models;

public partial class Product
{
    public int Productid { get; set; }

    public string? Productname { get; set; }

    public int? Productprice { get; set; }

    public virtual ICollection<Addtocart> Addtocarts { get; set; } = new List<Addtocart>();
}
