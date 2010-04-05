using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.Web {
    internal struct ValueStatus {
        bool _IsValid;
        object _Value;

        public ValueStatus(bool IsValid, object Value) {
            _IsValid = IsValid;
            _Value = Value;
        }

        public bool IsValid {
            get { return _IsValid; }
            set { _IsValid = value; }
        }

        public object Value {
            get { return _Value; }
            set { _Value = value; }
        }
    }

    /// <summary>
    /// This class is used to manipulate the query string of a Uri.
    /// </summary>
    public class UriBuilder {
        const string AbsUri_Csnt = "AbsoluteUri", OrgStrg_Csnt = "OrignalString", PthQury_Csnt = "PathAndQuery", Query_Csnt = "Query",
            ProtocolDivider_Csnt = "://", QuestionMark_Csnt = "?", EqualSign_Csnt = "=", Colon_Csnt = ":", Ampersand_Csnt = "&";
        System.Collections.Specialized.NameValueCollection _QueryParameters = new System.Collections.Specialized.NameValueCollection();
        System.Collections.Generic.Dictionary<string, ValueStatus> _QueryResets = new Dictionary<string, ValueStatus>();
        System.Uri _URL;

        /// <summary>
        /// This class is used to manipulate the query string of a Uri. This constructor accepts a object of type Uri.
        /// </summary>
        /// <param name="Uri">The Uri object used to initalize the object instance.</param>
        public UriBuilder(Uri Uri) {
            _URL = Uri;
            Init();
        }

        /// <summary>
        /// This class is used to manipulate the query string of a Uri. This constructor accepts a object of type string.
        /// </summary>
        /// <param name="Uri">The string object used to initalize the object instance.</param>
        public UriBuilder(string Uri) {
            _URL = new Uri(Uri);
            Init();
        }

        void Init() {
            string[] Parameters = (_URL.Query.Replace(QuestionMark_Csnt, string.Empty)).Split(Ampersand_Csnt[0]);
            int PCount = Parameters.Length;
            for (int i = 0; i < PCount; i++) {
                string[] NameValue = Parameters[i].Split(EqualSign_Csnt[0]);
                switch (NameValue.Length) {
                    case 1:
                        _QueryParameters.Add(NameValue[0], string.Empty);
                        break;
                    case 2:
                        _QueryParameters.Add(NameValue[0], NameValue[1]);
                        break;
                }
            }
            _QueryResets.Add(AbsUri_Csnt, new ValueStatus(true, _URL.AbsoluteUri));
            _QueryResets.Add(PthQury_Csnt, new ValueStatus(true, _URL.PathAndQuery));
            _QueryResets.Add(Query_Csnt, new ValueStatus(true, _URL.Query));
        }

        /// <summary>
        /// An accesor for the AbsolutePath property for the underlying Uri object.
        /// </summary>
        public string AbsolutePath {
            get { return _URL.AbsolutePath; }
        }

        /// <summary>
        /// The Absolute Uri for the instance, including the protocol for the Uri. This value will be recalculated if a query string value is added, removed, or changed. 
        /// </summary>
        public string AbsoluteUri {
            get {
                switch (_QueryResets[AbsUri_Csnt].IsValid) {
                    case true:
                        return (string)_QueryResets[AbsUri_Csnt].Value;
                    case false:
                        StringBuilder NewAbsPth = new StringBuilder();
                        NewAbsPth.Append(_URL.Scheme);
                        NewAbsPth.Append(ProtocolDivider_Csnt);
                        NewAbsPth.Append(DnsSafeHost);
                        NewAbsPth.Append(LocalPath);
                        if (_QueryParameters.Count > 0)
                            BuildQueryString(ref NewAbsPth);
                        NewAbsPth.Append(_URL.Fragment);
                        _QueryResets[AbsUri_Csnt] = new ValueStatus(true, NewAbsPth.ToString());
                        return (string)_QueryResets[AbsUri_Csnt].Value;
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// An accesor for the Authority property of the underlying Uri object.
        /// </summary>
        public string Authority {
            get { return _URL.Authority; }
        }

        /// <summary>
        /// An accesor for the DnsSafeHost property of the underlying Uri object.
        /// </summary>
        public string DnsSafeHost {
            get { return _URL.DnsSafeHost; }
        }

        /// <summary>
        /// An accesor for the Fragment property of the underlying Uri object.
        /// </summary>
        public string Fragment {
            get { return _URL.Fragment; }
        }

        /// <summary>
        /// An accesor for the Host property of the underlying Uri object.
        /// </summary>
        public string Host {
            get { return _URL.Host; }
        }

        /// <summary>
        /// An accesor for the HostNameType property of the underlying Uri object.
        /// </summary>
        public UriHostNameType HostNameType {
            get { return _URL.HostNameType; }
        }

        /// <summary>
        /// An accesor for the IsAbsoluteUri property of the underlying Uri object.
        /// </summary>
        public bool IsAbsoluteUri {
            get { return _URL.IsAbsoluteUri; }
        }

        /// <summary>
        /// An accesor for the IsDefaultPort property of the underlying Uri object.
        /// </summary>
        public bool IsDefaultPort {
            get { return _URL.IsDefaultPort; }
        }

        /// <summary>
        /// An accesor for the IsFile property of the underlying Uri object.
        /// </summary>
        public bool IsFile {
            get { return _URL.IsFile; }
        }

        /// <summary>
        /// An accesor for the IsLoopback property of the underlying Uri object.
        /// </summary>
        public bool IsLoopback {
            get { return _URL.IsLoopback; }
        }

        /// <summary>
        /// An accesor for the IsUnc property of the underlying Uri object.
        /// </summary>
        public bool IsUnc {
            get { return _URL.IsUnc; }
        }

        /// <summary>
        /// An accesor for the LocalPath property of the underlying Uri object.
        /// </summary>
        public string LocalPath {
            get { return _URL.LocalPath; }
        }

        /// <summary>
        /// An accesor for the Orignalstring property of the underling Uri object.
        /// </summary>
        public string OrignalString {
            get { return _URL.OriginalString; }
        }

        /// <summary>
        /// All of the Querystring parameter keys on this Url.
        /// </summary>
        public string[] Keys {
            get { return _QueryParameters.AllKeys; }
        }

        /// <summary>
        /// The number of Querystring parameters ont the Url.
        /// </summary>
        public int Length {
            get { return _QueryParameters.Count; }
        }


        /// <summary>
        /// The value at the given key
        /// </summary>
        /// <param name="Name">The key</param>
        /// <returns></returns>
        public string this[string Name] {
            get { return _QueryParameters[Name]; }
        }

        /// <summary>
        /// The value at the given index
        /// </summary>
        /// <param name="Index">The index</param>
        /// <returns></returns>
        public string this[int Index] {
            get { return _QueryParameters[Index]; }
        }

        /// <summary>
        /// The Path and Querystring for the current Uri. This value will be recalculated if a query string value is added, removed, or changed. 
        /// </summary>
        public string PathAndQuery {
            get {
                switch (_QueryResets[PthQury_Csnt].IsValid) {
                    case true:
                        return (string)_QueryResets[PthQury_Csnt].Value;
                    case false:
                        StringBuilder NewAbsPth = new StringBuilder();
                        NewAbsPth.Append(LocalPath);
                        if (_QueryParameters.Count > 0)
                            BuildQueryString(ref NewAbsPth);
                        _QueryResets[PthQury_Csnt] = new ValueStatus(true, NewAbsPth.ToString());
                        return (string)_QueryResets[PthQury_Csnt].Value;
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// The Query for the current Uri. This value will be recalculated if a query string value is added, removed, or changed. 
        /// </summary>
        public string Query {
            get {
                switch (_QueryResets[Query_Csnt].IsValid) {
                    case true:
                        return (string)_QueryResets[Query_Csnt].Value;
                    case false:
                        StringBuilder NewAbsPth = new StringBuilder();
                        if (_QueryParameters.Count > 0)
                            BuildQueryString(ref NewAbsPth);
                        _QueryResets[Query_Csnt] = new ValueStatus(true, NewAbsPth.ToString());
                        return (string)_QueryResets[Query_Csnt].Value;
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// An accesor for the Scheme property of the underling Uri object.
        /// </summary>
        public string Scheme {
            get { return _URL.Scheme; }
        }

        /// <summary>
        /// An accesor for the UserEscaped property of the underling Uri object.
        /// </summary>
        public bool UserEscaped {
            get { return _URL.UserEscaped; }
        }

        /// <summary>
        /// An accesor for the Segments property of the underling Uri object.
        /// </summary>
        public string[] Segments {
            get { return _URL.Segments; }
        }

        string BuildQueryString() {
            StringBuilder sb = new StringBuilder();
            BuildQueryString(ref sb);
            return sb.ToString();
        }

        void BuildQueryString(ref StringBuilder sb) {
            sb.Append(QuestionMark_Csnt);
            int Count = _QueryParameters.Count;
            for (int i = 0; i < Count; i++) {
                sb.Append(_QueryParameters.Keys[i]);
                sb.Append(EqualSign_Csnt);
                sb.Append(_QueryParameters[i]);
            }
        }

        void ResetQueryStringValues() {
            _QueryResets[AbsUri_Csnt] = new ValueStatus(false, _QueryResets[AbsUri_Csnt].Value);
            _QueryResets[PthQury_Csnt] = new ValueStatus(false, _QueryResets[PthQury_Csnt].Value);
            _QueryResets[Query_Csnt] = new ValueStatus(false, _QueryResets[Query_Csnt].Value);

        }

        /// <summary>
        /// This method allows for query string parameters to be added to the current Uri. Calling this method will cause some properties to be recalcuated the next time the property is called.
        /// </summary>
        /// <param name="Name">The name of the parameter to be added.</param>
        /// <param name="Value">The value to be added.</param>
        public void AddQueryStringParameter(string Name, string Value) {
            _QueryParameters.Add(Name, Value);
            ResetQueryStringValues();
        }

        /// <summary>
        /// This method allows for query string parameters to be modified. Calling this method will cause some properties to be recalcuated the next time the property is called.
        /// </summary>
        /// <param name="Name">The name of the parameter to be modified</param>
        /// <param name="Value">The new value that the parameter should be set to.</param>
        public void ModifyQueryStringParamenter(string Name, string Value) {
            _QueryParameters[Name] = Value;
            ResetQueryStringValues();
        }

        /// <summary>
        /// This method tests if a query string parameter already exists in the query string.
        /// </summary>
        /// <param name="Name">The name of the parameter to test for.</param>
        /// <returns>A boolean value set to true if the value is found.</returns>
        public bool ContainsQueryStringParameter(string Name) {
            return (_QueryParameters.GetValues(Name).Length > 0 ? true : false);
        }

        /// <summary>
        /// This method allows for query string parameters to be removed. Calling this method will cause some properties to be recalculated the next time the property is called.
        /// </summary>
        /// <param name="Name">The name of the parameter to remove.</param>
        public void RemoveQueryStringParameter(string Name) {
            _QueryParameters.Remove(Name);
            ResetQueryStringValues();
        }
    }
}
