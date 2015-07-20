using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BindingFlagsTester
{
    class Base
    {

        public const string PublicConstField = "PublicConstField";
        protected const string ProtectedConstField = "ProtectedConstField";
        internal const string InternalConstField = "InternalConstField";
        private const string PrivateConstField = "PrivateConstField";

        public static string PublicStaticField = "PublicStaticField";
        protected static string ProtectedStaticField = "ProtectedStaticField";
        internal static string InternalStaticField = "InternalStaticField";
#pragma warning disable 0414
        private static string PrivateStaticField = "PrivateStaticField";
#pragma warning restore 0414

        public string PublicField = "PublicField";
        protected string ProtectedField = "ProtectedField";
        internal string InternalField = "InternalField";
#pragma warning disable 0414
        private string PrivateField = "PrivateField";
#pragma warning restore 0414

        public object PublicProperty { get; set; }
        protected object ProtectedProperty { get; set; }
        internal object InternalProperty { get; set; }
        private object PrivateProperty { get; set; }

        public static object PublicStaticProperty { get; set; }
        protected static object ProtectedStaticProperty { get; set; }
        internal static object InternalStaticProperty { get; set; }
        private static object PrivateStaticProperty { get; set; }

        public void PublicMethod()
        {
        }
        protected void ProtectedMethod()
        {
        }
        internal void InternalMethod()
        {
        }
        private void PrivateMethod()
        {
        }

        public static void PublicStaticMethod()
        {
        }
        protected static void ProtectedStaticMethod()
        {
        }
        internal static void InternalStaticMethod()
        {
        }
        private static void PrivateStaticMethod()
        {
        }

    }
}
