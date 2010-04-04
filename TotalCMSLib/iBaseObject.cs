using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS
{
    public interface iBaseDataObject
    {
        public void ResetObject();
        public void ResetMemeber(params string PropertyName);
        public void LoadObject();        

    }
}
