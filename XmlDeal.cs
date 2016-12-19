using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace BinlyWorkTaskManager
{
    class XmlDeal
    {
        public static string ObjToXml<T>(T obj, string encodingType = "UTF-8")
        {
            Encoding encoding = Encoding.GetEncoding(encodingType);

            string xmlContent = string.Empty;

            XmlSerializer ser = new XmlSerializer(obj.GetType());
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            using (MemoryStream sb = new MemoryStream())
            {
                StreamWriter writer = new StreamWriter(sb, encoding);
                ser.Serialize(writer, obj, ns);
                xmlContent = encoding.GetString(sb.ToArray());
                writer.Close();
                sb.Close();
            }

            return xmlContent;
        }


        public static T XmlToObj<T>(string xmlContent, string encodingType = "UTF-8")
        {
            Encoding encoding = Encoding.GetEncoding(encodingType);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T obj = default(T);
            byte[] byteArray = encoding.GetBytes(xmlContent);

            try
            {
                using (Stream stream = new MemoryStream(byteArray))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    obj = (T)serializer.Deserialize(stream);
                    stream.Close();
                }
            }
            catch (Exception e)
            {                
                throw new ApplicationException("拆解XML時發生錯誤:" + e.Message);
            }
            return obj;
        }
    }
}
