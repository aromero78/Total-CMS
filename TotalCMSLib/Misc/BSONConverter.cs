using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Misc {
    public class BSONResolver : Newtonsoft.Json.Serialization.DefaultContractResolver {
        public BSONResolver() { 
            
        }

        protected override Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(Type objectType) {
            Newtonsoft.Json.Serialization.JsonObjectContract jContract = base.CreateObjectContract(objectType);
            if (objectType.IsSubclassOf(typeof(BaseDataObject))) {
                jContract.Converter = new BaseDataObjectConverter();
            }
            return jContract;
        }
    }

    public class BaseDataObjectConverter : Newtonsoft.Json.JsonConverter {
        public override bool CanConvert(Type objectType) {
            return (objectType.IsSubclassOf(typeof(BaseDataObject))? true: false);
        }

        public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) {
            BaseDataObject baseObj = (BaseDataObject)System.Activator.CreateInstance(objectType);
            baseObj.SetObjectId((int)existingValue);
            baseObj.Load();
            return baseObj;
        }

        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) {
            writer.WriteValue(((BaseDataObject)value).GetObjectId());
        }
    }
}
