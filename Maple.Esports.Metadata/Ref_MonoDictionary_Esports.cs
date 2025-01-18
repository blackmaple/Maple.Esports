using Maple.Esports.Metadata.GameMain.UnitSystem;
using Maple.MonoGameAssistant.Core;
using System.Runtime.CompilerServices;
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

    [StructLayout( LayoutKind.Sequential)]
    public readonly struct PMonoDictionary_Esports<T_KEY, T_VALUE>(nint ptr) :
        IPtrMonoDictionary<Ref_MonoDictionary_Esports, T_KEY, T_VALUE, Ref_MonoEntry<T_KEY, T_VALUE>>, IMonoPointer<Ref_MonoDictionary_Esports>
        where T_KEY : unmanaged
        where T_VALUE : unmanaged
    {
        [MarshalAs(UnmanagedType.SysInt)]
        private readonly nint _ptr =ptr;

 
        public static implicit operator PMonoDictionary_Esports<T_KEY, T_VALUE>(nint ptr)
        {
            return new PMonoDictionary_Esports<T_KEY, T_VALUE>(ptr);
        }

        public static implicit operator nint(PMonoDictionary_Esports<T_KEY, T_VALUE> obj)
        {
            return obj._ptr;
        }

        public static implicit operator PMonoDictionary_Esports<T_KEY, T_VALUE>(PMonoDictionary obj)
        {
            return new PMonoDictionary_Esports<T_KEY, T_VALUE>((nint)obj);
        }

        public static implicit operator PMonoDictionary(PMonoDictionary_Esports<T_KEY, T_VALUE> obj)
        {
            return new PMonoDictionary(obj._ptr);
        }

        public override string ToString()
        {
            return ((IntPtr)_ptr).ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid()
        {
            return _ptr != IntPtr.Zero;
        }

    
        public PMonoEntry<Ref_MonoEntry<T_KEY, T_VALUE>, T_KEY, T_VALUE>[] AsRefArray()
            => this.AsRefArray<PMonoDictionary_Esports<T_KEY, T_VALUE>, Ref_MonoDictionary_Esports, T_KEY, T_VALUE, Ref_MonoEntry<T_KEY, T_VALUE>>();
 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref Ref_MonoDictionary_Esports AsRef() => ref _ptr.AsRefStruct<Ref_MonoDictionary_Esports>();


    }

}
