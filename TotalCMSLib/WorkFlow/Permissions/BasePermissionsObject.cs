﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.WorkFlow.Permissions {
    /// <summary>
    /// The base permissions abstract class allows for a separation of the permission and workflow functions. This allows for
    /// a concrete workflow object that is not subject to the functionality found in this class.
    /// </summary>
    public abstract class BasePermissionsObject : WorkFlowObject{
        List<ObjectHistory> _versionHistory;
        public System.Collections.ObjectModel.ReadOnlyCollection<ObjectHistory> VersionHistroy {
            get {
                if (_versionHistory == null) {
                    _versionHistory = ObjectHistory.LoadHistory(GetObjectId(), null, ObjectType, null, null, null);
                }
                return _versionHistory.AsReadOnly();
            }
        }

        public bool RollBack(ObjectHistory RollBackTo) {
            //SystemMessage = string.Empty;
            if (HasDeleteRights()) {
                int RowsAffected = SiteSettings.DataAccess.WorkFlowObjectRollBack(RollBackTo);
                if (RowsAffected > 0) {
                    _versionHistory = null;
                    AssignRollBackData(RollBackTo);
                    return true;
                }
                else {
                    //SystemMessage = "Unable to roll back object in the database.";
                    return false;
                }
            }
            else {
                //SystemMessage = "The current user does not have rights to delete/manage history for the requested object";
                return false;
            }
        }

        protected abstract void AssignRollBackData(ObjectHistory RollBackTo);

        public override bool Approve() {
            bool ReturnValue = base.Approve();
            if (ReturnValue)
                _versionHistory = null;
            return ReturnValue;
        }

        public override bool CheckIn() {
            bool ReturnValue = base.CheckIn();
            if (ReturnValue)
                _versionHistory = null;
            return ReturnValue;
        }
    }
}
