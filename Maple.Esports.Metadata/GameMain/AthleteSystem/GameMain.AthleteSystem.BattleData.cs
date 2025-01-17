namespace Maple.Esports.Metadata.GameMain.AthleteSystem
{
    /// <summary>
    /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."BattleData"]
    /// [Utility.IReset]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BattleData>, Ptr_BattleData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "GameMain.AthleteSystem", "BattleData", "GameMain.AthleteSystem.BattleData")]
    public partial class BattleData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct Ref_BattleData
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public System.Double athleteAccuracyFight;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x8)]
            public System.Double athleteEvasionFight;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x10)]
            public System.Double athleteAccuracyBattle;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x18)]
            public System.Double athleteEvasionBattle;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x20)]
            public System.Double athleteEcoEfficiency;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x28)]
            public System.Double athleteEcoTransferEfficiency;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x30)]
            public System.Double athleteEcoTransferEfficiencyAttack;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x38)]
            public System.Double athleteEcoTransferEfficiencyDefence;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x40)]
            public System.Double athleteFightSpeed;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x48)]
            public System.Int32 tacticPoint;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BattleData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BattleData(System.IntPtr ptr) => new Ptr_BattleData(ptr);
            public static implicit operator System.IntPtr(Ptr_BattleData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_BattleData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."BattleData"]
        /// </summary>
        partial struct Ptr_BattleData
        {
            /// <summary>
            /// 0x10 System.Double athleteAccuracyFight
            /// struct ["mscorlib"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteAccuracyFight", "System.Double")]
            public partial System.Double ATHLETE_ACCURACY_FIGHT { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Double athleteEvasionFight
            /// struct ["mscorlib"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteEvasionFight", "System.Double")]
            public partial System.Double ATHLETE_EVASION_FIGHT { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Double athleteAccuracyBattle
            /// struct ["mscorlib"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteAccuracyBattle", "System.Double")]
            public partial System.Double ATHLETE_ACCURACY_BATTLE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Double athleteEvasionBattle
            /// struct ["mscorlib"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteEvasionBattle", "System.Double")]
            public partial System.Double ATHLETE_EVASION_BATTLE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Double athleteEcoEfficiency
            /// struct ["mscorlib"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteEcoEfficiency", "System.Double")]
            public partial System.Double ATHLETE_ECO_EFFICIENCY { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Double athleteEcoTransferEfficiency
            /// struct ["mscorlib"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteEcoTransferEfficiency", "System.Double")]
            public partial System.Double ATHLETE_ECO_TRANSFER_EFFICIENCY { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Double athleteEcoTransferEfficiencyAttack
            /// struct ["mscorlib"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteEcoTransferEfficiencyAttack", "System.Double")]
            public partial System.Double ATHLETE_ECO_TRANSFER_EFFICIENCY_ATTACK { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Double athleteEcoTransferEfficiencyDefence
            /// struct ["mscorlib"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteEcoTransferEfficiencyDefence", "System.Double")]
            public partial System.Double ATHLETE_ECO_TRANSFER_EFFICIENCY_DEFENCE { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Double athleteFightSpeed
            /// struct ["mscorlib"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteFightSpeed", "System.Double")]
            public partial System.Double ATHLETE_FIGHT_SPEED { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Int32 tacticPoint
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tacticPoint", "System.Int32")]
            public partial System.Int32 TACTIC_POINT { get; set; } 
*/
        }

        /// <summary>
        /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."BattleData"]
        /// </summary>
        partial struct Ptr_BattleData
        {
            /// <summary>
            ///   System.Void Calculate(GameMain.AthleteSystem.Athlete athlete, GameMain.AthleteSystem.AthleteHeroData athleteHeroData, System.Boolean adjust)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "athleteHeroData">struct GameMain.AthleteSystem.AthleteHeroData</param>
            /// <param name = "adjust">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Calculate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteHeroData", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CALCULATE(nint athlete, GameMain.AthleteSystem.AthleteHeroData athleteHeroData, System.Boolean adjust); 
*/
            /// <summary>
            ///   System.Void Calculate(GameMain.AthleteSystem.Athlete athlete, System.Boolean adjust)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "adjust">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Calculate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void CALCULATE(nint athlete, System.Boolean adjust); 
*/
            /// <summary>
            ///   System.Void Calculate(GameMain.AthleteSystem.AthleteAbilitiesData abilities, GameMain.AthleteSystem.AthleteHeroData athleteHeroData)
            /// </summary>
            /// <param name = "abilities">struct GameMain.AthleteSystem.AthleteAbilitiesData</param>
            /// <param name = "athleteHeroData">struct GameMain.AthleteSystem.AthleteHeroData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Calculate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilitiesData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteHeroData", 1)]
            public partial void CALCULATE(GameMain.AthleteSystem.AthleteAbilitiesData abilities, GameMain.AthleteSystem.AthleteHeroData athleteHeroData); 
*/
            /// <summary>
            ///   System.Void Calculate(GameMain.AthleteSystem.AthleteAbilitiesData abilities)
            /// </summary>
            /// <param name = "abilities">struct GameMain.AthleteSystem.AthleteAbilitiesData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Calculate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilitiesData", 0)]
            public partial void CALCULATE(GameMain.AthleteSystem.AthleteAbilitiesData abilities); 
*/
            /// <summary>
            ///   System.Void Calculate(GameMain.AthleteSystem.AthleteHeroData athleteHeroData)
            /// </summary>
            /// <param name = "athleteHeroData">struct GameMain.AthleteSystem.AthleteHeroData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Calculate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteHeroData", 0)]
            public partial void CALCULATE(GameMain.AthleteSystem.AthleteHeroData athleteHeroData); 
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