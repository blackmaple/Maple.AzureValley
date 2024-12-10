using System.Runtime.InteropServices;

namespace Maple.AzureValley.Metadata
{
    public readonly struct REF_NULLABLE<T> where T : unmanaged
    {
        public REF_NULLABLE(T? v)
        {
            if (v.HasValue)
            {
                hasValue = true;
                value = v.Value;
            }
        }


        [MarshalAs(UnmanagedType.U1)]
        public readonly bool hasValue;

        public readonly T value;
    }
}
