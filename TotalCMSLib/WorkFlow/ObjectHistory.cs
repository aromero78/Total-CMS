﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.WorkFlow {
    public class ObjectHistory {
        int _objectHistoryId;
        public int ObjectHistoryId {
            get;
            set;
        }

        public static List<ObjectHistory> LoadHistory(int ObjectId, WorkFlowObjectTypes ObjectType) {
            throw new NotImplementedException();
        }
    }
}
