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

namespace Intacct.Sdk.Functions.Projects
{

    public class TimesheetEntryCreate : AbstractTimesheetEntry
    {

        public TimesheetEntryCreate()
        {
        }

        public override void WriteXml(ref IaXmlWriter xml)
        {
            xml.WriteStartElement("TIMESHEETENTRY");

            xml.WriteElement("ENTRYDATE", EntryDate, IaXmlWriter.IntacctDateFormat);

            xml.WriteElement("QTY", Quantity, true);

            xml.WriteElement("DESCRIPTION", Description);
            xml.WriteElement("NOTES", Notes);
            xml.WriteElement("TASKKEY", TaskRecordNo);
            xml.WriteElement("TIMETYPE", TimeTypeName);
            xml.WriteElement("BILLABLE", Billable);
    
            xml.WriteElement("EXTBILLRATE", OverrideBillingRate);
            xml.WriteElement("EXTCOSTRATE", OverrideLaborCostRate);

            xml.WriteElement("DEPARTMENTID", DepartmentId);
            xml.WriteElement("LOCATIONID", LocationId);
            xml.WriteElement("PROJECTID", ProjectId);
            xml.WriteElement("CUSTOMERID", CustomerId);
            xml.WriteElement("VENDORID", VendorId);
            xml.WriteElement("ITEMID", ItemId);
            xml.WriteElement("CLASSID", ClassId);
            xml.WriteElement("CONTRACTID", ContractId);
            xml.WriteElement("WAREHOUSEID", WarehouseId);

            xml.WriteCustomFieldsImplicit(CustomFields);
            
            xml.WriteEndElement(); //TIMESHEETENTRY
        }

    }

}