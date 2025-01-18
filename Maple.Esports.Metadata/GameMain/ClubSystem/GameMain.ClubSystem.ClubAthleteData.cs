using Maple.Esports.Metadata.GameMain.UnitSystem;
using Maple.MonoGameAssistant.Core;

namespace Maple.Esports.Metadata.GameMain.ClubSystem
{
 
    /// <summary>
    /// class ["Assembly-CSharp"."GameMain.ClubSystem"."ClubAthleteData"]
    /// [System.Object]
    /// [Utility.IReset]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ClubAthleteData>, Ptr_ClubAthleteData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "GameMain.ClubSystem", "ClubAthleteData", "GameMain.ClubSystem.ClubAthleteData")]
    public partial class ClubAthleteData
    {

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ClubAthleteData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ClubAthleteData(System.IntPtr ptr) => new Ptr_ClubAthleteData(ptr);
            public static implicit operator System.IntPtr(Ptr_ClubAthleteData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ClubAthleteData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }


        /// <summary>
        /// class ["Assembly-CSharp"."GameMain.ClubSystem"."ClubAthleteData"]
        /// </summary>
        public unsafe readonly partial struct Ptr_ClubAthleteData
        {
            /// <summary>
            /// 0x10 System.Collections.Generic.Dictionary<System.Guid , GameMain.AthleteSystem.Athlete> <Athletes>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Guid , GameMain.AthleteSystem.Athlete></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Athletes>k__BackingField", "System.Collections.Generic.Dictionary<System.Guid,GameMain.AthleteSystem.Athlete>")]
            public partial PMonoDictionary_Esports<Guid, AthleteSystem.Athlete.Ptr_Athlete> ATHLETES { get; }


            /// <summary>
            /// 0x18 System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , GameMain.AthleteSystem.Athlete> <Contestant>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , GameMain.AthleteSystem.Athlete></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Contestant>k__BackingField", "System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags,GameMain.AthleteSystem.Athlete>")]
            public partial PMonoDictionary_Esports<GameMain.UnitSystem.HeroRoleFlags, AthleteSystem.Athlete.Ptr_Athlete> CONTESTANT { get; }


            /// <summary>
            /// 0x20 System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , GameMain.AthleteSystem.Athlete> <ScrimmageContestant>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , GameMain.AthleteSystem.Athlete></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ScrimmageContestant>k__BackingField", "System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags,GameMain.AthleteSystem.Athlete>")]
            public partial PMonoDictionary_Esports<GameMain.UnitSystem.HeroRoleFlags, AthleteSystem.Athlete.Ptr_Athlete> SCRIMMAGE_CONTESTANT { get; }


            /// <summary>
            /// 0x28 System.Collections.Generic.List<GameMain.AthleteSystem.Athlete> <Substitute>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.Athlete></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Substitute>k__BackingField", "System.Collections.Generic.List<GameMain.AthleteSystem.Athlete>")]
            public partial PMonoList_S<AthleteSystem.Athlete.Ptr_Athlete> SUBSTITUTE { get; }

        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain.ClubSystem"."ClubAthleteData"]
        /// </summary>
        public unsafe readonly partial struct Ptr_ClubAthleteData
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void ChangeAthlete(GameMain.AthleteSystem.Athlete contestant, GameMain.AthleteSystem.Athlete substitute)
            /// </summary>
            /// <param name = "contestant">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "substitute">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeAthlete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 1)]
            public partial void CHANGE_ATHLETE(nint contestant, nint substitute); 
*/
            /// <summary>
            ///   System.Void ChangeHeroRole(GameMain.AthleteSystem.Athlete athlete0, GameMain.AthleteSystem.Athlete athlete1)
            /// </summary>
            /// <param name = "athlete0">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "athlete1">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeHeroRole", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 1)]
            public partial void CHANGE_HERO_ROLE(nint athlete0, nint athlete1); 
*/
            /// <summary>
            ///   System.Void Clear()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clear", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.Guid , GameMain.AthleteSystem.Athlete> get_Athletes()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Guid , GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Athletes", "System.Collections.Generic.Dictionary<System.Guid,GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATHLETES(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , GameMain.AthleteSystem.Athlete> get_Contestant()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Contestant", "System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags,GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CONTESTANT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , GameMain.AthleteSystem.Athlete> get_ScrimmageContestant()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags , GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ScrimmageContestant", "System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroRoleFlags,GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SCRIMMAGE_CONTESTANT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.AthleteSystem.Athlete> get_Substitute()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Substitute", "System.Collections.Generic.List<GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SUBSTITUTE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete> GetAthletes(System.Boolean order)
            /// </summary>
            /// <param name = "order">struct System.Boolean</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAthletes", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.Athlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_ATHLETES(System.Boolean order); 
*/
            /// <summary>
            ///   System.Boolean OnAddAthlete(GameMain.AthleteSystem.Athlete athlete, System.Int32 maxSubstitute, GameMain.ClubSystem.Club club, System.Boolean isNew)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "maxSubstitute">struct System.Int32</param>
            /// <param name = "club">class GameMain.ClubSystem.Club</param>
            /// <param name = "isNew">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddAthlete", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial System.Boolean ON_ADD_ATHLETE(nint athlete, System.Int32 maxSubstitute, nint club, System.Boolean isNew); 
*/
            /// <summary>
            ///   System.Boolean OnRemoveAthlete(GameMain.AthleteSystem.Athlete athlete, System.Boolean allowEmpty)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "allowEmpty">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveAthlete", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Boolean ON_REMOVE_ATHLETE(nint athlete, System.Boolean allowEmpty); 
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
            ///   System.Void SelectSubstitute(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SelectSubstitute", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial void SELECT_SUBSTITUTE(nint athlete); 
*/
            /// <summary>
            ///   System.Void SelectSubstitute(GameMain.UnitSystem.HeroRoleFlags role, GameMain.AthleteSystem.Athlete athlete, System.Boolean allRole)
            /// </summary>
            /// <param name = "role">enum GameMain.UnitSystem.HeroRoleFlags</param>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <param name = "allRole">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SelectSubstitute", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroRoleFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void SELECT_SUBSTITUTE(GameMain.UnitSystem.HeroRoleFlags role, nint athlete, System.Boolean allRole); 
*/
        }
    }
}