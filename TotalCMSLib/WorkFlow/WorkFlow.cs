﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.WorkFlow {
    public class WorkFlow : BaseDataObject<WorkFlow> {
        int _workFlowId;
        public int WorkFlowid {
            get {
                return _workFlowId;
            }
        }

        internal WorkFlow(int WorkFlowId) {
            _workFlowId = WorkFlowId;
        }

        List<WorkFlowStep> _steps;
        public List<WorkFlowStep> Steps {
            get {
                if (_steps == null) {
                    System.Data.Common.DbDataReader Reader = SiteSettings.DataAccess.WorkFlowGetSteps(this);
                    while (Reader.Read()) { 
                        _steps.Add(new WorkFlowStep(Reader.GetInt32(0), this, Reader.GetInt32(1)));
                    }
                    Reader.Close();
                }
                return _steps;
            }
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        protected internal override void LoadData(out string SystemMessage) {
            throw new NotImplementedException();
        }

        protected internal override bool SaveData(out string SystemMessage) {
            throw new NotImplementedException();
        }

        protected internal override bool UpdateData(out string SystemMessage) {
            throw new NotImplementedException();
        }

        protected internal override bool DeleteData(out string SystemMessage) {
            throw new NotImplementedException();
        }

        protected internal override int GetObjectId() {
            return _workFlowId;
        }

        protected internal override bool UseCache() {
            return false;
        }
    }
}
