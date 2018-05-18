// ----------------------------------------------------------------------------
// <copyright file="MeaningfulBase.cs" company="MTCS">
// Copyright (c) MTCS 2018.
// MTCS is a trading name of Meridian Technology Consultancy Services Ltd.
// Meridian Technology Consultancy Services Ltd is registered in England and
// Wales. Company number: 11184022.
// </copyright>
// ----------------------------------------------------------------------------

namespace Meridian.MeaningfulToString
{
    /// <summary>
    /// This class automatically overrides the <see cref="object.ToString()" />
    /// method with the
    /// <see cref="ObjectExtensions.MeaningfulToString(object)" />
    /// implementation.
    /// </summary>
    public abstract class MeaningfulBase
    {
        /// <summary>
        /// Overrides <see cref="object.ToString()" />.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            string toReturn = this.MeaningfulToString();

            return toReturn;
        }
    }
}