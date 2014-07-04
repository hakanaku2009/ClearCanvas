#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model.EntityBrokers
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;

    public partial class ExternalRequestQueueSelectCriteria : EntitySelectCriteria
    {
        public ExternalRequestQueueSelectCriteria()
        : base("ExternalRequestQueue")
        {}
        public ExternalRequestQueueSelectCriteria(ExternalRequestQueueSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new ExternalRequestQueueSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="RequestType")]
        public ISearchCondition<String> RequestType
        {
            get
            {
              if (!SubCriteria.ContainsKey("RequestType"))
              {
                 SubCriteria["RequestType"] = new SearchCondition<String>("RequestType");
              }
              return (ISearchCondition<String>)SubCriteria["RequestType"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="RequestXml")]
        public ISearchCondition<XmlDocument> RequestXml
        {
            get
            {
              if (!SubCriteria.ContainsKey("RequestXml"))
              {
                 SubCriteria["RequestXml"] = new SearchCondition<XmlDocument>("RequestXml");
              }
              return (ISearchCondition<XmlDocument>)SubCriteria["RequestXml"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="InsertTime")]
        public ISearchCondition<DateTime> InsertTime
        {
            get
            {
              if (!SubCriteria.ContainsKey("InsertTime"))
              {
                 SubCriteria["InsertTime"] = new SearchCondition<DateTime>("InsertTime");
              }
              return (ISearchCondition<DateTime>)SubCriteria["InsertTime"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="Revision")]
        public ISearchCondition<Int32> Revision
        {
            get
            {
              if (!SubCriteria.ContainsKey("Revision"))
              {
                 SubCriteria["Revision"] = new SearchCondition<Int32>("Revision");
              }
              return (ISearchCondition<Int32>)SubCriteria["Revision"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="ScheduledTime")]
        public ISearchCondition<DateTime> ScheduledTime
        {
            get
            {
              if (!SubCriteria.ContainsKey("ScheduledTime"))
              {
                 SubCriteria["ScheduledTime"] = new SearchCondition<DateTime>("ScheduledTime");
              }
              return (ISearchCondition<DateTime>)SubCriteria["ScheduledTime"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="DeletionTime")]
        public ISearchCondition<DateTime> DeletionTime
        {
            get
            {
              if (!SubCriteria.ContainsKey("DeletionTime"))
              {
                 SubCriteria["DeletionTime"] = new SearchCondition<DateTime>("DeletionTime");
              }
              return (ISearchCondition<DateTime>)SubCriteria["DeletionTime"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="StateXml")]
        public ISearchCondition<XmlDocument> StateXml
        {
            get
            {
              if (!SubCriteria.ContainsKey("StateXml"))
              {
                 SubCriteria["StateXml"] = new SearchCondition<XmlDocument>("StateXml");
              }
              return (ISearchCondition<XmlDocument>)SubCriteria["StateXml"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="OperationToken")]
        public ISearchCondition<String> OperationToken
        {
            get
            {
              if (!SubCriteria.ContainsKey("OperationToken"))
              {
                 SubCriteria["OperationToken"] = new SearchCondition<String>("OperationToken");
              }
              return (ISearchCondition<String>)SubCriteria["OperationToken"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="RequestId")]
        public ISearchCondition<String> RequestId
        {
            get
            {
              if (!SubCriteria.ContainsKey("RequestId"))
              {
                 SubCriteria["RequestId"] = new SearchCondition<String>("RequestId");
              }
              return (ISearchCondition<String>)SubCriteria["RequestId"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="ExternalRequestQueueStatusEnum")]
        public ISearchCondition<ExternalRequestQueueStatusEnum> ExternalRequestQueueStatusEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("ExternalRequestQueueStatusEnum"))
              {
                 SubCriteria["ExternalRequestQueueStatusEnum"] = new SearchCondition<ExternalRequestQueueStatusEnum>("ExternalRequestQueueStatusEnum");
              }
              return (ISearchCondition<ExternalRequestQueueStatusEnum>)SubCriteria["ExternalRequestQueueStatusEnum"];
            } 
        }
    }
}
