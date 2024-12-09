using Maple.MonoGameAssistant.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.AzureValley.Metadata
{
 
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct Ref_MonoDictionary_AzureValley : IRefMonoDictionary
    {
        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;

        [FieldOffset(16)]
        public readonly nint buckets;

        [FieldOffset(24)]
        public readonly nint entries;

        [FieldOffset(32)]
        public readonly nint comparer;

        [FieldOffset(40)]
        public readonly nint keys;

        [FieldOffset(48)]
        public readonly nint values;

        [FieldOffset(56)]
        public readonly nint _syncRoot;

        [FieldOffset(64)]
        public readonly int count;

        [FieldOffset(68)]
        public readonly int freeList;

        [FieldOffset(72)]
        public readonly int freeCount;

        [FieldOffset(76)]
        public readonly int version;

        public int Count => count;

        public int FreeCount => freeCount;

        public PMonoArray Entries => entries;
    }




}
