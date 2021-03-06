using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExampleProject.XmlSerializerHelper
{
    public class SelectChoose
    {
        public string SelectOption()
        {
            return
                @"<OptionArray><ItemOption><Name>name1</Name><Value>value1</Value><Index>1</Index></ItemOption><ItemOption><Name>name2</Name><Value>value2</Value><Index>2</Index></ItemOption></OptionArray>";

        }

        public T Serializer<T>(string option) where T:class
        {
            using (StringReader stringReader = new StringReader(option))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return xmlSerializer.Deserialize(stringReader) as T;
            }
        }
    }

    [Serializable]
    public class OptionArray
    {               
        public List<ItemOption> ItemOption { get; set; }
    }

    [Serializable]
    public class ItemOption
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
