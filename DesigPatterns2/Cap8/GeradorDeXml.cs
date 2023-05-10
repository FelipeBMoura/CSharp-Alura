using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesigPatterns2.Cap8
{
    class GeradorDeXml
    {
        public String GeraXml(object o)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            xmlSerializer.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
