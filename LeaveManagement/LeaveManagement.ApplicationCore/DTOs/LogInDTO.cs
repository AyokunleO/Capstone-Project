﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveManagement.ApplicationCore.DTOs
{
    public class LogInDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
