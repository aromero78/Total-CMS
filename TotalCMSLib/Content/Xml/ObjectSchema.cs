using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace TotalCMS.Content.Xml {
    public class ObjectSchema : BaseDataObject, iWorkFlowItem {
        int _objectSchemaId;
        public int ObjectSchemaId {
            get { return _objectSchemaId; }
        }

        XmlSchema _schemaXml;
        string _schemaXmlUri;
        public XmlSchema SchemaXml {
            get { 
                if(_schemaXml == null && _schemaXmlUri != string.Empty){
                    XmlTextReader reader = new XmlTextReader(SiteSettings.ContextData.MapPath(_schemaXmlUri));
                    _schemaXml = XmlSchema.Read(reader, delegate(object sender, ValidationEventArgs args){
                        SiteSettings.ContextData.DebugLog.WriteDebugMessage((args.Severity == XmlSeverityType.Warning ?"WARNING: ":"ERROR: ") + args.Message);
                    });
                }
                return _schemaXml; 
            }
        }

        ObjectType _type;
        int _objectTypeId;
        public ObjectType Type {
            get { 
                return _type; 
            }
        }

        protected internal override void Reset() {
            throw new NotImplementedException();
        }

        protected internal override void Load() {
            throw new NotImplementedException();
        }

        protected internal override void Save() {
            throw new NotImplementedException();
        }

        protected internal override void Update() {
            throw new NotImplementedException();
        }

        protected internal override void Delete() {
            throw new NotImplementedException();
        }

        #region iWorkFlowItem Members

        public void CheckOut() {
            throw new NotImplementedException();
        }

        public void CheckIn() {
            throw new NotImplementedException();
        }

        public void Stage() {
            throw new NotImplementedException();
        }

        public void Publish() {
            throw new NotImplementedException();
        }

        #endregion
    }
}
