﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Comments
{
    public class CommentDTO
    {
        public Guid Id { get; set; }
        public string Body { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
