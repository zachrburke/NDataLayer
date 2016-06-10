﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDataLayer.DigitalData
{
    public class Transaction : DataLayerObject
    {
        public Transaction()
        {
            Profile = new Profile() { ProfileInfo = new ProfileInfo() };
            Total = new CartPrice();
            Items = new List<CartItem>();
        }

        public string TransactionID { get; set; }
        public Profile Profile { get; set; }
        public CartPrice Total { get; set; }

        [JsonProperty("item")]
        public List<CartItem> Items { get; set; }
    }
}
