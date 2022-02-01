using System;
using System.Collections.Generic;
using System.Text;

namespace WhatCouldThisBe
{
    public abstract class Item
    {
       

        public Item(string _name, int _id)
        {
            name = _name;
            id = _id;
            
        }

        protected string name { get; private set; }
        protected int id { get; private set; }
        protected int price { get; private set; }
        public string description;

        /*public string GetName()
        {
            return name;
        }*/


    }
}
