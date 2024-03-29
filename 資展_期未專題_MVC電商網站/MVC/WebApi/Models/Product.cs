﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Product
    {
        public Product()
        {
            Blog = new HashSet<Blog>();
            Order = new HashSet<Order>();
            Schedule = new HashSet<Schedule>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Size { get; set; }
        public string Flavor { get; set; }
        public string Price { get; set; }
        public string ImageName { get; set; }
        public bool? Avalible { get; set; }
        public string Tag { get; set; }
        public string Category { get; set; }
        public string Description { get; set; } 

        public virtual ICollection<Blog> Blog { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}