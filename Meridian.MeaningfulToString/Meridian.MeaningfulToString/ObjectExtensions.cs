namespace Meridian.MeaningfulToString
{
    using System;
    using System.Linq;
    using System.Reflection;

    public static class ObjectExtensions
    {
        public static string MeaningfulToString(this object sender)
        {
            string toReturn = null;

            Type type = sender.GetType();

            PropertyInfo[] propertyInfo = type.GetProperties();

            string[] propertyDescs = propertyInfo
                .Select(x =>
                {
                    object propertyValue = x.GetValue(sender);

                    string propertyValueStr =
                        propertyValue == null ? "null" : propertyValue.ToString();

                    return $"{x.Name} = {propertyValueStr}";
                })
                .ToArray();

            string propertiesConcat = string.Join(", ", propertyDescs);

            toReturn = $"{type.Name} ({propertiesConcat})";

            return toReturn;
        }
    }
}