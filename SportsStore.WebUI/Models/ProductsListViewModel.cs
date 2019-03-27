﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.HtmlHelpers;

namespace SportsStore.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; } 
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }

    }
}