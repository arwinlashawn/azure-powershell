// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support
{

    /// <summary>License Types</summary>
    public partial struct LicenseType :
        System.IEquatable<LicenseType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType WindowsClient = @"Windows_Client";

        /// <summary>the value for an instance of the <see cref="LicenseType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to LicenseType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LicenseType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new LicenseType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type LicenseType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type LicenseType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is LicenseType && Equals((LicenseType)obj);
        }

        /// <summary>Returns hashCode for enum LicenseType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="LicenseType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private LicenseType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for LicenseType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to LicenseType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LicenseType" />.</param>

        public static implicit operator LicenseType(string value)
        {
            return new LicenseType(value);
        }

        /// <summary>Implicit operator to convert LicenseType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="LicenseType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum LicenseType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType e1, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum LicenseType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType e1, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LicenseType e2)
        {
            return e2.Equals(e1);
        }
    }
}