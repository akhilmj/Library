using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library.Data.Models
{
    public class Books : Log
    {
        [Column(Order = 0)]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }

        [Column(Order = 1)]
        public string BookName { get; set; }

        [Column(Order = 2)]
        public string AutherName { get; set; }

        [Column(Order = 3)]
        public string PublisherName { get; set; }

        [Column(Order = 4)]
        public DateTime? PublishDate { get; set; }
    }
}
