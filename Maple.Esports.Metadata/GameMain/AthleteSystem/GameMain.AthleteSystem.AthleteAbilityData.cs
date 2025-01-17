namespace Maple.Esports.Metadata.GameMain.AthleteSystem
{
    /// <summary>
    /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilityData"]
    /// [Utility.IReset]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AthleteAbilityData>, Ptr_AthleteAbilityData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "GameMain.AthleteSystem", "AthleteAbilityData", "GameMain.AthleteSystem.AthleteAbilityData")]
    public partial class AthleteAbilityData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct Ref_AthleteAbilityData
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public System.Int32 level;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
            public System.Int32 exp;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public System.Int32 expHistory;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC)]
            public GameMain.AthleteSystem.AbilityPotentialRank potential;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AthleteAbilityData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AthleteAbilityData(System.IntPtr ptr) => new Ptr_AthleteAbilityData(ptr);
            public static implicit operator System.IntPtr(Ptr_AthleteAbilityData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AthleteAbilityData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilityData"]
        /// </summary>
        partial struct Ptr_AthleteAbilityData
        {
            /// <summary>
            /// 0x10 System.Int32 level
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("level", "System.Int32")]
            public partial System.Int32 LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 exp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("exp", "System.Int32")]
            public partial System.Int32 EXP { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 expHistory
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("expHistory", "System.Int32")]
            public partial System.Int32 EXP_HISTORY { get; set; } 
*/

            /// <summary>
            /// 0x1C GameMain.AthleteSystem.AbilityPotentialRank potential
            /// enum ["Assembly-CSharp"."GameMain.AthleteSystem"."AbilityPotentialRank"]
            /// </summary>
            /// <returns>enum GameMain.AthleteSystem.AbilityPotentialRank</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("potential", "GameMain.AthleteSystem.AbilityPotentialRank")]
            public partial GameMain.AthleteSystem.AbilityPotentialRank POTENTIAL { get; set; } 
*/
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilityData"]
        /// </summary>
        partial struct Ptr_AthleteAbilityData
        {
            /// <summary>
            ///   System.Void Reset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteAbilityData SetLevel(System.Single level)
            /// </summary>
            /// <param name = "level">struct System.Single</param>
            /// <returns>struct GameMain.AthleteSystem.AthleteAbilityData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetLevel", "GameMain.AthleteSystem.AthleteAbilityData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial GameMain.AthleteSystem.AthleteAbilityData SET_LEVEL(System.Single level); 
*/
        }
    }
}