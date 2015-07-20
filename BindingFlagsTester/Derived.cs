
namespace BindingFlagsTester
{
    class Derived : Base
    {
        public const string PublicConstFieldDerived = "PublicConstFieldDerived";
        protected const string ProtectedConstFieldDerived = "ProtectedConstFieldDerived";
        internal const string InternalConstFieldDerived = "InternalConstFieldDerived";
        private const string PrivateConstFieldDerived = "PrivateConstFieldDerived";

        public static string PublicStaticFieldDerived = "PublicStaticFieldDerived";
        protected static string ProtectedStaticFieldDerived = "ProtectedStaticFieldDerived";
        internal static string InternalStaticFieldDerived = "InternalStaticFieldDerived";
#pragma warning disable 0414
        private static string PrivateStaticFieldDerived = "PrivateStaticFieldDerived";
#pragma warning restore 0414

        public string PublicFieldDerived = "PublicFieldDerived";
        protected string ProtectedFieldDerived = "ProtectedFieldDerived";
        internal string InternalFieldDerived = "InternalFieldDerived";
#pragma warning disable 0414
        private string PrivateFieldDerived = "PrivateFieldDerived";
#pragma warning restore 0414

        public object PublicPropertyDerived { get; set; }
        protected object ProtectedPropertyDerived { get; set; }
        internal object InternalPropertyDerived { get; set; }
        private object PrivatePropertyDerived { get; set; }

        public static object PublicStaticPropertyDerived { get; set; }
        protected static object ProtectedStaticPropertyDerived { get; set; }
        internal static object InternalStaticPropertyDerived { get; set; }
        private static object PrivateStaticPropertyDerived { get; set; }

        public void PublicMethodDerived()
        {
        }
        protected void ProtectedMethodDerived()
        {
        }
        internal void InternalMethodDerived()
        {
        }
        private void PrivateMethodDerived()
        {
        }

        public static void PublicStaticMethodDerived()
        {
        }
        protected static void ProtectedStaticMethodDerived()
        {
        }
        internal static void InternalStaticMethodDerived()
        {
        }
        private static void PrivateStaticMethodDerived()
        {
        }
    }
}
