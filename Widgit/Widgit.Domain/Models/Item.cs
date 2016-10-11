using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Widgit.Domain.Models
{
  public class Item
  {
    public string Name{ get; set; }
    public decimal? Price{ get; set; }
    public bool OnSale { get; set; }

    public string DropDownQuantity { get; set; }
    public SelectList Quantity { get; set; }
    public string DropDownStates { get; set; }
    public SelectList States { get; set; }

    public decimal? FinalPrice { get; set; }

  }
}