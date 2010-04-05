using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.IO;

namespace TotalCMS.Xml {
    /// <summary>
    /// Transforms a xml fragment using the specified xslt for output onto a portion of a page.
    /// </summary>
    public static class XslHelper {
        /// <summary>
        /// Transforms an XML document ursing an XSLT in memory as opposed to transforming an entire document. 
        /// This overload excepts an XsltArgumentList, an XSLCompiledTransform object and a string as its input. 
        /// Accepts an XsltArgumentList for passing parameters and extension object.
        /// </summary>
        /// <param name="xslArgs">The xsl arguments list.</param>
        /// <param name="transform">The precompiled transform object.</param>
        /// <param name="input">The XML Data as a string.</param>
        /// <returns>Returns the transformed XML document fragment in string form.</returns>
        public static string TransformInMemory(XsltArgumentList xslArgs, XslCompiledTransform transform, string input) {
            StringBuilder sb = new StringBuilder();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.IgnoreProcessingInstructions = false;
            XmlWriterSettings wSettings = new XmlWriterSettings();
            wSettings.ConformanceLevel = ConformanceLevel.Fragment;
            XmlReader xReader = XmlReader.Create(new StringReader(input), settings);
            XmlWriter xWriter = XmlWriter.Create(sb, wSettings);
            transform.Transform(xReader, xslArgs, xWriter);
            xWriter.Close();
            xReader.Close();
            return sb.ToString();
        }

        /// <summary>
        /// Transforms an XML document ursing an XSLT in memory as opposed to transforming an entire document. 
        /// This overload excepts an XsltArgumentList, an XSLCompiledTransform object and a string as its input.
        /// </summary>
        /// <param name="transform">The precompiled transform object.</param>
        /// <param name="input">The XML Data as a string.</param>
        /// <returns>Returns the transformed XML document fragment in string form.</returns>
        public static string TransformInMemory(XslCompiledTransform transform, string input) {
            return TransformInMemory(new XsltArgumentList(), transform, input);
        }

        /// <summary>
        /// Transforms an XML document ursing an XSLT in memory as opposed to transforming an entire document. 
        /// This overload excepts an XsltArgumentList, an XSLCompiledTransform object and a string as its input.
        /// Accepts an XsltArgumentList for passing parameters and extension object.
        /// </summary>
        /// <param name="xslArgs">The xsl arguments list.</param>
        /// <param name="transformPath">The virutal path to the xslt document.</param>
        /// <param name="input">The XML Data as a string.</param>
        /// <returns>Returns the transformed XML document fragment in string form.</returns>
        public static string TransformInMemory(XsltArgumentList xslArgs, string transformPath, string input) {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load(System.Web.HttpContext.Current.Server.MapPath(transformPath));
            return TransformInMemory(xslArgs, xsl, input);
        }

        /// <summary>
        /// Transforms an XML document ursing an XSLT in memory as opposed to transforming an entire document. 
        /// This overload excepts an XsltArgumentList, an XSLCompiledTransform object and a string as its input. 
        /// Accepts an Object to be added as an Xslt extension.
        /// </summary>
        /// <param name="extension">An instance of the extension object to be added.</param>
        /// <param name="urnName">The urnName that you want to assign to the extension object.</param>
        /// <param name="transformPath">The virtual path to the xslt document.</param>
        /// <param name="input">The XML Data as a string.</param>
        /// <returns>Returns the transformed XML document fragment in string form.</returns>
        public static string TransformInMemory(Object extension, string urnName, string transformPath, string input) {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load(System.Web.HttpContext.Current.Server.MapPath(transformPath));
            XsltArgumentList xslArgs = new XsltArgumentList();
            xslArgs.AddExtensionObject("urn:" + urnName, extension);
            return TransformInMemory(xslArgs, xsl, input);
        }

        /// <summary>
        /// Transforms an XML document ursing an XSLT in memory as opposed to transforming an entire document. 
        /// This overload excepts an XsltArgumentList, an XSLCompiledTransform object and a string as its input. 
        /// Accepts an Object to be added as an Xslt extension.
        /// </summary>
        /// <param name="extension"></param>
        /// <param name="urnName"></param>
        /// <param name="transform">The precompiled transform object.</param>
        /// <param name="input">The XML Data as a string.</param>
        /// <returns>Returns the transformed XML document fragment in string form.</returns>
        public static string TransformInMemory(Object extension, string urnName, XslCompiledTransform transform, string input) {
            XsltArgumentList xslArgs = new XsltArgumentList();
            xslArgs.AddExtensionObject("urn:" + urnName, extension);
            return TransformInMemory(xslArgs, transform, input);
        }

        /// <summary>
        /// Transforms an XML document ursing an XSLT in memory as opposed to transforming an entire document. 
        /// This overload excepts an XsltArgumentList, an XSLCompiledTransform object and a string as its input. 
        /// </summary>
        /// <param name="transformPath">The virutal path to the xslt document.</param>
        /// <param name="input">The XML Data as a string.</param>
        /// <returns>Returns the transformed XML document fragment in string form.</returns>
        public static string TransformInMemory(string transformPath, string input) {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load(System.Web.HttpContext.Current.Server.MapPath(transformPath));
            return TransformInMemory(new XsltArgumentList(), xsl, input);
        }
    }
}
