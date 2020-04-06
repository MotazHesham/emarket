using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace emarket.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
        // Add methods or add new properties
    }

    // Specifies the metadata class to associate with a data model class 
    public class ProductMetaData 
    {
        public int Id { get; set; }

        public string name { get; set; }

        public Nullable<double> price { get; set; }

        public string image { get; set; }

        public string description { get; set; }


        [Display(Name = "Category")]
        public Nullable<int> category_id { get; set; }

        public virtual Category Category { get; set; }

    }
}