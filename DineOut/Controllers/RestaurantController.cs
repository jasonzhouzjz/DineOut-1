﻿using DineOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DineOut.Controllers
{
    public class RestaurantController : Controller
    {
        DineOutContext DineOutContext = new DineOutContext();

        public RestaurantController ()
        {
            
        }


        //This belongs to Order Controller
        //Added here, so we do not forget
        /*public IActionResult CurrentOrders() 
        {
            return View();
        }*/

        //This belongs to Order Controller
        //Added here, so we do not forget
        /*public IActionResult CompletedOrders()
        {
            return View();
        }*/

        // Test View
        public IActionResult Menu()
        {
            int restaurant_id = 3;
            var menud_id = DineOutContext.Menu.Where(r => r.RestaurantId == restaurant_id).FirstOrDefault().MenuId;
            var items = DineOutContext.Item.Where(r => r.MenuId == menud_id).ToList();
            return View("Menu", items);
            //return View("Menu", DineOutContext.Item);

        }
        public IActionResult Edit()
        {
            return View();
        }


        // MENU CRUD
        public IActionResult Add_Menu(int restaurant_id, string menu_title)
        {
            var menu_row = DineOutContext.Menu.Where(r => r.RestaurantId == restaurant_id).FirstOrDefault();

            if (menu_row != null)
            {
                TempData["message"] = $"You already have a menu created!";
                return RedirectToAction("Index");
            }
            else
            {
                Menu menu_object = new Menu();
                menu_object.RestaurantId = restaurant_id;
                var datetime = DateTime.Now.ToString("yyyy-MM-dd");
                menu_object.CreatedOn = DateTime.Today;
                menu_object.Title = menu_title;
                Console.WriteLine(menu_object);

                DineOutContext.Add(menu_object);
                DineOutContext.SaveChanges();

                TempData["message"] = $"Welcome! Your menu has been created!";
                return RedirectToAction("Menu");
            }
        }
        
        public IActionResult Update_Menu(int restaurant_id, int menu_id, string menu_title)
        {
            var menu_row = DineOutContext.Menu.Where(r => r.RestaurantId == restaurant_id)
                .Where(r => r.MenuId == menu_id)
                .FirstOrDefault();

            Menu menu_object = menu_row;

            menu_object.Title = menu_title;
            Console.WriteLine(menu_object);

            DineOutContext.Update(menu_object);
            DineOutContext.SaveChanges();

            TempData["message"] = $"Title updated!";
            return RedirectToAction("Menu");
        }

        public IActionResult Add_Update_Item(Item item)
        {
            if (item.ItemId == 0)
            {
                Console.WriteLine(item);
                DineOutContext.Add(item);
                DineOutContext.SaveChanges();
            }
            else
            {
                Console.WriteLine(item);
                DineOutContext.Update(item);
                DineOutContext.SaveChanges();
                
            }
            return RedirectToAction("Menu");
        }
        public IActionResult Delete_Item(int item_id, int menu_id)
        {
            var item_delete = DineOutContext.Item.Where(r => r.MenuId == menu_id).Where(r => r.ItemId == item_id).FirstOrDefault();
            DineOutContext.Remove(item_delete);
            DineOutContext.SaveChanges();
            return RedirectToAction("Menu");
        }
        
        public IActionResult Update_Item(int itemId, int menuId)
        {
            var item = DineOutContext.Item.Where(r => r.MenuId == menuId).Where(r => r.ItemId == itemId).FirstOrDefault();
            Console.WriteLine(item);
            return View("Edit", item);
        }
    }
}
