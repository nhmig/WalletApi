﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletRepository.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
