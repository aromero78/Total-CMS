using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.Schema;

namespace TotalTech.CMS.Content.Xml {
    /// <summary>
    /// Used as the definition for data within a content item.
    /// </summary>
    public class ObjectType : BaseWorkFlowObject<ObjectType> {
        const string WARNING = "WARNING: ", ERROR = "ERROR: ";

        int _objectTypeId;
        /// <summary>
        /// The primary key for the object schema
        /// </summary>
        public int ObjectTypeId {
            get { return _objectTypeId; }
        }

        XmlSchema _schemaXml;
        string _rawSchemaXml;
        /// <summary>
        /// The xml schema for a given object.
        /// </summary>
        public XmlSchema SchemaXml {
            get {
                if (_schemaXml == null && _rawSchemaXml != string.Empty) {
                    TextReader tReader = new StringReader(_rawSchemaXml);
                    XmlTextReader reader = new XmlTextReader(tReader);
                    _schemaXml = XmlSchema.Read(reader, delegate(object sender, ValidationEventArgs args){
                        SiteSettings.ContextData.DebugLog.WriteDebugMessage((args.Severity == XmlSeverityType.Warning ? WARNING : ERROR) + args.Message);
                    });
                }
                return _schemaXml; 
            }
        }

        XslCompiledTransform _dataEntryXslt;
        string _rawDataEntryXslt;
        /// <summary>
        /// The xslt used to style and xml set that validates against the schema in this object.
        /// </summary>
        public XslCompiledTransform DataEntryXslt {
            get {
                if (_dataEntryXslt == null && _rawDataEntryXslt != string.Empty) {
                    _dataEntryXslt = new XslCompiledTransform();
                    TextReader tReader = new StringReader(_rawDataEntryXslt);
                    XmlTextReader reader = new XmlTextReader(tReader);
                    _dataEntryXslt.Load(reader);
                }
                return _dataEntryXslt;
            }
        }

        string _name;
        /// <summary>
        /// The name of the object type
        /// </summary>
        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        XslCompiledTransform _defaultDisplayXslt;
        string _rawDefaultDisplayXslt;
        public XslCompiledTransform DefaultDisplayXslt {
            get {
                if (_defaultDisplayXslt == null && _rawDefaultDisplayXslt != string.Empty) {
                    _defaultDisplayXslt = new XslCompiledTransform();
                    TextReader tReader = new StringReader(_rawDefaultDisplayXslt);
                    XmlTextReader reader = new XmlTextReader(tReader);
                    _defaultDisplayXslt.Load(reader); 
                }
                return _defaultDisplayXslt;
            }
        }

        ContentStatuses _status;
        public ContentStatuses Status {
            get { return _status; }
            set { _status = value; }
        }

        bool _isActive;
        public bool IsActive {
            get { return _isActive; }
            set { _isActive = value; }
        }

        internal override void Reset() {
            _schemaXml = null;
            _dataEntryXslt = null;
            _defaultDisplayXslt = null;
        }

        internal override void LoadData() {
            System.Data.Common.DbDataReader reader = SiteSettings.DataAccess.ObjectTypeGet(_objectTypeId);
            _objectTypeId = reader.GetInt32(0);
            _rawDataEntryXslt = reader.GetString(1);
            _dataEntryXslt = null;
            _name = reader.GetString(2);
            _rawDefaultDisplayXslt = reader.GetString(3);
            _defaultDisplayXslt = null;
            _rawSchemaXml = reader.GetString(4);
            _schemaXml = null;
            _isActive = reader.GetBoolean(5);
            reader.Close();
        }        

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            e.Value = SiteSettings.DataAccess.ObjectTypeCheckModifiedDate(_objectTypeId);
        }

        internal override void Save() {
            _objectTypeId = SiteSettings.DataAccess.ObjectTypeSave(_rawDataEntryXslt, _name, _rawDefaultDisplayXslt, _rawSchemaXml, _status, _workFlowInstanceId);
        }

        internal override void Update() {
            SiteSettings.DataAccess.ObjectTypeUpdate(_objectTypeId, _rawDataEntryXslt, _name, _rawDefaultDisplayXslt, _rawSchemaXml, _status, _workFlowInstanceId, _isActive);
        }

        internal override void Delete() {
            throw new NotImplementedException();
        }    
    }
}
