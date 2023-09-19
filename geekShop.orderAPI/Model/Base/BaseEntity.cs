﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShop.OrderAPI.Model.Base
{
    public class BaseEntity
    {

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
    }
}
