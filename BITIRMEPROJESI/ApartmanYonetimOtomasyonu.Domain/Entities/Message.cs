﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetimOtomasyonu.Domain.Entities
{
    public class Message : BaseEntity
    {
        public string MessageContent { get; set; }
        public string SenderEmail { get; set; }
        public string SenderId { get; set; }
        public string ReceiverEmail { get; set; }
        public string ReceiverId { get; set; }
        public bool IsRead { get; set; }
    }
}
