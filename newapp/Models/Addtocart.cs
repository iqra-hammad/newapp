using System;
using System.Collections.Generic;

namespace newapp.Models;

public partial class Addtocart
{
    public int Cartid { get; set; }

    public int? Itemquantity { get; set; }

    public int? PNo { get; set; }

    public virtual Product? PNoNavigation { get; set; }
}
