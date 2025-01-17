namespace Maple.Esports.Metadata.GameMain.AthleteSystem
{
    /// <summary>
    /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteEmotion"]
    /// [Utility.GameSystem.LogicFrameworkX.LogicObject<GameMain.AthleteSystem.AthleteEmotion , LogicFramework.LogicEntity_AthleteEmotion>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject<GameMain.AthleteSystem.AthleteEmotion>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject]=>[Utility.GeneralObject.GeneralObject]=>[System.Object]
    /// [Utility.GameSystem.SaveSystem.ISavable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AthleteEmotion>, Ptr_AthleteEmotion>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "GameMain.AthleteSystem", "AthleteEmotion", "GameMain.AthleteSystem.AthleteEmotion")]
    public partial class AthleteEmotion
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AthleteEmotion(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AthleteEmotion(System.IntPtr ptr) => new Ptr_AthleteEmotion(ptr);
            public static implicit operator System.IntPtr(Ptr_AthleteEmotion ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AthleteEmotion ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteEmotion"]
        /// </summary>
        partial struct Ptr_AthleteEmotion
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.Guid , Utility.GeneralObject.GeneralObject> Dict
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Guid , Utility.GeneralObject.GeneralObject></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Dict", "System.Collections.Generic.Dictionary<System.Guid,Utility.GeneralObject.GeneralObject>")]
            public static partial nint DICT { get; set; } 
*/

            /// <summary>
            /// 0x10 Utility.GeneralObject.C_SettingLogic m_cSettingLogic
            /// class ["Utility"."Utility.GeneralObject"."C_SettingLogic"]
            /// </summary>
            /// <returns>class Utility.GeneralObject.C_SettingLogic</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_cSettingLogic", "Utility.GeneralObject.C_SettingLogic")]
            public partial nint M_C_SETTING_LOGIC { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent> m_components
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_components", "System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent>")]
            public partial nint M_COMPONENTS { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent> m_components_public
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_components_public", "System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent>")]
            public partial nint M_COMPONENTS_PUBLIC { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent> m_components_update
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_components_update", "System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent>")]
            public partial nint M_COMPONENTS_UPDATE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent> m_components_temp
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_components_temp", "System.Collections.Generic.List<Utility.GeneralObject.GeneralObject.IComponent>")]
            public partial nint M_COMPONENTS_TEMP { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.Dictionary<Utility.GeneralObject.GeneralObject.IComponent , Utility.GeneralObject.GeneralObject.ComponentData> m_componentsData
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<Utility.GeneralObject.GeneralObject.IComponent , Utility.GeneralObject.GeneralObject.ComponentData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_componentsData", "System.Collections.Generic.Dictionary<Utility.GeneralObject.GeneralObject.IComponent,Utility.GeneralObject.GeneralObject.ComponentData>")]
            public partial nint M_COMPONENTS_DATA { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> <Components>k__BackingField
            /// class ["mscorlib"."System.Collections.ObjectModel"."ReadOnlyCollection`1"]
            /// </summary>
            /// <returns>class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Components>k__BackingField", "System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>")]
            public partial nint COMPONENTS { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> <Components_Update>k__BackingField
            /// class ["mscorlib"."System.Collections.ObjectModel"."ReadOnlyCollection`1"]
            /// </summary>
            /// <returns>class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Components_Update>k__BackingField", "System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>")]
            public partial nint COMPONENTS_UPDATE { get; set; } 
*/

            /// <summary>
            /// 0x50 Utility.TimeData <TimeData>k__BackingField
            /// class ["Utility"."Utility"."TimeData"]
            /// </summary>
            /// <returns>class Utility.TimeData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<TimeData>k__BackingField", "Utility.TimeData")]
            public partial nint TIME_DATA { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Boolean m_initialized
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_initialized", "System.Boolean")]
            public partial System.Boolean M_INITIALIZED { get; set; } 
*/

            /// <summary>
            /// 0x59 System.Boolean m_canAddPersistComponent
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_canAddPersistComponent", "System.Boolean")]
            public partial System.Boolean M_CAN_ADD_PERSIST_COMPONENT { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Guid <Id>k__BackingField
            /// struct ["mscorlib"."System"."Guid"]
            /// </summary>
            /// <returns>struct System.Guid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Id>k__BackingField", "System.Guid")]
            public partial System.Guid ID { get; set; } 
*/

            /// <summary>
            /// 0x6C System.Int32 <Utility.PoolSystem.IPoolItem.SpawnId>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Utility.PoolSystem.IPoolItem.SpawnId>k__BackingField", "System.Int32")]
            public partial System.Int32 UTILITY_POOL_SYSTEM_I_POOL_ITEM_SPAWN_ID { get; set; } 
*/

            /// <summary>
            /// 0x70 Utility.GameSystem.LogicFrameworkX.LogicEntity <Entity>k__BackingField
            /// class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicEntity"]
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicEntity</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Entity>k__BackingField", "Utility.GameSystem.LogicFrameworkX.LogicEntity")]
            public partial nint ENTITY { get; set; } 
*/

            /// <summary>
            /// 0x78 Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.AthleteEmotion , LogicFramework.LogicEntity_AthleteEmotion , GameMain.AthleteSystem.AthleteEmotionSetting> <C_Setting>k__BackingField
            /// class ["Utility.GameSystem".""."SettingComponent`1"]
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.AthleteEmotion , LogicFramework.LogicEntity_AthleteEmotion , GameMain.AthleteSystem.AthleteEmotionSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<C_Setting>k__BackingField", "Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.AthleteEmotion,LogicFramework.LogicEntity_AthleteEmotion,GameMain.AthleteSystem.AthleteEmotionSetting>")]
            public partial nint C_SETTING { get; set; } 
*/

            /// <summary>
            /// 0x80 GameMain.AthleteSystem.Athlete <Athlete>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."Athlete"]
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Athlete>k__BackingField", "GameMain.AthleteSystem.Athlete")]
            public partial nint ATHLETE { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Int32 <UnchangeRecord>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<UnchangeRecord>k__BackingField", "System.Int32")]
            public partial System.Int32 UNCHANGE_RECORD { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteEmotion"]
        /// </summary>
        partial struct Ptr_AthleteEmotion
        {
            /// <summary>
            /// static  System.Void Despawn(GameMain.AthleteSystem.AthleteEmotion obj)
            /// </summary>
            /// <param name = "obj">class GameMain.AthleteSystem.AthleteEmotion</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Despawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteEmotion", 0)]
            public static partial void DESPAWN(nint obj); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.AthleteEmotion Spawn()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteEmotion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.AthleteSystem.AthleteEmotion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint SPAWN(); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.AthleteEmotion Spawn(GameMain.AthleteSystem.AthleteEmotionSetting setting, GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "setting">class GameMain.AthleteSystem.AthleteEmotionSetting</param>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>class GameMain.AthleteSystem.AthleteEmotion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.AthleteSystem.AthleteEmotion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteEmotionSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 1)]
            public static partial nint SPAWN(nint setting, nint athlete); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.AthleteEmotion Spawn(System.Int32 level, GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>class GameMain.AthleteSystem.AthleteEmotion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Spawn", "GameMain.AthleteSystem.AthleteEmotion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 1)]
            public static partial nint SPAWN(System.Int32 level, nint athlete); 
*/
            /// <summary>
            /// static  GameMain.AthleteSystem.AthleteEmotion SpawnDefault(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>class GameMain.AthleteSystem.AthleteEmotion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnDefault", "GameMain.AthleteSystem.AthleteEmotion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public static partial nint SPAWN_DEFAULT(nint athlete); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void ChangeCheck(System.Nullable<GameMain.AthleteSystem.AthleteEmotionChangeData> changeData)
            /// </summary>
            /// <param name = "changeData">struct System.Nullable<GameMain.AthleteSystem.AthleteEmotionChangeData></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeCheck", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Nullable<GameMain.AthleteSystem.AthleteEmotionChangeData>", 0)]
            public partial void CHANGE_CHECK(System.Nullable<GameMain.AthleteSystem.AthleteEmotionChangeData> changeData); 
*/
            /// <summary>
            ///   System.Void Degrade(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Degrade", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void DEGRADE(System.Int32 value); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.Athlete get_Athlete()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Athlete", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATHLETE(); 
*/
            /// <summary>
            ///   Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.AthleteEmotion , LogicFramework.LogicEntity_AthleteEmotion , GameMain.AthleteSystem.AthleteEmotionSetting> get_C_Setting()
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.AthleteEmotion , LogicFramework.LogicEntity_AthleteEmotion , GameMain.AthleteSystem.AthleteEmotionSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_C_Setting", "Utility.GameSystem.LogicFrameworkX.LogicObject.SettingComponent<GameMain.AthleteSystem.AthleteEmotion,LogicFramework.LogicEntity_AthleteEmotion,GameMain.AthleteSystem.AthleteEmotionSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_C_SETTING(); 
*/
            /// <summary>
            ///   System.Single get_DegradeChance()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DegradeChance", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_DEGRADE_CHANCE(); 
*/
            /// <summary>
            ///   System.Int32 get_ForceChangeThreshold()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ForceChangeThreshold", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_FORCE_CHANGE_THRESHOLD(); 
*/
            /// <summary>
            ///   System.Int32 get_Level()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Level", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_LEVEL(); 
*/
            /// <summary>
            ///   System.Type get_SaveDataType()
            /// </summary>
            /// <returns>abstract class System.Type</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SaveDataType", "System.Type", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SAVE_DATA_TYPE(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteEmotionSetting get_Setting()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteEmotionSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Setting", "GameMain.AthleteSystem.AthleteEmotionSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SETTING(); 
*/
            /// <summary>
            ///   System.Int32 get_UnchangeRecord()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_UnchangeRecord", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_UNCHANGE_RECORD(); 
*/
            /// <summary>
            ///   System.Single get_UpgradeChance()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_UpgradeChance", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_UPGRADE_CHANCE(); 
*/
            /// <summary>
            ///   System.Void OnAddToAthlete(GameMain.AthleteSystem.Athlete athlete)
            /// </summary>
            /// <param name = "athlete">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddToAthlete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial void ON_ADD_TO_ATHLETE(nint athlete); 
*/
            /// <summary>
            ///   System.Void OnDespawn(Utility.PoolSystem.PoolEventContext context)
            /// </summary>
            /// <param name = "context">struct Utility.PoolSystem.PoolEventContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDespawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.PoolSystem.PoolEventContext", 0)]
            public partial void ON_DESPAWN(Utility.PoolSystem.PoolEventContext context); 
*/
            /// <summary>
            ///   System.Void OnRemoveFromAthlete()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveFromAthlete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_REMOVE_FROM_ATHLETE(); 
*/
            /// <summary>
            ///   System.Void set_Athlete(GameMain.AthleteSystem.Athlete value)
            /// </summary>
            /// <param name = "value">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Athlete", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial void SET_ATHLETE(nint value); 
*/
            /// <summary>
            ///   System.Void set_UnchangeRecord(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_UnchangeRecord", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_UNCHANGE_RECORD(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetLevel(System.Int32 level)
            /// </summary>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_LEVEL(System.Int32 level); 
*/
            /// <summary>
            ///   LogicFramework.LogicEntity_AthleteEmotion SpawnEntity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_AthleteEmotion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnEntity", "LogicFramework.LogicEntity_AthleteEmotion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SPAWN_ENTITY(); 
*/
            /// <summary>
            ///   System.Void Upgrade(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Upgrade", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPGRADE(System.Int32 value); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicObject`1"]
        /// </summary>
        partial struct Ptr_AthleteEmotion
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicObject`2"]
        /// </summary>
        partial struct Ptr_AthleteEmotion
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
            ///   LogicFramework.LogicEntity_AthleteEmotion get_Entity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_AthleteEmotion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Entity", "LogicFramework.LogicEntity_AthleteEmotion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ENTITY(); 
*/
            /// <summary>
            ///   System.Void OnDespawn(Utility.PoolSystem.PoolEventContext context)
            /// </summary>
            /// <param name = "context">struct Utility.PoolSystem.PoolEventContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDespawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.PoolSystem.PoolEventContext", 0)]
            public partial void ON_DESPAWN(Utility.PoolSystem.PoolEventContext context); 
*/
            /// <summary>
            ///   System.Void OnSpawn(Utility.PoolSystem.PoolEventContext context)
            /// </summary>
            /// <param name = "context">struct Utility.PoolSystem.PoolEventContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSpawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.PoolSystem.PoolEventContext", 0)]
            public partial void ON_SPAWN(Utility.PoolSystem.PoolEventContext context); 
*/
            /// <summary>
            ///   System.Void set_Entity(LogicFramework.LogicEntity_AthleteEmotion value)
            /// </summary>
            /// <param name = "value">class LogicFramework.LogicEntity_AthleteEmotion</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Entity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("LogicFramework.LogicEntity_AthleteEmotion", 0)]
            public partial void SET_ENTITY(nint value); 
*/
            /// <summary>
            ///  abstract LogicFramework.LogicEntity_AthleteEmotion SpawnEntity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_AthleteEmotion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SpawnEntity", "LogicFramework.LogicEntity_AthleteEmotion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public abstract partial nint SPAWN_ENTITY(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility"."Utility.GeneralObject"."GeneralObject"]
        /// </summary>
        partial struct Ptr_AthleteEmotion
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Boolean Contains(System.Guid id)
            /// </summary>
            /// <param name = "id">struct System.Guid</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public static partial System.Boolean CONTAINS(System.Guid id); 
*/
            /// <summary>
            /// static  Utility.GeneralObject.GeneralObject Get(System.Guid id)
            /// </summary>
            /// <param name = "id">struct System.Guid</param>
            /// <returns>abstract class Utility.GeneralObject.GeneralObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "Utility.GeneralObject.GeneralObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public static partial nint GET(System.Guid id); 
*/
            /// <summary>
            /// static  T Get(System.Guid id)
            /// </summary>
            /// <param name = "id">struct System.Guid</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public static partial nint GET(System.Guid id); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void AddComponentInternal(Utility.GeneralObject.GeneralObject.IComponent component, System.String name, System.Boolean isPublic, System.Boolean isTemp)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <param name = "name">class System.String</param>
            /// <param name = "isPublic">struct System.Boolean</param>
            /// <param name = "isTemp">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddComponentInternal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void ADD_COMPONENT_INTERNAL(nint component, nint name, System.Boolean isPublic, System.Boolean isTemp); 
*/
            /// <summary>
            ///   Utility.GeneralObject.GeneralObject.IComponent AddPersistComponent(Utility.GeneralObject.GeneralObject.IComponent component, System.String name, System.Boolean isPublic)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <param name = "name">class System.String</param>
            /// <param name = "isPublic">struct System.Boolean</param>
            /// <returns>interface Utility.GeneralObject.GeneralObject.IComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPersistComponent", "Utility.GeneralObject.GeneralObject.IComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial nint ADD_PERSIST_COMPONENT(nint component, nint name, System.Boolean isPublic); 
*/
            /// <summary>
            ///   T AddPersistComponent(System.String name, System.Boolean isPublic)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <param name = "isPublic">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPersistComponent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint ADD_PERSIST_COMPONENT(nint name, System.Boolean isPublic); 
*/
            /// <summary>
            ///   Utility.GeneralObject.GeneralObject.IComponent AddTempComponent(Utility.GeneralObject.GeneralObject.IComponent component, System.String name, System.Boolean isPublic)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <param name = "name">class System.String</param>
            /// <param name = "isPublic">struct System.Boolean</param>
            /// <returns>interface Utility.GeneralObject.GeneralObject.IComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTempComponent", "Utility.GeneralObject.GeneralObject.IComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial nint ADD_TEMP_COMPONENT(nint component, nint name, System.Boolean isPublic); 
*/
            /// <summary>
            ///   T AddTempComponent(System.String name, System.Boolean isPublic)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <param name = "isPublic">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTempComponent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint ADD_TEMP_COMPONENT(nint name, System.Boolean isPublic); 
*/
            /// <summary>
            ///   System.Void AfterInitInternalComponents()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AfterInitInternalComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AFTER_INIT_INTERNAL_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void BeforeInitInternalComponents()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BeforeInitInternalComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void BEFORE_INIT_INTERNAL_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void Despawn()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Despawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void DESPAWN(); 
*/
            /// <summary>
            ///   System.Void DespawnTempComponents()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DespawnTempComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void DESPAWN_TEMP_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> get_Components()
            /// </summary>
            /// <returns>class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Components", "System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> get_Components_Update()
            /// </summary>
            /// <returns>class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Components_Update", "System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS_UPDATE(); 
*/
            /// <summary>
            ///   System.Guid get_Id()
            /// </summary>
            /// <returns>struct System.Guid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Id", "System.Guid", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Guid GET_ID(); 
*/
            /// <summary>
            ///   System.Boolean get_KeepUpdate()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_KeepUpdate", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_KEEP_UPDATE(); 
*/
            /// <summary>
            ///   System.String get_Name()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Name", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NAME(); 
*/
            /// <summary>
            ///   Utility.TimeData get_TimeData()
            /// </summary>
            /// <returns>class Utility.TimeData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TimeData", "Utility.TimeData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TIME_DATA(); 
*/
            /// <summary>
            ///   System.Single get_TimeScale()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TimeScale", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_TIME_SCALE(); 
*/
            /// <summary>
            ///   Utility.GeneralObject.GeneralObject.IComponent GetComponent(System.Type componentType)
            /// </summary>
            /// <param name = "componentType">abstract class System.Type</param>
            /// <returns>interface Utility.GeneralObject.GeneralObject.IComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponent", "Utility.GeneralObject.GeneralObject.IComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public partial nint GET_COMPONENT(nint componentType); 
*/
            /// <summary>
            ///   TComponent GetComponent()
            /// </summary>
            /// <returns>class TComponent</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponent", "TComponent", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENT(); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Type componentType, System.Collections.Generic.ICollection<Utility.GeneralObject.GeneralObject.IComponent> result)
            /// </summary>
            /// <param name = "componentType">abstract class System.Type</param>
            /// <param name = "result">interface System.Collections.Generic.ICollection<Utility.GeneralObject.GeneralObject.IComponent></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.ICollection<Utility.GeneralObject.GeneralObject.IComponent>", 1)]
            public partial void GET_COMPONENTS(nint componentType, nint result); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Collections.Generic.ICollection<TComponent> result)
            /// </summary>
            /// <param name = "result">interface System.Collections.Generic.ICollection<TComponent></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.ICollection<TComponent>", 0)]
            public partial void GET_COMPONENTS(nint result); 
*/
            /// <summary>
            ///   Utility.SettingSystem.Setting GetSetting()
            /// </summary>
            /// <returns>abstract class Utility.SettingSystem.Setting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSetting", "Utility.SettingSystem.Setting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SETTING(); 
*/
            /// <summary>
            ///   System.Void InitInternalComponents()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitInternalComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_INTERNAL_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void OnAddComponent(Utility.GeneralObject.GeneralObject.IComponent component)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddComponent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            public partial void ON_ADD_COMPONENT(nint component); 
*/
            /// <summary>
            ///   System.Void OnCreate()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnCreate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_CREATE(); 
*/
            /// <summary>
            ///   System.Void OnDeserializedMethod(System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDeserializedMethod", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 0)]
            public partial void ON_DESERIALIZED_METHOD(System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void OnDeserializingMethod(System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDeserializingMethod", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 0)]
            public partial void ON_DESERIALIZING_METHOD(System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void OnDespawn(Utility.PoolSystem.PoolEventContext context)
            /// </summary>
            /// <param name = "context">struct Utility.PoolSystem.PoolEventContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDespawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.PoolSystem.PoolEventContext", 0)]
            public partial void ON_DESPAWN(Utility.PoolSystem.PoolEventContext context); 
*/
            /// <summary>
            ///   System.Void OnRemoveComponent(Utility.GeneralObject.GeneralObject.IComponent component)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnRemoveComponent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            public partial void ON_REMOVE_COMPONENT(nint component); 
*/
            /// <summary>
            ///   System.Void OnReset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnReset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_RESET(); 
*/
            /// <summary>
            ///   System.Void OnSerializedMethod(System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSerializedMethod", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 0)]
            public partial void ON_SERIALIZED_METHOD(System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void OnSerializingMethod(System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSerializingMethod", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 0)]
            public partial void ON_SERIALIZING_METHOD(System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void OnSpawn(Utility.PoolSystem.PoolEventContext context)
            /// </summary>
            /// <param name = "context">struct Utility.PoolSystem.PoolEventContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSpawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.PoolSystem.PoolEventContext", 0)]
            public partial void ON_SPAWN(Utility.PoolSystem.PoolEventContext context); 
*/
            /// <summary>
            ///   System.Void OnStart()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START(); 
*/
            /// <summary>
            ///   System.Void OnStart(Utility.UpdaterSystem.UpdateContext context)
            /// </summary>
            /// <param name = "context">struct Utility.UpdaterSystem.UpdateContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.UpdaterSystem.UpdateContext", 0)]
            public partial void ON_START(Utility.UpdaterSystem.UpdateContext context); 
*/
            /// <summary>
            ///   System.Void OnUpdate(Utility.UpdaterSystem.UpdateContext context)
            /// </summary>
            /// <param name = "context">struct Utility.UpdaterSystem.UpdateContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnUpdate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.UpdaterSystem.UpdateContext", 0)]
            public partial void ON_UPDATE(Utility.UpdaterSystem.UpdateContext context); 
*/
            /// <summary>
            ///   System.Void RemoveComponentInternal(Utility.GeneralObject.GeneralObject.IComponent component, Utility.GeneralObject.GeneralObject.ComponentData data)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <param name = "data">struct Utility.GeneralObject.GeneralObject.ComponentData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveComponentInternal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.ComponentData", 1)]
            public partial void REMOVE_COMPONENT_INTERNAL(nint component, Utility.GeneralObject.GeneralObject.ComponentData data); 
*/
            /// <summary>
            ///   System.Boolean RemoveTempComponent(Utility.GeneralObject.GeneralObject.IComponent component)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveTempComponent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            public partial System.Boolean REMOVE_TEMP_COMPONENT(nint component); 
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
            ///   System.Void ResetAllComponents()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetAllComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_ALL_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void set_Components(System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> value)
            /// </summary>
            /// <param name = "value">class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Components", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>", 0)]
            public partial void SET_COMPONENTS(nint value); 
*/
            /// <summary>
            ///   System.Void set_Components_Update(System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent> value)
            /// </summary>
            /// <param name = "value">class System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Components_Update", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.ObjectModel.ReadOnlyCollection<Utility.GeneralObject.GeneralObject.IComponent>", 0)]
            public partial void SET_COMPONENTS_UPDATE(nint value); 
*/
            /// <summary>
            ///   System.Void set_Id(System.Guid value)
            /// </summary>
            /// <param name = "value">struct System.Guid</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Id", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial void SET_ID(System.Guid value); 
*/
            /// <summary>
            ///   System.Void SetComponentActive(Utility.GeneralObject.GeneralObject.IComponent component, System.Boolean active)
            /// </summary>
            /// <param name = "component">interface Utility.GeneralObject.GeneralObject.IComponent</param>
            /// <param name = "active">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetComponentActive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SET_COMPONENT_ACTIVE(nint component, System.Boolean active); 
*/
            /// <summary>
            ///   System.Void Utility.IReset.Reset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.IReset.Reset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UTILITY_I_RESET_RESET(); 
*/
            /// <summary>
            ///   System.Int32 Utility.PoolSystem.IPoolItem.get_SpawnId()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.PoolSystem.IPoolItem.get_SpawnId", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 UTILITY_POOL_SYSTEM_I_POOL_ITEMGET_SPAWN_ID(); 
*/
            /// <summary>
            ///   System.Void Utility.PoolSystem.IPoolItem.OnDespawn(Utility.PoolSystem.PoolEventContext context)
            /// </summary>
            /// <param name = "context">struct Utility.PoolSystem.PoolEventContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.PoolSystem.IPoolItem.OnDespawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.PoolSystem.PoolEventContext", 0)]
            public partial void UTILITY_POOL_SYSTEM_I_POOL_ITEM_ON_DESPAWN(Utility.PoolSystem.PoolEventContext context); 
*/
            /// <summary>
            ///   System.Void Utility.PoolSystem.IPoolItem.OnSpawn(Utility.PoolSystem.PoolEventContext context)
            /// </summary>
            /// <param name = "context">struct Utility.PoolSystem.PoolEventContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.PoolSystem.IPoolItem.OnSpawn", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.PoolSystem.PoolEventContext", 0)]
            public partial void UTILITY_POOL_SYSTEM_I_POOL_ITEM_ON_SPAWN(Utility.PoolSystem.PoolEventContext context); 
*/
            /// <summary>
            ///   System.Void Utility.PoolSystem.IPoolItem.set_SpawnId(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.PoolSystem.IPoolItem.set_SpawnId", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UTILITY_POOL_SYSTEM_I_POOL_ITEMSET_SPAWN_ID(System.Int32 value); 
*/
            /// <summary>
            ///   System.Boolean Utility.UpdaterSystem.IUpdatable.get_KeepUpdate()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.UpdaterSystem.IUpdatable.get_KeepUpdate", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean UTILITY_UPDATER_SYSTEM_I_UPDATABLEGET_KEEP_UPDATE(); 
*/
            /// <summary>
            ///   Utility.TimeData Utility.UpdaterSystem.IUpdatable.get_TimeData()
            /// </summary>
            /// <returns>class Utility.TimeData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.UpdaterSystem.IUpdatable.get_TimeData", "Utility.TimeData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint UTILITY_UPDATER_SYSTEM_I_UPDATABLEGET_TIME_DATA(); 
*/
            /// <summary>
            ///   System.Single Utility.UpdaterSystem.IUpdatable.get_TimeScale()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.UpdaterSystem.IUpdatable.get_TimeScale", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single UTILITY_UPDATER_SYSTEM_I_UPDATABLEGET_TIME_SCALE(); 
*/
            /// <summary>
            ///   System.Void Utility.UpdaterSystem.IUpdatable.OnStart(Utility.UpdaterSystem.UpdateContext context)
            /// </summary>
            /// <param name = "context">struct Utility.UpdaterSystem.UpdateContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.UpdaterSystem.IUpdatable.OnStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.UpdaterSystem.UpdateContext", 0)]
            public partial void UTILITY_UPDATER_SYSTEM_I_UPDATABLE_ON_START(Utility.UpdaterSystem.UpdateContext context); 
*/
            /// <summary>
            ///   System.Void Utility.UpdaterSystem.IUpdatable.OnUpdate(Utility.UpdaterSystem.UpdateContext context)
            /// </summary>
            /// <param name = "context">struct Utility.UpdaterSystem.UpdateContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.UpdaterSystem.IUpdatable.OnUpdate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.UpdaterSystem.UpdateContext", 0)]
            public partial void UTILITY_UPDATER_SYSTEM_I_UPDATABLE_ON_UPDATE(Utility.UpdaterSystem.UpdateContext context); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicObject"]
        /// </summary>
        partial struct Ptr_AthleteEmotion
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
            ///   Utility.GameSystem.LogicFrameworkX.LogicEntity get_Entity()
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicEntity</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Entity", "Utility.GameSystem.LogicFrameworkX.LogicEntity", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ENTITY(); 
*/
            /// <summary>
            ///   System.Void set_Entity(Utility.GameSystem.LogicFrameworkX.LogicEntity value)
            /// </summary>
            /// <param name = "value">class Utility.GameSystem.LogicFrameworkX.LogicEntity</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Entity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GameSystem.LogicFrameworkX.LogicEntity", 0)]
            public partial void SET_ENTITY(nint value); 
*/
        }
    }
}