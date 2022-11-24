﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinances.Common
{
    public static class GlobalConstants
    {
        public const string egnPattern = @"^[0-9]{10}$";
        public const string emailPattern = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";
        public const string valuePattern = @"^-?[0-9]{0,10}(\.[0-9]{1,2})?$";
        public const string correctMinBallancePattern = @"^-?[0-9]{1,10}(\.[0-9]{1,2})?$";
        public const string numberPattern = @"^[0-9]*$";
        public const string clientDetailsFormName = "ClientDetails";
        public const string transactDelimiter = "----------------------------------------------------------------------";
        public const string connectionStringName = "PersonalFinances.Properties.Settings.PersonalFinancesConnectionString";
        public const string sortArgsYear = "DOSSIER_YEAR DESC";
    }
}
