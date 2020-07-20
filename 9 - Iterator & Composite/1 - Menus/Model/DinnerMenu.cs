﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Model
{
    public class DinerMenu
    {
        const int MAX_ITEMS = 6;
        int _numberOfItems = 0;

        public MenuItem[] MenuItems { get; private set; }

        public DinerMenu()
        {
            MenuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT",
                    "(Fakin') Bacon with lettuce & tomato on whole wheat.",
                    true,
                    2.99);

            AddItem("BLT",
                    "Bacon with lettuce & tomato on whole wheat.",
                    false,
                    2.99);

            AddItem("Soup of the Day",
                    "Soup of the day, with a side of potato salad.",
                    false,
                    3.29);

            AddItem("Hotdog",
                    "A hot dog with saurkraut, relish, onions, topped with cheese.",
                    false,
                    3.05);
        }

        public void AddItem(string name,
                            string description,
                            bool vegetarian,
                            double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu.");
            }
            else
            {
                MenuItems[_numberOfItems] = menuItem;
                _numberOfItems += 1;
            }
        }
    }
}
