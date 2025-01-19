using Maple.MonoGameAssistant.Core;

namespace Maple.Esports.Metadata.GameMain.AthleteSystem
{
    /// <summary>
    /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthletePersonalData"]
    /// [Utility.IReset]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AthletePersonalData>, Ptr_AthletePersonalData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "GameMain.AthleteSystem", "AthletePersonalData", "GameMain.AthleteSystem.AthletePersonalData")]
    public partial class AthletePersonalData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct Ref_AthletePersonalData
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public PMonoString name;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public System.Single age;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC)]
            public System.Int32 careerLife;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public PMonoString portraitKey;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public GameMain.AthleteSystem.AthleteCharmRank charm;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AthletePersonalData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AthletePersonalData(System.IntPtr ptr) => new Ptr_AthletePersonalData(ptr);
            public static implicit operator System.IntPtr(Ptr_AthletePersonalData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_AthletePersonalData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthletePersonalData"]
        /// </summary>
        partial struct Ptr_AthletePersonalData
        {
            /// <summary>
            /// 0x10 System.String name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Single age
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("age", "System.Single")]
            public partial System.Single AGE { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 careerLife
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("careerLife", "System.Int32")]
            public partial System.Int32 CAREER_LIFE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String portraitKey
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("portraitKey", "System.String")]
            public partial nint PORTRAIT_KEY { get; set; } 
*/

            /// <summary>
            /// 0x28 GameMain.AthleteSystem.AthleteCharmRank charm
            /// enum ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteCharmRank"]
            /// </summary>
            /// <returns>enum GameMain.AthleteSystem.AthleteCharmRank</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("charm", "GameMain.AthleteSystem.AthleteCharmRank")]
            public partial GameMain.AthleteSystem.AthleteCharmRank CHARM { get; set; } 
*/
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthletePersonalData"]
        /// </summary>
        partial struct Ptr_AthletePersonalData
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
            ///   System.Void SetAge(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAge", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_AGE(System.Single value); 
*/
            /// <summary>
            ///   System.Void SetCareerLife(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCareerLife", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_CAREER_LIFE(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetCharm(GameMain.AthleteSystem.AthleteCharmRank rank)
            /// </summary>
            /// <param name = "rank">enum GameMain.AthleteSystem.AthleteCharmRank</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCharm", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteCharmRank", 0)]
            public partial void SET_CHARM(GameMain.AthleteSystem.AthleteCharmRank rank); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthletePersonalData SetPersonalData(System.String name, System.Int32 age, System.Int32 careerLife, System.String portraitKey)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <param name = "age">struct System.Int32</param>
            /// <param name = "careerLife">struct System.Int32</param>
            /// <param name = "portraitKey">class System.String</param>
            /// <returns>struct GameMain.AthleteSystem.AthletePersonalData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPersonalData", "GameMain.AthleteSystem.AthletePersonalData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            public partial GameMain.AthleteSystem.AthletePersonalData SET_PERSONAL_DATA(nint name, System.Int32 age, System.Int32 careerLife, nint portraitKey); 
*/
        }
    }
}