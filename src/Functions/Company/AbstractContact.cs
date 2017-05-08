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
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Intacct.Sdk.Functions.Company
{

    abstract public class AbstractContact : AbstractFunction
    {

        public string ContactName;

        public string LastName;

        public string FirstName;

        public string MiddleName;

        public string Prefix;

        public string CompanyName;

        public string PrintAs;

        public bool? Taxable;

        public string TaxId;

        public string ContactTaxGroupName;

        public bool? Active;

        public string PrimaryPhoneNo;

        public string SecondaryPhoneNo;

        public string CellularPhoneNo;

        public string PagerNo;

        public string FaxNo;

        public string PrimaryEmailAddress;

        public string SecondaryEmailAddress;

        public string PrimaryUrl;

        public string SecondaryUrl;

        public string AddressLine1;

        public string AddressLine2;

        public string City;

        public string StateProvince;

        public string ZipPostalCode;

        public string Country;
        
        public AbstractContact(string controlId = null) : base(controlId)
        {
        }

        public void WriteXmlMailAddress(ref IaXmlWriter xml)
        {
            if (
                !String.IsNullOrWhiteSpace(AddressLine1)
                || !String.IsNullOrWhiteSpace(AddressLine2)
                || !String.IsNullOrWhiteSpace(City)
                || !String.IsNullOrWhiteSpace(StateProvince)
                || !String.IsNullOrWhiteSpace(ZipPostalCode)
                || !String.IsNullOrWhiteSpace(Country)
            )
            {
                xml.WriteStartElement("MAILADDRESS");

                xml.WriteElement("ADDRESS1", AddressLine1);
                xml.WriteElement("ADDRESS2", AddressLine2);
                xml.WriteElement("CITY", City);
                xml.WriteElement("STATE", StateProvince);
                xml.WriteElement("ZIP", ZipPostalCode);
                xml.WriteElement("COUNTRY", Country);

                xml.WriteEndElement(); //MAILADDRESS
            }
        }
    }

}