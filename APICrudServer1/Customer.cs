﻿using System.ComponentModel.DataAnnotations;

namespace APICrudServer1
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [StringLength(75)]
        public string FirstName { get; set; } = "";

        [StringLength(75)]
        public string LastName { get; set; } = "";

        [StringLength(50)]
        public string PhoneNo { get; set; } = "";

        [StringLength(75)]
        public string EmailId { get; set; } = "";

    }
}
