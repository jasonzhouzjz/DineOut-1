﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DineOut.Models
{
    public class Restaurant
    {
        [Key]
        [Column("restaurant_id")]
        public int RestaurantId { get; set; }
<<<<<<< HEAD
        [Column("restaurant_name")]
        public string RestaurantName { get; set; }
        [Column("QR_Code")]
        public string QRCode { get; set; }
        [Column("created_on")]
        public DateTime CreatedOn { get; set; }
        public override string ToString()
        {
            return RestaurantName;
        }
=======
        public String OwnerFirstName { get; set; }
        public String OwnerLastName { get; set; }
        public String RestaurantName { get; set; }
        public String QRCode { get; set; }
>>>>>>> Mamadou

    }
}
