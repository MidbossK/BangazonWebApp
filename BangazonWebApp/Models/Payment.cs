﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonWebApp.Models
{
    public class Payment
    {
        [Key]
        public int PaymentTypeId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public ApplicationUser User { get; set; }
    }
}
