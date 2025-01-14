using Maple.MonoGameAssistant.Core;
using System.Runtime.InteropServices;

namespace Maple.Esports.Metadata
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct Ref_MonoDictionary_Esports : IRefMonoDictionary
    {
        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;
        [FieldOffset(0x10)]
        public readonly PMonoArray<Ref_MonoArray, int> _buckets;
        [FieldOffset(0x18)]
        public readonly PMonoArray _entries;
        [FieldOffset(0x20)]
        public readonly nint _comparer;
        [FieldOffset(0x28)]
        public readonly nint _keys;
        [FieldOffset(0x30)]
        public readonly nint _values;
        [FieldOffset(0x38)]
        public readonly nint _syncRoot;
        [FieldOffset(0x40)]
        public readonly int _count;
        [FieldOffset(0x44)]
        public readonly int _freeList;
        [FieldOffset(0x48)]
        public readonly int _freeCount;
        [FieldOffset(0x4C)]
        public readonly int _version;



        public int Count => _count;

        public int FreeCount => _freeCount;

        public PMonoArray Entries => _entries;

        public int Size => Count - FreeCount;
    }

 
}
