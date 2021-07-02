// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for AssignmentMethod.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(AssignmentMethodConverter))]
    public struct AssignmentMethod : System.IEquatable<AssignmentMethod>
    {
        private AssignmentMethod(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Specifies that the label was set as part of an automatic process.
        /// </summary>
        public static readonly AssignmentMethod Standard = "Standard";

        /// <summary>
        /// Specifies that the label was set manually.
        /// </summary>
        public static readonly AssignmentMethod Priviledged = "Priviledged";


        /// <summary>
        /// Underlying value of enum AssignmentMethod
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for AssignmentMethod
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type AssignmentMethod
        /// </summary>
        public bool Equals(AssignmentMethod e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to AssignmentMethod
        /// </summary>
        public static implicit operator AssignmentMethod(string value)
        {
            return new AssignmentMethod(value);
        }

        /// <summary>
        /// Implicit operator to convert AssignmentMethod to string
        /// </summary>
        public static implicit operator string(AssignmentMethod e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum AssignmentMethod
        /// </summary>
        public static bool operator == (AssignmentMethod e1, AssignmentMethod e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum AssignmentMethod
        /// </summary>
        public static bool operator != (AssignmentMethod e1, AssignmentMethod e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for AssignmentMethod
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is AssignmentMethod && Equals((AssignmentMethod)obj);
        }

        /// <summary>
        /// Returns for hashCode AssignmentMethod
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}