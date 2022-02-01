using System;
using System.Collections.Generic;
using System.Text;

namespace WhatCouldThisBe
{
    class FaustItem : Item
    {
        public List<FaustItem> faustItems;
        //public int itemsInPossession;
        public FaustItem(string _name, int _id) : base(_name, _id)
        {
            faustItems = new List<FaustItem>();
            //itemsInPosession = faustItems.Count;
        }

        public void AddItems(FaustItem aFaustItem)
        {
            faustItems.Add(aFaustItem);
        }
    }
}
