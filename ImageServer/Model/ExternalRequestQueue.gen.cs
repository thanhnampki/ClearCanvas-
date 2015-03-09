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

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Enterprise.Command;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class ExternalRequestQueue: ServerEntity
    {
        #region Constructors
        public ExternalRequestQueue():base("ExternalRequestQueue")
        {}
        public ExternalRequestQueue(
             String _requestType_
            ,XmlDocument _requestXml_
            ,DateTime _insertTime_
            ,Int32 _revision_
            ,DateTime _scheduledTime_
            ,DateTime? _deletionTime_
            ,XmlDocument _stateXml_
            ,String _operationToken_
            ,String _requestId_
            ,ExternalRequestQueueStatusEnum _externalRequestQueueStatusEnum_
            ):base("ExternalRequestQueue")
        {
            RequestType = _requestType_;
            RequestXml = _requestXml_;
            InsertTime = _insertTime_;
            Revision = _revision_;
            ScheduledTime = _scheduledTime_;
            DeletionTime = _deletionTime_;
            StateXml = _stateXml_;
            OperationToken = _operationToken_;
            RequestId = _requestId_;
            ExternalRequestQueueStatusEnum = _externalRequestQueueStatusEnum_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="RequestType")]
        public String RequestType
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="RequestXml")]
        public XmlDocument RequestXml
        { get { return _RequestXml; } set { _RequestXml = value; } }
        [NonSerialized]
        private XmlDocument _RequestXml;
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="InsertTime")]
        public DateTime InsertTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="Revision")]
        public Int32 Revision
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="ScheduledTime")]
        public DateTime ScheduledTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="DeletionTime")]
        public DateTime? DeletionTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="StateXml")]
        public XmlDocument StateXml
        { get { return _StateXml; } set { _StateXml = value; } }
        [NonSerialized]
        private XmlDocument _StateXml;
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="OperationToken")]
        public String OperationToken
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="RequestId")]
        public String RequestId
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="ExternalRequestQueue", ColumnName="ExternalRequestQueueStatusEnum")]
        public ExternalRequestQueueStatusEnum ExternalRequestQueueStatusEnum
        { get; set; }
        #endregion

        #region Static Methods
        static public ExternalRequestQueue Load(ServerEntityKey key)
        {
            using (var context = new ServerExecutionContext())
            {
                return Load(context.ReadContext, key);
            }
        }
        static public ExternalRequestQueue Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IExternalRequestQueueEntityBroker>();
            ExternalRequestQueue theObject = broker.Load(key);
            return theObject;
        }
        static public ExternalRequestQueue Insert(ExternalRequestQueue entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                ExternalRequestQueue newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public ExternalRequestQueue Insert(IUpdateContext update, ExternalRequestQueue entity)
        {
            var broker = update.GetBroker<IExternalRequestQueueEntityBroker>();
            var updateColumns = new ExternalRequestQueueUpdateColumns();
            updateColumns.RequestType = entity.RequestType;
            updateColumns.RequestXml = entity.RequestXml;
            updateColumns.InsertTime = entity.InsertTime;
            updateColumns.Revision = entity.Revision;
            updateColumns.ScheduledTime = entity.ScheduledTime;
            updateColumns.DeletionTime = entity.DeletionTime;
            updateColumns.StateXml = entity.StateXml;
            updateColumns.OperationToken = entity.OperationToken;
            updateColumns.RequestId = entity.RequestId;
            updateColumns.ExternalRequestQueueStatusEnum = entity.ExternalRequestQueueStatusEnum;
            ExternalRequestQueue newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}