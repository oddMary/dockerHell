using Framework.KDT;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace MyShows.Lib.Features
{
    public class YamlDeserializer
    {
        public static PropertyList KDTObjects(string filePath)
        {
            string StringFile = File.ReadAllText(filePath);

            StringReader FileYml = new StringReader(StringFile);

            var deserialize = new DeserializerBuilder().WithNamingConvention(new CamelCaseNamingConvention()).Build();
            return deserialize.Deserialize<PropertyList>(FileYml);
        }
    }
}
