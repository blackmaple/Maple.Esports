namespace Maple.Esports.Metadata.GameMain.ClubSystem
{
    /// <summary>
    /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."AthleteComprehensionData"]
    /// [Utility.IReset]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AthleteComprehensionData>, Ptr_AthleteComprehensionData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "GameMain.ClubSystem", "AthleteComprehensionData", "GameMain.ClubSystem.AthleteComprehensionData")]
    public partial class AthleteComprehensionData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct Ref_AthleteComprehensionData
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public System.Boolean comprehended;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
            public System.Int32 count;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public System.Int32 exp;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AthleteComprehensionData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AthleteComprehensionData(System.IntPtr ptr) => new Ptr_AthleteComprehensionData(ptr);
            public static implicit operator System.IntPtr(Ptr_AthleteComprehensionData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AthleteComprehensionData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."AthleteComprehensionData"]
        /// </summary>
        partial struct Ptr_AthleteComprehensionData
        {
            /// <summary>
            /// 0x10 System.Boolean comprehended
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("comprehended", "System.Boolean")]
            public partial System.Boolean COMPREHENDED { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 count
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("count", "System.Int32")]
            public partial System.Int32 COUNT { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 exp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("exp", "System.Int32")]
            public partial System.Int32 EXP { get; set; } 
*/
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."AthleteComprehensionData"]
        /// </summary>
        partial struct Ptr_AthleteComprehensionData
        {
            /// <summary>
            /// static  GameMain.ClubSystem.AthleteComprehensionData New()
            /// </summary>
            /// <returns>struct GameMain.ClubSystem.AthleteComprehensionData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("New", "GameMain.ClubSystem.AthleteComprehensionData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial GameMain.ClubSystem.AthleteComprehensionData NEW(); 
*/
            /// <summary>
            ///   System.Boolean Next(System.Int32 addExp, System.Int32 needExp)
            /// </summary>
            /// <param name = "addExp">struct System.Int32</param>
            /// <param name = "needExp">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Next", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean NEXT(System.Int32 addExp, System.Int32 needExp); 
*/
            /// <summary>
            ///   System.Void Reset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET(); 
*/
        }
    }
}