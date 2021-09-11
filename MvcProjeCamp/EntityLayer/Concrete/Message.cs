﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }

        [StringLength(50)]
        public string SenderMail { get; set; }

        [StringLength(50)]
        public string RecelverMail { get; set; }

        [StringLength(100)]
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
        public bool IsDraft { get; set; }
        public bool IsRead { get; set; }
    }
}
