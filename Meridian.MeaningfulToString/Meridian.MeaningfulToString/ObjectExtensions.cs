// ----------------------------------------------------------------------------
// <copyright file="ObjectExtensions.cs" company="MTCS">
// Copyright (c) MTCS 2018.
// MTCS is a trading name of Meridian Technology Consultancy Services Ltd.
// Meridian Technology Consultancy Services Ltd is registered in England and
// Wales. Company number: 11184022.
// </copyright>
// ----------------------------------------------------------------------------

namespace Meridian.MeaningfulToString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Static class containing extension methods for the <see cref="object" />
    /// class.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Provides a meaningful description of the instance passed in via
        /// <paramref name="sender" />.
        /// </summary>
        /// <param name="sender">
        /// An instance of a class in which to produce a meaningful
        /// description for.
        /// </param>
        /// <param name="includeBaseProperties">
        /// If true, will include descriptions of properties from all
        /// underlying base classes in the result.
        /// An optional parameter, defaulted to true.
        /// </param>
        /// <returns>
        /// A <see cref="string" /> value.
        /// </returns>
        public static string MeaningfulToString(
            this object sender,
            bool includeBaseProperties = true)
        {
            string toReturn = null;

            Type type = sender.GetType();

            TypeInfo typeInfo = type.GetTypeInfo();

            IEnumerable<PropertyInfo> propertyInfo = null;
            if (includeBaseProperties)
            {
                propertyInfo = typeInfo.GetAllProperties();
            }
            else
            {
                propertyInfo = typeInfo.DeclaredProperties;
            }

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