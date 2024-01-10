namespace EntityWPFDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductPrice
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [Required]
        public string Size { get; set; }

        public double Price { get; set; }

        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateModified { get; set; }

        public string ModifiedBy { get; set; }

        public virtual Product Product { get; set; }
    }
}
