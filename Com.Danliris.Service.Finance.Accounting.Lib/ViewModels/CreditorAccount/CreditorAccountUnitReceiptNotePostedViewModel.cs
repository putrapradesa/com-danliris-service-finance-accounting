﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.CreditorAccount
{
    public class CreditorAccountUnitReceiptNotePostedViewModel : CreditorAccountPostedViewModel
    {
        public long DPP { get; set; }

        public long PPN { get; set; }

        public string Currency { get; set; }
    }
}