﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SportsStore.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue =false)]
        public int ProductID { get; set; }

        [Required(ErrorMessage ="Proszę podać nazwę produktu.")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Proszę podać opis.")]
        public string Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage ="Proszę podać dodatnią cenę.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage ="Proszę określic kategorię.")]
        public string Category { get; set; }

        public byte[] ImageData { get; set; }

        [HiddenInput(DisplayValue =false)]
        public string ImageMimeType { get; set; }
    }
}
