﻿/*
 * Copyright 2017 Intacct Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not
 * use this file except in compliance with the License. You may obtain a copy 
 * of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * or in the "LICENSE" file accompanying this file. This file is distributed on 
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either 
 * express or implied. See the License for the specific language governing 
 * permissions and limitations under the License.
 */

using Intacct.Sdk.Xml;
using System;

namespace Intacct.Sdk.Functions.CashManagement
{

    public class DepositCreate : AbstractDeposit
    {

        public DepositCreate(string controlId = null) : base(controlId)
        {
        }

        public override void WriteXml(ref IaXmlWriter xml)
        {
            xml.WriteStartElement("function");
            xml.WriteAttribute("controlid", ControlId, true);

            xml.WriteStartElement("record_deposit");
            
            xml.WriteElement("bankaccountid", BankAccountId, true);
            
            xml.WriteStartElement("depositdate");
            xml.WriteDateSplitElements(DepositDate);
            xml.WriteEndElement(); //depositdate

            xml.WriteElement("depositid", DepositSlipId, true);
            
            xml.WriteStartElement("receiptkeys");
            if (TransactionsKeysToDeposit.Count > 0)
            {
                foreach (int Key in TransactionsKeysToDeposit)
                {
                   xml.WriteElement("receiptkey", Key, true);
                }
            }
            xml.WriteEndElement(); //receiptkeys

            xml.WriteElement("description", Description);

            xml.WriteElement("supdocid", AttachmentsId);

            xml.WriteCustomFieldsExplicit(CustomFields);

            xml.WriteEndElement(); //record_deposit

            xml.WriteEndElement(); //function
        }

    }

}