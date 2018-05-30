// ----------------------------------------------------------------------------
// <copyright file="TypeExtensions.cs" company="MTCS">
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
    using System.Reflection;

    /// <summary>
    /// Static class containing extension methods for the <see cref="Type" />
    /// class.
    /// Very kindly lifted from
    /// <see href="https://stackoverflow.com/questions/35370384/how-to-get-declared-and-inherited-members-from-typeinfo" />.
    /// Allows us to continue targetting .NET Standard 1.0.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// A .NET Standard 1.0 safe method to pull all properties for a type
        /// back, including the properties declared on base types.
        /// </summary>
        /// <param name="typeInfo">
        /// An instance of <see cref="TypeInfo" />.
        /// </param>
        /// <returns>
        /// A collection of <see cref="PropertyInfo" /> instances.
        /// </returns>
        public static IEnumerable<PropertyInfo> GetAllProperties(
            this TypeInfo typeInfo)
            => GetAll(typeInfo, x => x.DeclaredProperties);

        private static IEnumerable<T> GetAll<T>(
            TypeInfo typeInfo,
            Func<TypeInfo, IEnumerable<T>> accessor)
        {
            while (typeInfo != null)
            {
                foreach (var t in accessor(typeInfo))
                {
                    yield return t;
                }

                typeInfo = typeInfo.BaseType?.GetTypeInfo();
            }
        }
    }
}