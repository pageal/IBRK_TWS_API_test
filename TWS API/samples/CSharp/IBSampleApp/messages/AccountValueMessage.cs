/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBSampleApp.messages
{
    class AccountValueMessage 
    {
        private string key;
        private string value;
        private string currency;
        private string accountName;

        public AccountValueMessage(string key, string value, string currency, string accountName)
        {
            Key = key;
            Value = value;
            Currency = currency;
            AccountName = accountName;
        }

        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

    }
}
