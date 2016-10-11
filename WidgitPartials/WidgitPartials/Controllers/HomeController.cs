using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Widgit.Domain.Models;

namespace Widgit.Domain.Controllers
{
  public class HomeController : Controller
  {
    // GET: Home
    public ActionResult Index(Item item2) //int id
    {
      ViewBag.DropDownQuantity = new SelectList(new[]
      {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
      ViewBag.DropDownStates = new SelectList(new[]
      { "AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY" });

      //var listitem = List(id)
      //view(listitem)
      //Item item = new Item();
      //item.Name = "Lamp";
      //item.Price = 29.99m;
      //item.OnSale = true;
      return View(item2);
    }
    [HttpPost]
    public ActionResult Post(Item item)
    {
      item.FinalPrice = Convert.ToInt32(item.DropDownQuantity) * item.Price;
      if (item.OnSale)
      {
        item.FinalPrice = (item.FinalPrice * (decimal).9);
      }
      if (!item.DropDownStates.Equals("TX") && !item.DropDownStates.Equals("FL"))
      {
        item.FinalPrice = item.FinalPrice * (decimal)1.05;
      }

      item.FinalPrice = decimal.Round(item.FinalPrice.Value, 2, MidpointRounding.AwayFromZero);
      return RedirectToAction("Index", item);
    }
  }
}
//string strDDLValue = Request.Form["DropDownQuantity"].ToString();
