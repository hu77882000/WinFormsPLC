using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace WinFrmUpdate
{
    public class SerializationHelper
    {
        private static string XmlSerialize(object o)
        {
            XmlSerializer ser = new XmlSerializer(o.GetType());
            MemoryStream mem = new MemoryStream();
            //XmlTextWriter writer = new XmlTextWriter(mem, Encoding.UTF8);
            XmlTextWriter writer = new XmlTextWriter(mem,Encoding.UTF8);
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            ser.Serialize(writer, o, ns);
            writer.Close();
            return Encoding.UTF8.GetString(mem.ToArray());
        }

        private static T XmlDeserialize<T>(string s)
        {
            //XmlDocument xdoc = new XmlDocument();
            try
            {
                //xdoc.LoadXml(s);
                //XmlNodeReader reader = new XmlNodeReader(xdoc.DocumentElement);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                object obj = ser.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(s)));
                return (T)obj;
            }
            catch
            {
                return default(T);
            }
        }

        private static string JsonSerialize(object o)
        {
            return JsonConvert.SerializeObject(o);

        }

        private static T JsonDeserialize<T>(string s)
        {
            return JsonConvert.DeserializeObject<T>(s);
//            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(s)))
//            {
//                return (T)new DataContractJsonSerializer(typeof(T)).ReadObject(ms);
//            }
        }

        /// <summary>
        /// 将对象根据格式（XML/JSON）序列化成字符串结果
        /// 0-输出Json格式  1-输出Xml格式
        /// </summary>
        /// <param name="o">目标对象</param>
        /// <param name="format">输出格式</param>
        /// <returns></returns>
        public static string Serialize(object o, int format)
        {
            if (format == 1)
            {
                return XmlSerialize(o);
            }
            else
            {
                return JsonSerialize(o);
            }
        }

        /// <summary>
        /// 将字符串根据格式（XML/JSON）反序列化成指定类型的对象
        /// 0-输出Json格式  1-输出Xml格式
        /// </summary>
        /// <typeparam name="T">指定类型</typeparam>
        /// <param name="s">目标字符串</param>
        /// <param name="format">输入格式</param>
        /// <returns></returns>
        public static T Deserialize<T>(string s, int format)
        {
            if (format == 1)
            {
                return XmlDeserialize<T>(s);
            }
            else
            {
                return JsonDeserialize<T>(s);
            }
        }
    }
}