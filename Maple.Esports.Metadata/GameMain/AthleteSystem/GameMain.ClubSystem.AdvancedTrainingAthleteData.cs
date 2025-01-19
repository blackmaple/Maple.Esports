namespace Maple.Esports.Metadata.GameMain.AthleteSystem
{
    /// <summary>
    /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."AdvancedTrainingAthleteData"]
    /// [Utility.IReset]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AdvancedTrainingAthleteData>, Ptr_AdvancedTrainingAthleteData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "GameMain.ClubSystem", "AdvancedTrainingAthleteData", "GameMain.ClubSystem.AdvancedTrainingAthleteData")]
    public partial class AdvancedTrainingAthleteData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct Ref_AdvancedTrainingAthleteData
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public System.Single heroPoolProbability;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AdvancedTrainingAthleteData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AdvancedTrainingAthleteData(System.IntPtr ptr) => new Ptr_AdvancedTrainingAthleteData(ptr);
            public static implicit operator System.IntPtr(Ptr_AdvancedTrainingAthleteData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AdvancedTrainingAthleteData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."AdvancedTrainingAthleteData"]
        /// </summary>
        partial struct Ptr_AdvancedTrainingAthleteData
        {
            /// <summary>
            /// 0x10 System.Single heroPoolProbability
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroPoolProbability", "System.Single")]
            public partial System.Single HERO_POOL_PROBABILITY { get; set; } 
*/
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."AdvancedTrainingAthleteData"]
        /// </summary>
        partial struct Ptr_AdvancedTrainingAthleteData
        {
            /// <summary>
            ///   System.Void .ctor(System.Single heroPoolProbability)
            /// </summary>
            /// <param name = "heroPoolProbability">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void CTOR(System.Single heroPoolProbability); 
*/
            /// <summary>
            ///   System.Void Reset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET(); 
*/
            /// <summary>
            ///   System.Void UpdateHeroPoolProbability()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHeroPoolProbability", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_HERO_POOL_PROBABILITY(); 
*/
        }
    }
}