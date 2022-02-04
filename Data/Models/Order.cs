using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Surname { get; set; }

        [StringLength(20)]
        public string Addres { get; set; }

        [StringLength(13)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [StringLength(20)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
    }
}
