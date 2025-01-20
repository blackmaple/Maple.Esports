namespace Maple.Esports.Metadata.GameMain.AthleteSystem
{
    /// <summary>
    /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteEmotionSetting"]
    /// [Utility.GameSystem.LogicFrameworkX.LogicItemSourceSetting<GameMain.AthleteSystem.AthleteEmotionSettingObject>]=>[Utility.GameSystem.LogicFrameworkX.LogicItemSourceSetting]=>[Utility.SettingSystem.Setting]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AthleteEmotionSetting>, Ptr_AthleteEmotionSetting>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "GameMain.AthleteSystem", "AthleteEmotionSetting", "GameMain.AthleteSystem.AthleteEmotionSetting")]
    public partial class AthleteEmotionSetting
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AthleteEmotionSetting(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AthleteEmotionSetting(System.IntPtr ptr) => new Ptr_AthleteEmotionSetting(ptr);
            public static implicit operator System.IntPtr(Ptr_AthleteEmotionSetting ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AthleteEmotionSetting ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteEmotionSetting"]
        /// </summary>
        partial struct Ptr_AthleteEmotionSetting
        {
            /// <summary>
            /// 0x10 Utility.SettingSystem.SettingInitContext <Context>k__BackingField
            /// class ["Utility"."Utility.SettingSystem"."SettingInitContext"]
            /// </summary>
            /// <returns>class Utility.SettingSystem.SettingInitContext</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Context>k__BackingField", "Utility.SettingSystem.SettingInitContext")]
            public partial nint CONTEXT { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String <Utility.SettingSystem.ISettingInternal.FullKey>k__BackingField
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Utility.SettingSystem.ISettingInternal.FullKey>k__BackingField", "System.String")]
            public partial nint UTILITY_SETTING_SYSTEM_I_SETTING_INTERNAL_FULL_KEY { get; set; } 
*/

            /// <summary>
            /// 0x20 Utility.SettingSystem.ISetting m_mainSetting
            /// interface ["Utility"."Utility.SettingSystem"."ISetting"]
            /// </summary>
            /// <returns>interface Utility.SettingSystem.ISetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_mainSetting", "Utility.SettingSystem.ISetting")]
            public partial nint M_MAIN_SETTING { get; set; } 
*/

            /// <summary>
            /// 0x28 Utility.SettingSystem.ISettingObject <Utility.SettingSystem.ISettingInternal.SettingObject>k__BackingField
            /// interface ["Utility"."Utility.SettingSystem"."ISettingObject"]
            /// </summary>
            /// <returns>interface Utility.SettingSystem.ISettingObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Utility.SettingSystem.ISettingInternal.SettingObject>k__BackingField", "Utility.SettingSystem.ISettingObject")]
            public partial nint UTILITY_SETTING_SYSTEM_I_SETTING_INTERNAL_SETTING_OBJECT { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.HashSet<Utility.SettingSystem.ISetting> m_subSettingSet
            /// class ["System.Core"."System.Collections.Generic"."HashSet`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.HashSet<Utility.SettingSystem.ISetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_subSettingSet", "System.Collections.Generic.HashSet<Utility.SettingSystem.ISetting>")]
            public partial nint M_SUB_SETTING_SET { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<Utility.SettingSystem.ISetting> m_subSettingList
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Utility.SettingSystem.ISetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_subSettingList", "System.Collections.Generic.List<Utility.SettingSystem.ISetting>")]
            public partial nint M_SUB_SETTING_LIST { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 m_initVersionNumber
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_initVersionNumber", "System.Int32")]
            public partial System.Int32 M_INIT_VERSION_NUMBER { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 m_lateInitVersionNumber
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_lateInitVersionNumber", "System.Int32")]
            public partial System.Int32 M_LATE_INIT_VERSION_NUMBER { get; set; } 
*/

            /// <summary>
            /// 0x48 Utility.GameSystem.LogicFrameworkX.LogicItemList m_logicItems
            /// class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicItemList"]
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicItemList</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_logicItems", "Utility.GameSystem.LogicFrameworkX.LogicItemList")]
            public partial nint M_LOGIC_ITEMS { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource> m_subLogicItemSources
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_subLogicItemSources", "System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource>")]
            public partial nint M_SUB_LOGIC_ITEM_SOURCES { get; set; } 
*/

            /// <summary>
            /// 0x58 Utility.GameSystem.LogicFrameworkX.ValueTableSetting <ValueTable>k__BackingField
            /// class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."ValueTableSetting"]
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.ValueTableSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ValueTable>k__BackingField", "Utility.GameSystem.LogicFrameworkX.ValueTableSetting")]
            public partial nint VALUE_TABLE { get; set; } 
*/

            /// <summary>
            /// 0x60 Utility.GameSystem.LogicFrameworkX.EffectorSetting <Effector>k__BackingField
            /// class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."EffectorSetting"]
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.EffectorSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Effector>k__BackingField", "Utility.GameSystem.LogicFrameworkX.EffectorSetting")]
            public partial nint EFFECTOR { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteEmotionSetting"]
        /// </summary>
        partial struct Ptr_AthleteEmotionSetting
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
            ///   System.String get_Desc()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Desc", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DESC(); 
*/
            /// <summary>
            ///   Utility.GameSystem.LogicFrameworkX.EffectorSetting get_Effector()
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.EffectorSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Effector", "Utility.GameSystem.LogicFrameworkX.EffectorSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EFFECTOR(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteEmotionForceChangeType get_ForceChangeType()
            /// </summary>
            /// <returns>enum GameMain.AthleteSystem.AthleteEmotionForceChangeType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ForceChangeType", "GameMain.AthleteSystem.AthleteEmotionForceChangeType", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.AthleteSystem.AthleteEmotionForceChangeType GET_FORCE_CHANGE_TYPE(); 
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
            ///   GameMain.AthleteSystem.AthleteEmotionType get_Type()
            /// </summary>
            /// <returns>enum GameMain.AthleteSystem.AthleteEmotionType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Type", "GameMain.AthleteSystem.AthleteEmotionType", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.AthleteSystem.AthleteEmotionType GET_TYPE(); 
*/
            /// <summary>
            ///   Utility.GameSystem.LogicFrameworkX.ValueTableSetting get_ValueTable()
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.ValueTableSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ValueTable", "Utility.GameSystem.LogicFrameworkX.ValueTableSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_VALUE_TABLE(); 
*/
            /// <summary>
            ///   System.Void OnInit(Utility.SettingSystem.SettingInitContext context)
            /// </summary>
            /// <param name = "context">class Utility.SettingSystem.SettingInitContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.SettingSystem.SettingInitContext", 0)]
            public partial void ON_INIT(nint context); 
*/
            /// <summary>
            ///   System.Void OnInitLogicItemSource(Utility.GameSystem.LogicFrameworkX.LogicItemList items, System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource> subSources)
            /// </summary>
            /// <param name = "items">class Utility.GameSystem.LogicFrameworkX.LogicItemList</param>
            /// <param name = "subSources">class System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInitLogicItemSource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GameSystem.LogicFrameworkX.LogicItemList", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource>", 1)]
            public partial void ON_INIT_LOGIC_ITEM_SOURCE(nint items, nint subSources); 
*/
            /// <summary>
            ///   System.Void set_Effector(Utility.GameSystem.LogicFrameworkX.EffectorSetting value)
            /// </summary>
            /// <param name = "value">class Utility.GameSystem.LogicFrameworkX.EffectorSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Effector", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GameSystem.LogicFrameworkX.EffectorSetting", 0)]
            public partial void SET_EFFECTOR(nint value); 
*/
            /// <summary>
            ///   System.Void set_ValueTable(Utility.GameSystem.LogicFrameworkX.ValueTableSetting value)
            /// </summary>
            /// <param name = "value">class Utility.GameSystem.LogicFrameworkX.ValueTableSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ValueTable", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GameSystem.LogicFrameworkX.ValueTableSetting", 0)]
            public partial void SET_VALUE_TABLE(nint value); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicItemSourceSetting`1"]
        /// </summary>
        partial struct Ptr_AthleteEmotionSetting
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
            ///   GameMain.AthleteSystem.AthleteEmotionSettingObject get_SettingObject()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteEmotionSettingObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SettingObject", "GameMain.AthleteSystem.AthleteEmotionSettingObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SETTING_OBJECT(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem"."Utility.GameSystem.LogicFrameworkX"."LogicItemSourceSetting"]
        /// </summary>
        partial struct Ptr_AthleteEmotionSetting
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
            ///  abstract System.Void OnInitLogicItemSource(Utility.GameSystem.LogicFrameworkX.LogicItemList items, System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource> subSources)
            /// </summary>
            /// <param name = "items">class Utility.GameSystem.LogicFrameworkX.LogicItemList</param>
            /// <param name = "subSources">class System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInitLogicItemSource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GameSystem.LogicFrameworkX.LogicItemList", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource>", 1)]
            public abstract partial void ON_INIT_LOGIC_ITEM_SOURCE(nint items, nint subSources); 
*/
            /// <summary>
            ///   System.Void OnLateInit(Utility.SettingSystem.SettingInitContext context)
            /// </summary>
            /// <param name = "context">class Utility.SettingSystem.SettingInitContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnLateInit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.SettingSystem.SettingInitContext", 0)]
            public partial void ON_LATE_INIT(nint context); 
*/
            /// <summary>
            ///   Utility.GameSystem.LogicFrameworkX.LogicItemList Utility.GameSystem.LogicFrameworkX.ILogicItemSource.get_LogicItems()
            /// </summary>
            /// <returns>class Utility.GameSystem.LogicFrameworkX.LogicItemList</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.GameSystem.LogicFrameworkX.ILogicItemSource.get_LogicItems", "Utility.GameSystem.LogicFrameworkX.LogicItemList", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint UTILITY_GAME_SYSTEM_LOGIC_FRAMEWORK_XI_LOGIC_ITEM_SOURCEGET_LOGIC_ITEMS(); 
*/
            /// <summary>
            ///   System.String Utility.GameSystem.LogicFrameworkX.ILogicItemSource.get_Name()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.GameSystem.LogicFrameworkX.ILogicItemSource.get_Name", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint UTILITY_GAME_SYSTEM_LOGIC_FRAMEWORK_XI_LOGIC_ITEM_SOURCEGET_NAME(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource> Utility.GameSystem.LogicFrameworkX.ILogicItemSource.get_SubLogicItemSources()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.GameSystem.LogicFrameworkX.ILogicItemSource.get_SubLogicItemSources", "System.Collections.Generic.List<Utility.GameSystem.LogicFrameworkX.ILogicItemSource>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint UTILITY_GAME_SYSTEM_LOGIC_FRAMEWORK_XI_LOGIC_ITEM_SOURCEGET_SUB_LOGIC_ITEM_SOURCES(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility"."Utility.SettingSystem"."Setting"]
        /// </summary>
        partial struct Ptr_AthleteEmotionSetting
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
            ///   Utility.SettingSystem.SettingInitContext get_Context()
            /// </summary>
            /// <returns>class Utility.SettingSystem.SettingInitContext</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Context", "Utility.SettingSystem.SettingInitContext", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CONTEXT(); 
*/
            /// <summary>
            ///   System.String get_Description()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Description", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DESCRIPTION(); 
*/
            /// <summary>
            ///   System.Boolean get_Enabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Enabled", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_ENABLED(); 
*/
            /// <summary>
            ///   System.String get_FullKey()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_FullKey", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FULL_KEY(); 
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
            ///   System.String get_Key()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Key", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_KEY(); 
*/
            /// <summary>
            ///   Utility.SettingSystem.ISetting get_MainSetting()
            /// </summary>
            /// <returns>interface Utility.SettingSystem.ISetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MainSetting", "Utility.SettingSystem.ISetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAIN_SETTING(); 
*/
            /// <summary>
            ///   Utility.SettingSystem.ISettingObject get_SettingObject()
            /// </summary>
            /// <returns>interface Utility.SettingSystem.ISettingObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SettingObject", "Utility.SettingSystem.ISettingObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SETTING_OBJECT(); 
*/
            /// <summary>
            ///   System.String get_ShowName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ShowName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SHOW_NAME(); 
*/
            /// <summary>
            ///   System.Boolean IsValid()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsValid", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_VALID(); 
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
            ///   System.Void OnInit(Utility.SettingSystem.SettingInitContext context)
            /// </summary>
            /// <param name = "context">class Utility.SettingSystem.SettingInitContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.SettingSystem.SettingInitContext", 0)]
            public partial void ON_INIT(nint context); 
*/
            /// <summary>
            ///   System.Void OnLateInit(Utility.SettingSystem.SettingInitContext context)
            /// </summary>
            /// <param name = "context">class Utility.SettingSystem.SettingInitContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnLateInit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.SettingSystem.SettingInitContext", 0)]
            public partial void ON_LATE_INIT(nint context); 
*/
            /// <summary>
            ///   System.Void set_Context(Utility.SettingSystem.SettingInitContext value)
            /// </summary>
            /// <param name = "value">class Utility.SettingSystem.SettingInitContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Context", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.SettingSystem.SettingInitContext", 0)]
            public partial void SET_CONTEXT(nint value); 
*/
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint TO_STRING(); 
*/
            /// <summary>
            ///   System.Void Utility.SettingSystem.ISettingInternal.AddSubSetting(Utility.SettingSystem.ISetting subSetting)
            /// </summary>
            /// <param name = "subSetting">interface Utility.SettingSystem.ISetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.SettingSystem.ISettingInternal.AddSubSetting", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.SettingSystem.ISetting", 0)]
            public partial void UTILITY_SETTING_SYSTEM_I_SETTING_INTERNAL_ADD_SUB_SETTING(nint subSetting); 
*/
            /// <summary>
            ///   System.Boolean Utility.SettingSystem.ISettingInternal.ContainsSubSetting(Utility.SettingSystem.ISetting subSetting)
            /// </summary>
            /// <param name = "subSetting">interface Utility.SettingSystem.ISetting</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.SettingSystem.ISettingInternal.ContainsSubSetting", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.SettingSystem.ISetting", 0)]
            public partial System.Boolean UTILITY_SETTING_SYSTEM_I_SETTING_INTERNAL_CONTAINS_SUB_SETTING(nint subSetting); 
*/
            /// <summary>
            ///   System.String Utility.SettingSystem.ISettingInternal.get_FullKey()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.SettingSystem.ISettingInternal.get_FullKey", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint UTILITY_SETTING_SYSTEM_I_SETTING_INTERNALGET_FULL_KEY(); 
*/
            /// <summary>
            ///   Utility.SettingSystem.ISetting Utility.SettingSystem.ISettingInternal.get_MainSetting()
            /// </summary>
            /// <returns>interface Utility.SettingSystem.ISetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.SettingSystem.ISettingInternal.get_MainSetting", "Utility.SettingSystem.ISetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint UTILITY_SETTING_SYSTEM_I_SETTING_INTERNALGET_MAIN_SETTING(); 
*/
            /// <summary>
            ///   Utility.SettingSystem.ISettingObject Utility.SettingSystem.ISettingInternal.get_SettingObject()
            /// </summary>
            /// <returns>interface Utility.SettingSystem.ISettingObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.SettingSystem.ISettingInternal.get_SettingObject", "Utility.SettingSystem.ISettingObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint UTILITY_SETTING_SYSTEM_I_SETTING_INTERNALGET_SETTING_OBJECT(); 
*/
            /// <summary>
            ///   System.Void Utility.SettingSystem.ISettingInternal.Init(Utility.SettingSystem.SettingInitContext context)
            /// </summary>
            /// <param name = "context">class Utility.SettingSystem.SettingInitContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.SettingSystem.ISettingInternal.Init", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.SettingSystem.SettingInitContext", 0)]
            public partial void UTILITY_SETTING_SYSTEM_I_SETTING_INTERNAL_INIT(nint context); 
*/
            /// <summary>
            ///   System.Void Utility.SettingSystem.ISettingInternal.LateInit(Utility.SettingSystem.SettingInitContext context)
            /// </summary>
            /// <param name = "context">class Utility.SettingSystem.SettingInitContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.SettingSystem.ISettingInternal.LateInit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.SettingSystem.SettingInitContext", 0)]
            public partial void UTILITY_SETTING_SYSTEM_I_SETTING_INTERNAL_LATE_INIT(nint context); 
*/
            /// <summary>
            ///   System.Void Utility.SettingSystem.ISettingInternal.OnCreate()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.SettingSystem.ISettingInternal.OnCreate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UTILITY_SETTING_SYSTEM_I_SETTING_INTERNAL_ON_CREATE(); 
*/
            /// <summary>
            ///   System.Void Utility.SettingSystem.ISettingInternal.set_FullKey(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.SettingSystem.ISettingInternal.set_FullKey", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void UTILITY_SETTING_SYSTEM_I_SETTING_INTERNALSET_FULL_KEY(nint value); 
*/
            /// <summary>
            ///   System.Void Utility.SettingSystem.ISettingInternal.set_MainSetting(Utility.SettingSystem.ISetting value)
            /// </summary>
            /// <param name = "value">interface Utility.SettingSystem.ISetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.SettingSystem.ISettingInternal.set_MainSetting", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.SettingSystem.ISetting", 0)]
            public partial void UTILITY_SETTING_SYSTEM_I_SETTING_INTERNALSET_MAIN_SETTING(nint value); 
*/
            /// <summary>
            ///   System.Void Utility.SettingSystem.ISettingInternal.set_SettingObject(Utility.SettingSystem.ISettingObject value)
            /// </summary>
            /// <param name = "value">interface Utility.SettingSystem.ISettingObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.SettingSystem.ISettingInternal.set_SettingObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.SettingSystem.ISettingObject", 0)]
            public partial void UTILITY_SETTING_SYSTEM_I_SETTING_INTERNALSET_SETTING_OBJECT(nint value); 
*/
        }
    }
}