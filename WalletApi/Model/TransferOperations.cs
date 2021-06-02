﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalletApi.Model
{
    public class TransferOperations
    {
        public Guid User { get; set; }
        public string FromTikerCurrency { get; set; }
        public string ToTikerCurrency { get; set; }
        public decimal Amount { get; set; }
    }
}
