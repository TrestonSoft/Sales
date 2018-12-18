﻿namespace Sales.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Products
    {
        [Key]
        public int ProductID { get; set; } 

        [Required]
        public string Description { get; set; }

        public Decimal Price { get; set; }

        public bool isAvaible { get; set; }

        public DateTime PublishOn { get; set; }


    }
}
