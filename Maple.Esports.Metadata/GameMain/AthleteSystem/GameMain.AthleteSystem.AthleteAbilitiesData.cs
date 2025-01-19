namespace Maple.Esports.Metadata.GameMain.AthleteSystem
{
    /// <summary>
    /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilitiesData"]
    /// [Utility.IReset]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AthleteAbilitiesData>, Ptr_AthleteAbilitiesData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "GameMain.AthleteSystem", "AthleteAbilitiesData", "GameMain.AthleteSystem.AthleteAbilitiesData")]
    public partial class AthleteAbilitiesData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct Ref_AthleteAbilitiesData
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public System.Int32 limit;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
            public System.Int32 heroPoolCount;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public System.Boolean needB;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0xC)]
            public System.Single bRequire;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public System.Single bCurrent;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x14)]
            public System.Single bPreValue;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public GameMain.AthleteSystem.AthleteAbilityData.Ref_AthleteAbilityData aggressive;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public GameMain.AthleteSystem.AthleteAbilityData.Ref_AthleteAbilityData defence;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public GameMain.AthleteSystem.AthleteAbilityData.Ref_AthleteAbilityData farming;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public GameMain.AthleteSystem.AthleteAbilityData.Ref_AthleteAbilityData reflection;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x58)]
            public GameMain.AthleteSystem.AthleteAbilityData.Ref_AthleteAbilityData exercise;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AthleteAbilitiesData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AthleteAbilitiesData(System.IntPtr ptr) => new Ptr_AthleteAbilitiesData(ptr);
            public static implicit operator System.IntPtr(Ptr_AthleteAbilitiesData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_AthleteAbilitiesData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilitiesData"]
        /// </summary>
        partial struct Ptr_AthleteAbilitiesData
        {
            /// <summary>
            /// 0x10 System.Int32 limit
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("limit", "System.Int32")]
            public partial System.Int32 LIMIT { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 heroPoolCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroPoolCount", "System.Int32")]
            public partial System.Int32 HERO_POOL_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Boolean needB
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("needB", "System.Boolean")]
            public partial System.Boolean NEED_B { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Single bRequire
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bRequire", "System.Single")]
            public partial System.Single B_REQUIRE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Single bCurrent
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bCurrent", "System.Single")]
            public partial System.Single B_CURRENT { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Single bPreValue
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bPreValue", "System.Single")]
            public partial System.Single B_PRE_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x28 GameMain.AthleteSystem.AthleteAbilityData aggressive
            /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilityData"]
            /// </summary>
            /// <returns>struct GameMain.AthleteSystem.AthleteAbilityData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("aggressive", "GameMain.AthleteSystem.AthleteAbilityData")]
            public partial GameMain.AthleteSystem.AthleteAbilityData AGGRESSIVE { get; set; } 
*/

            /// <summary>
            /// 0x38 GameMain.AthleteSystem.AthleteAbilityData defence
            /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilityData"]
            /// </summary>
            /// <returns>struct GameMain.AthleteSystem.AthleteAbilityData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defence", "GameMain.AthleteSystem.AthleteAbilityData")]
            public partial GameMain.AthleteSystem.AthleteAbilityData DEFENCE { get; set; } 
*/

            /// <summary>
            /// 0x48 GameMain.AthleteSystem.AthleteAbilityData farming
            /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilityData"]
            /// </summary>
            /// <returns>struct GameMain.AthleteSystem.AthleteAbilityData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("farming", "GameMain.AthleteSystem.AthleteAbilityData")]
            public partial GameMain.AthleteSystem.AthleteAbilityData FARMING { get; set; } 
*/

            /// <summary>
            /// 0x58 GameMain.AthleteSystem.AthleteAbilityData reflection
            /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilityData"]
            /// </summary>
            /// <returns>struct GameMain.AthleteSystem.AthleteAbilityData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("reflection", "GameMain.AthleteSystem.AthleteAbilityData")]
            public partial GameMain.AthleteSystem.AthleteAbilityData REFLECTION { get; set; } 
*/

            /// <summary>
            /// 0x68 GameMain.AthleteSystem.AthleteAbilityData exercise
            /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilityData"]
            /// </summary>
            /// <returns>struct GameMain.AthleteSystem.AthleteAbilityData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("exercise", "GameMain.AthleteSystem.AthleteAbilityData")]
            public partial GameMain.AthleteSystem.AthleteAbilityData EXERCISE { get; set; } 
*/
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilitiesData"]
        /// </summary>
        partial struct Ptr_AthleteAbilitiesData
        {
            /// <summary>
            ///   System.Int32 GetAbilityExp(GameMain.AthleteSystem.AthleteAbilityFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityExp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            public partial System.Int32 GET_ABILITY_EXP(GameMain.AthleteSystem.AthleteAbilityFlags flag); 
*/
            /// <summary>
            ///   System.Single GetAbilityExpPercentage(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AthleteGeneralSetting setting)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "setting">class GameMain.AthleteSystem.AthleteGeneralSetting</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityExpPercentage", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteGeneralSetting", 1)]
            public partial System.Single GET_ABILITY_EXP_PERCENTAGE(GameMain.AthleteSystem.AthleteAbilityFlags flag, nint setting); 
*/
            /// <summary>
            ///   System.Int32 GetAbilityLevel(GameMain.AthleteSystem.AthleteAbilityFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            public partial System.Int32 GET_ABILITY_LEVEL(GameMain.AthleteSystem.AthleteAbilityFlags flag); 
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
            ///   System.Void ResetBreakThroughCounter()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetBreakThroughCounter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_BREAK_THROUGH_COUNTER(); 
*/
            /// <summary>
            ///   System.Void SetAbilityData(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AthleteAbilityData data)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "data">struct GameMain.AthleteSystem.AthleteAbilityData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAbilityData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityData", 1)]
            public partial void SET_ABILITY_DATA(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AthleteAbilityData data); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteAbilitiesData SetAbilityLevel(System.Collections.Generic.Dictionary<GameMain.AthleteSystem.AthleteAbilityFlags , System.Single> abilityDict)
            /// </summary>
            /// <param name = "abilityDict">class System.Collections.Generic.Dictionary<GameMain.AthleteSystem.AthleteAbilityFlags , System.Single></param>
            /// <returns>struct GameMain.AthleteSystem.AthleteAbilitiesData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAbilityLevel", "GameMain.AthleteSystem.AthleteAbilitiesData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<GameMain.AthleteSystem.AthleteAbilityFlags,System.Single>", 0)]
            public partial GameMain.AthleteSystem.AthleteAbilitiesData SET_ABILITY_LEVEL(nint abilityDict); 
*/
            /// <summary>
            ///   System.Void SetPotentialRank(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AbilityPotentialRank rank)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "rank">enum GameMain.AthleteSystem.AbilityPotentialRank</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPotentialRank", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AbilityPotentialRank", 1)]
            public partial void SET_POTENTIAL_RANK(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AbilityPotentialRank rank); 
*/
            /// <summary>
            ///   System.Boolean TryGetAbilityData(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AthleteAbilityData& data)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "data">struct GameMain.AthleteSystem.AthleteAbilityData&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryGetAbilityData", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityData&", 1)]
            public partial System.Boolean TRY_GET_ABILITY_DATA(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AthleteAbilityData &data); 
*/
        }
    }
}