namespace Maple.Esports.Metadata.GameMain.AthleteSystem
{
    /// <summary>
    /// class ["Assembly-CSharp".""."DataComponent"]
    /// [Utility.GameSystem.LogicFrameworkX.LogicObject.BaseDataComponent<GameMain.AthleteSystem.Athlete , LogicFramework.LogicEntity_Athlete , GameMain.AthleteSystem.Athlete.SaveData>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject.BaseDataComponent<GameMain.AthleteSystem.Athlete , LogicFramework.LogicEntity_Athlete>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject.BaseComponent<GameMain.AthleteSystem.Athlete , LogicFramework.LogicEntity_Athlete>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject.BaseComponent<GameMain.AthleteSystem.Athlete>]=>[Utility.GameSystem.LogicFrameworkX.LogicObject.BaseComponent]=>[Utility.GeneralObject.GeneralObject.BaseComponent]=>[System.Object]
    /// [GameMain.Career.IImplementAthleteToData]=>[GameMain.Career.IOperationAthlete]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_DataComponent>, Ptr_DataComponent>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp", "", "DataComponent", "GameMain.AthleteSystem.Athlete.DataComponent")]
    public partial class AthleteDataComponent
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_DataComponent(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_DataComponent(System.IntPtr ptr) => new Ptr_DataComponent(ptr);
            public static implicit operator System.IntPtr(Ptr_DataComponent ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_DataComponent ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp".""."DataComponent"]
        /// </summary>
        partial struct Ptr_DataComponent
        {
            /// <summary>
            /// 0x10 System.String <Name>k__BackingField
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Name>k__BackingField", "System.String")]
           public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x18 Utility.GeneralObject.GeneralObject <Obj>k__BackingField
            /// abstract class ["Utility"."Utility.GeneralObject"."GeneralObject"]
            /// </summary>
            /// <returns>abstract class Utility.GeneralObject.GeneralObject</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Obj>k__BackingField", "Utility.GeneralObject.GeneralObject")]
           public partial nint OBJ { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Boolean <IsActive>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IsActive>k__BackingField", "System.Boolean")]
           public partial System.Boolean IS_ACTIVE { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 <Utility.PoolSystem.IPoolItem.SpawnId>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Utility.PoolSystem.IPoolItem.SpawnId>k__BackingField", "System.Int32")]
           public partial System.Int32 UTILITY_POOL_SYSTEM_I_POOL_ITEM_SPAWN_ID { get; set; } 
*/

            /// <summary>
            /// 0x28 GameMain.AthleteSystem.AthletePersonalData personal
            /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthletePersonalData"]
            /// </summary>
            /// <returns>struct GameMain.AthleteSystem.AthletePersonalData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("personal", "GameMain.AthleteSystem.AthletePersonalData")]
            public partial ref GameMain.AthleteSystem.AthletePersonalData.Ref_AthletePersonalData PERSONAL { get; }


            /// <summary>
            /// 0x48 System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroClassTypes , GameMain.AthleteSystem.HeroClassAdaption> heroAdaption
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroClassTypes , GameMain.AthleteSystem.HeroClassAdaption></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroAdaption", "System.Collections.Generic.Dictionary<GameMain.UnitSystem.HeroClassTypes,GameMain.AthleteSystem.HeroClassAdaption>")]
           public partial nint HERO_ADAPTION { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Collections.Generic.Dictionary<GameMain.UnitSystem.UnitSetting , GameMain.AthleteSystem.AthleteHeroData> heroDataDict
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.UnitSystem.UnitSetting , GameMain.AthleteSystem.AthleteHeroData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroDataDict", "System.Collections.Generic.Dictionary<GameMain.UnitSystem.UnitSetting,GameMain.AthleteSystem.AthleteHeroData>")]
           public partial nint HERO_DATA_DICT { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Collections.Generic.List<GameMain.AthleteSystem.TraitBattleCardsSetting> comprehendOptions
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.TraitBattleCardsSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("comprehendOptions", "System.Collections.Generic.List<GameMain.AthleteSystem.TraitBattleCardsSetting>")]
           public partial nint COMPREHEND_OPTIONS { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Collections.Generic.List<GameMain.AthleteSystem.AthleteBreakthroughTaskSetting> breakThroughOptions
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.AthleteBreakthroughTaskSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("breakThroughOptions", "System.Collections.Generic.List<GameMain.AthleteSystem.AthleteBreakthroughTaskSetting>")]
           public partial nint BREAK_THROUGH_OPTIONS { get; set; } 
*/

            /// <summary>
            /// 0x68 GameMain.ClubSystem.AthleteBreakthroughData breakThroughData
            /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."AthleteBreakthroughData"]
            /// </summary>
            /// <returns>struct GameMain.ClubSystem.AthleteBreakthroughData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("breakThroughData", "GameMain.ClubSystem.AthleteBreakthroughData")]
           public partial GameMain.ClubSystem.AthleteBreakthroughData BREAK_THROUGH_DATA { get; set; } 
*/

            /// <summary>
            /// 0x90 GameMain.Career.CareerAthlete career
            /// class ["Assembly-CSharp"."GameMain.Career"."CareerAthlete"]
            /// </summary>
            /// <returns>class GameMain.Career.CareerAthlete</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("career", "GameMain.Career.CareerAthlete")]
           public partial nint CAREER { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Collections.Generic.List<GameMain.AthleteSystem.AthleteTitleData> athleteTitleDatas
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.AthleteTitleData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteTitleDatas", "System.Collections.Generic.List<GameMain.AthleteSystem.AthleteTitleData>")]
           public partial nint ATHLETE_TITLE_DATAS { get; set; } 
*/

            /// <summary>
            /// 0xA0 GameMain.AthleteSystem.AthleteTitleData athleteCurTitle
            /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteTitleData"]
            /// </summary>
            /// <returns>struct GameMain.AthleteSystem.AthleteTitleData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteCurTitle", "GameMain.AthleteSystem.AthleteTitleData")]
           public partial GameMain.AthleteSystem.AthleteTitleData ATHLETE_CUR_TITLE { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Collections.Generic.List<GameMain.AthleteSystem.HeroMasteryTree> heroMasteryTrees
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.HeroMasteryTree></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroMasteryTrees", "System.Collections.Generic.List<GameMain.AthleteSystem.HeroMasteryTree>")]
           public partial nint HERO_MASTERY_TREES { get; set; } 
*/

            /// <summary>
            /// 0xD0 GameMain.ClubSystem.RecordScrimmageIncreaseAthlete scrimmageIncrease
            /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."RecordScrimmageIncreaseAthlete"]
            /// </summary>
            /// <returns>struct GameMain.ClubSystem.RecordScrimmageIncreaseAthlete</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("scrimmageIncrease", "GameMain.ClubSystem.RecordScrimmageIncreaseAthlete")]
           public partial GameMain.ClubSystem.RecordScrimmageIncreaseAthlete SCRIMMAGE_INCREASE { get; set; } 
*/

            /// <summary>
            /// 0xF0 GameMain.AthleteSystem.AthleteContract <Contract>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteContract"]
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteContract</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Contract>k__BackingField", "GameMain.AthleteSystem.AthleteContract")]
            public partial ref AthleteSystem.AthleteContract.Ptr_AthleteContract CONTRACT { get; }


            /// <summary>
            /// 0xF8 System.Collections.Generic.List<GameMain.AthleteSystem.AthleteContractPrefer> <ContractPrefers>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.AthleteContractPrefer></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ContractPrefers>k__BackingField", "System.Collections.Generic.List<GameMain.AthleteSystem.AthleteContractPrefer>")]
           public partial nint CONTRACT_PREFERS { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Collections.Generic.List<GameMain.AthleteSystem.AthletePersonality> <Personalities>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.AthletePersonality></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Personalities>k__BackingField", "System.Collections.Generic.List<GameMain.AthleteSystem.AthletePersonality>")]
           public partial nint PERSONALITIES { get; set; } 
*/

            /// <summary>
            /// 0x108 GameMain.AthleteSystem.AthleteEmotion <CurrentEmotion>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteEmotion"]
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteEmotion</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CurrentEmotion>k__BackingField", "GameMain.AthleteSystem.AthleteEmotion")]
            public partial ref AthleteSystem.AthleteEmotion.Ptr_AthleteEmotion CURRENT_EMOTION { get; }


            /// <summary>
            /// 0x110 System.Collections.Generic.List<GameMain.AthleteSystem.CareerLifeChangeData> <CareerLifeChangeDatas>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.CareerLifeChangeData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CareerLifeChangeDatas>k__BackingField", "System.Collections.Generic.List<GameMain.AthleteSystem.CareerLifeChangeData>")]
           public partial nint CAREER_LIFE_CHANGE_DATAS { get; set; } 
*/

            /// <summary>
            /// 0x118 System.Collections.Generic.List<GameMain.AthleteSystem.AthleteCharacteristicSetting> characteristicSettings
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.AthleteCharacteristicSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("characteristicSettings", "System.Collections.Generic.List<GameMain.AthleteSystem.AthleteCharacteristicSetting>")]
           public partial nint CHARACTERISTIC_SETTINGS { get; set; } 
*/

            /// <summary>
            /// 0x120 System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubMedalSetting , System.Int32> athleteMedals
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubMedalSetting , System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteMedals", "System.Collections.Generic.Dictionary<GameMain.ClubSystem.ClubMedalSetting,System.Int32>")]
           public partial nint ATHLETE_MEDALS { get; set; } 
*/

            /// <summary>
            /// 0x128 GameMain.UnitSystem.UnitSetting heroSetting
            /// class ["Assembly-CSharp"."GameMain.UnitSystem"."UnitSetting"]
            /// </summary>
            /// <returns>class GameMain.UnitSystem.UnitSetting</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroSetting", "GameMain.UnitSystem.UnitSetting")]
           public partial nint HERO_SETTING { get; set; } 
*/

            /// <summary>
            /// 0x130 GameMain.UnitSystem.Equipment.HeroEquipmentsDefaultSetting <HeroEquipmentsDefault>k__BackingField
            /// class ["Assembly-CSharp"."GameMain.UnitSystem.Equipment"."HeroEquipmentsDefaultSetting"]
            /// </summary>
            /// <returns>class GameMain.UnitSystem.Equipment.HeroEquipmentsDefaultSetting</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<HeroEquipmentsDefault>k__BackingField", "GameMain.UnitSystem.Equipment.HeroEquipmentsDefaultSetting")]
           public partial nint HERO_EQUIPMENTS_DEFAULT { get; set; } 
*/

            /// <summary>
            /// 0x138 System.Collections.Generic.List<GameMain.UnitSystem.Equipment.HeroEquipmentSetting> <HeroEquipments>k__BackingField
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.UnitSystem.Equipment.HeroEquipmentSetting></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<HeroEquipments>k__BackingField", "System.Collections.Generic.List<GameMain.UnitSystem.Equipment.HeroEquipmentSetting>")]
           public partial nint HERO_EQUIPMENTS { get; set; } 
*/

            /// <summary>
            /// 0x140 GameMain.AthleteSystem.AthleteAbilitiesData abilities
            /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."AthleteAbilitiesData"]
            /// </summary>
            /// <returns>struct GameMain.AthleteSystem.AthleteAbilitiesData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("abilities", "GameMain.AthleteSystem.AthleteAbilitiesData")]
            public partial ref GameMain.AthleteSystem.AthleteAbilitiesData.Ref_AthleteAbilitiesData ABILITIES { get; }


            /// <summary>
            /// 0x1A8 GameMain.ClubSystem.AthleteComprehensionData comprehension
            /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."AthleteComprehensionData"]
            /// </summary>
            /// <returns>struct GameMain.ClubSystem.AthleteComprehensionData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("comprehension", "GameMain.ClubSystem.AthleteComprehensionData")]
            public partial ref GameMain.ClubSystem.AthleteComprehensionData.Ref_AthleteComprehensionData COMPREHENSION { get; }


            /// <summary>
            /// 0x1B4 GameMain.ClubSystem.AdvancedTrainingAthleteData athleteTrainingData
            /// struct ["Assembly-CSharp"."GameMain.ClubSystem"."AdvancedTrainingAthleteData"]
            /// </summary>
            /// <returns>struct GameMain.ClubSystem.AdvancedTrainingAthleteData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("athleteTrainingData", "GameMain.ClubSystem.AdvancedTrainingAthleteData")]
            public partial ref GameMain.ClubSystem.AdvancedTrainingAthleteData.Ref_AdvancedTrainingAthleteData ATHLETE_TRAINING_DATA { get; }


            /// <summary>
            /// 0x1B8 System.Int32 heroPoolCount
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroPoolCount", "System.Int32")]
           public partial System.Int32 HERO_POOL_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x1BC System.Int32 abilityLimit
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("abilityLimit", "System.Int32")]
            public partial System.Int32 ABILITY_LIMIT { get; set; }


            /// <summary>
            /// 0x1C0 GameMain.BattleSystem.BattleCardEffectTypes comprehendCardType
            /// enum ["Assembly-CSharp"."GameMain.BattleSystem"."BattleCardEffectTypes"]
            /// </summary>
            /// <returns>enum GameMain.BattleSystem.BattleCardEffectTypes</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("comprehendCardType", "GameMain.BattleSystem.BattleCardEffectTypes")]
           public partial GameMain.BattleSystem.BattleCardEffectTypes COMPREHEND_CARD_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x1C4 System.Boolean <NeedRenewContract>k__BackingField
            /// struct ["mscorlib"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<NeedRenewContract>k__BackingField", "System.Boolean")]
           public partial System.Boolean NEED_RENEW_CONTRACT { get; set; } 
*/

            /// <summary>
            /// 0x1C8 System.Int32 <YouthWeeks>k__BackingField
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<YouthWeeks>k__BackingField", "System.Int32")]
           public partial System.Int32 YOUTH_WEEKS { get; set; } 
*/

            /// <summary>
            /// 0x1D0 GameMain.AthleteSystem.BattleData battleData
            /// struct ["Assembly-CSharp"."GameMain.AthleteSystem"."BattleData"]
            /// </summary>
            /// <returns>struct GameMain.AthleteSystem.BattleData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("battleData", "GameMain.AthleteSystem.BattleData")]
            public partial ref GameMain.AthleteSystem.BattleData.Ref_BattleData BATTLE_DATA { get; }

        }

        /// <summary>
        /// class ["Assembly-CSharp".""."DataComponent"]
        /// </summary>
        partial struct Ptr_DataComponent
        {
            /// <summary>
            /// static  System.Void <SetAbilityLevelAndExp>g__Set|152_0(GameMain.AthleteSystem.AthleteAbilityData& data, System.Int32 max, GameMain.AthleteSystem.Athlete.DataComponent.<>c__DisplayClass152_0& )
            /// </summary>
            /// <param name = "data">struct GameMain.AthleteSystem.AthleteAbilityData&</param>
            /// <param name = "max">struct System.Int32</param>
            /// <param name = "">struct GameMain.AthleteSystem.Athlete.DataComponent.<>c__DisplayClass152_0&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<SetAbilityLevelAndExp>g__Set|152_0", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityData&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete.DataComponent.<>c__DisplayClass152_0&", 2)]
            public static partial void SET_ABILITY_LEVEL_AND_EXPG__SET|152_0(GameMain.AthleteSystem.AthleteAbilityData &data, System.Int32 max, GameMain.AthleteSystem.Athlete.DataComponent. < > c__DisplayClass152_0 &); 
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
            ///   System.Boolean <AddAbilityExpWithAutoBreakThrough>b__143_0(GameMain.AthleteSystem.AthleteTraitSetting s)
            /// </summary>
            /// <param name = "s">class GameMain.AthleteSystem.AthleteTraitSetting</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<AddAbilityExpWithAutoBreakThrough>b__143_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteTraitSetting", 0)]
            public partial System.Boolean ADD_ABILITY_EXP_WITH_AUTO_BREAK_THROUGHB__143_0(nint s); 
*/
            /// <summary>
            ///   System.Boolean <AddAbilityExpWithAutoBreakThrough>b__143_1(GameMain.AthleteSystem.AthleteTraitSetting s)
            /// </summary>
            /// <param name = "s">class GameMain.AthleteSystem.AthleteTraitSetting</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<AddAbilityExpWithAutoBreakThrough>b__143_1", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteTraitSetting", 0)]
            public partial System.Boolean ADD_ABILITY_EXP_WITH_AUTO_BREAK_THROUGHB__143_1(nint s); 
*/
            /// <summary>
            ///   System.Boolean <AddAbilityExpWithAutoBreakThrough>b__143_2(GameMain.AthleteSystem.AthleteTraitSetting s)
            /// </summary>
            /// <param name = "s">class GameMain.AthleteSystem.AthleteTraitSetting</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<AddAbilityExpWithAutoBreakThrough>b__143_2", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteTraitSetting", 0)]
            public partial System.Boolean ADD_ABILITY_EXP_WITH_AUTO_BREAK_THROUGHB__143_2(nint s); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.AthleteSystem.AthleteAbilityFlags , UnityEngine.Vector3Int>> <GetAbilityLevelCalculate>g__GetResults|145_0(System.Collections.Generic.IDictionary<GameMain.AthleteSystem.AthleteAbilityFlags , System.ValueTuple<System.Int32 , System.Int32 , System.Int32 , System.Int32>> dict)
            /// </summary>
            /// <param name = "dict">interface System.Collections.Generic.IDictionary<GameMain.AthleteSystem.AthleteAbilityFlags , System.ValueTuple<System.Int32 , System.Int32 , System.Int32 , System.Int32>></param>
            /// <returns>interface System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.AthleteSystem.AthleteAbilityFlags , UnityEngine.Vector3Int>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<GetAbilityLevelCalculate>g__GetResults|145_0", "System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.AthleteSystem.AthleteAbilityFlags,UnityEngine.Vector3Int>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IDictionary<GameMain.AthleteSystem.AthleteAbilityFlags,System.ValueTuple<System.Int32,System.Int32,System.Int32,System.Int32>>", 0)]
            public partial nint GET_ABILITY_LEVEL_CALCULATEG__GET_RESULTS|145_0(nint dict); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<System.Int32> <GetMaxOrMinHeroMastery>g__GetHeroMastey|116_0()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<GetMaxOrMinHeroMastery>g__GetHeroMastey|116_0", "System.Collections.Generic.IEnumerable<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAX_OR_MIN_HERO_MASTERYG__GET_HERO_MASTEY|116_0(); 
*/
            /// <summary>
            ///   System.Boolean <GetMvpScoreAverage>b__62_1(GameMain.MatchSystem.Match m)
            /// </summary>
            /// <param name = "m">class GameMain.MatchSystem.Match</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<GetMvpScoreAverage>b__62_1", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.MatchSystem.Match", 0)]
            public partial System.Boolean GET_MVP_SCORE_AVERAGEB__62_1(nint m); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.RecordBattleAthlete <GetMvpScoreAverage>b__62_3(GameMain.BattleSystem.RecordBattle r)
            /// </summary>
            /// <param name = "r">struct GameMain.BattleSystem.RecordBattle</param>
            /// <returns>struct GameMain.AthleteSystem.RecordBattleAthlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<GetMvpScoreAverage>b__62_3", "GameMain.AthleteSystem.RecordBattleAthlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.BattleSystem.RecordBattle", 0)]
            public partial GameMain.AthleteSystem.RecordBattleAthlete GET_MVP_SCORE_AVERAGEB__62_3(GameMain.BattleSystem.RecordBattle r); 
*/
            /// <summary>
            ///   System.Boolean <GetMvpScoreAverage>b__62_6(System.ValueTuple<GameMain.ClubSystem.Club , GameMain.ClubSystem.ClubCompetitionData> t)
            /// </summary>
            /// <param name = "t">struct System.ValueTuple<GameMain.ClubSystem.Club , GameMain.ClubSystem.ClubCompetitionData></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<GetMvpScoreAverage>b__62_6", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ValueTuple<GameMain.ClubSystem.Club,GameMain.ClubSystem.ClubCompetitionData>", 0)]
            public partial System.Boolean GET_MVP_SCORE_AVERAGEB__62_6(System.ValueTuple<GameMain.ClubSystem.Club, GameMain.ClubSystem.ClubCompetitionData> t); 
*/
            /// <summary>
            ///   System.Void AbilityPostprocess(System.Int32& newExp, System.Int32& newLevel, System.Int32& abilityMax)
            /// </summary>
            /// <param name = "newExp">struct System.Int32&</param>
            /// <param name = "newLevel">struct System.Int32&</param>
            /// <param name = "abilityMax">struct System.Int32&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AbilityPostprocess", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 2)]
            public partial void ABILITY_POSTPROCESS(System.Int32 &newExp, System.Int32 &newLevel, System.Int32 &abilityMax); 
*/
            /// <summary>
            ///   System.Void AbilityPreprocess(GameMain.AthleteSystem.AthleteAbilityExpData data, System.Boolean& limited, System.Int32& oldLevel, System.Int32& newLevel, System.Int32& oldExp, System.Int32& newExp)
            /// </summary>
            /// <param name = "data">class GameMain.AthleteSystem.AthleteAbilityExpData</param>
            /// <param name = "limited">struct System.Boolean&</param>
            /// <param name = "oldLevel">struct System.Int32&</param>
            /// <param name = "newLevel">struct System.Int32&</param>
            /// <param name = "oldExp">struct System.Int32&</param>
            /// <param name = "newExp">struct System.Int32&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AbilityPreprocess", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityExpData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 5)]
            public partial void ABILITY_PREPROCESS(nint data, System.Boolean &limited, System.Int32 &oldLevel, System.Int32 &newLevel, System.Int32 &oldExp, System.Int32 &newExp); 
*/
            /// <summary>
            ///   System.Void AddAbilityExp(GameMain.AthleteSystem.AthleteAbilityExpData data)
            /// </summary>
            /// <param name = "data">class GameMain.AthleteSystem.AthleteAbilityExpData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAbilityExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityExpData", 0)]
            public partial void ADD_ABILITY_EXP(nint data); 
*/
            /// <summary>
            ///   System.Void AddAbilityExpWithAutoBreakThrough(GameMain.AthleteSystem.AthleteAbilityExpData data)
            /// </summary>
            /// <param name = "data">class GameMain.AthleteSystem.AthleteAbilityExpData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAbilityExpWithAutoBreakThrough", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityExpData", 0)]
            public partial void ADD_ABILITY_EXP_WITH_AUTO_BREAK_THROUGH(nint data); 
*/
            /// <summary>
            ///   System.Void AddAbilityLevel(GameMain.AthleteSystem.AthleteAbilityExpData data)
            /// </summary>
            /// <param name = "data">class GameMain.AthleteSystem.AthleteAbilityExpData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAbilityLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityExpData", 0)]
            public partial void ADD_ABILITY_LEVEL(nint data); 
*/
            /// <summary>
            ///   System.Void AddAbilityLimit(System.Int32 limit)
            /// </summary>
            /// <param name = "limit">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAbilityLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_ABILITY_LIMIT(System.Int32 limit); 
*/
            /// <summary>
            ///   System.Void AddAge(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAge", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void ADD_AGE(System.Single value); 
*/
            /// <summary>
            ///   System.Void AddAthleteFans(System.Int32 fans)
            /// </summary>
            /// <param name = "fans">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAthleteFans", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_ATHLETE_FANS(System.Int32 fans); 
*/
            /// <summary>
            ///   System.Void AddAthleteFans_Battle(System.Int32 fans)
            /// </summary>
            /// <param name = "fans">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAthleteFans_Battle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_ATHLETE_FANS_BATTLE(System.Int32 fans); 
*/
            /// <summary>
            ///   System.Void AddAthleteFans_Broadcast(System.Int32 fans)
            /// </summary>
            /// <param name = "fans">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAthleteFans_Broadcast", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_ATHLETE_FANS_BROADCAST(System.Int32 fans); 
*/
            /// <summary>
            ///   System.Void AddAthleteFans_Other(System.Int32 fans)
            /// </summary>
            /// <param name = "fans">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAthleteFans_Other", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_ATHLETE_FANS_OTHER(System.Int32 fans); 
*/
            /// <summary>
            ///   System.Void AddAthleteTitle(GameMain.AthleteSystem.AthleteTitleSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.AthleteSystem.AthleteTitleSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddAthleteTitle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteTitleSetting", 0)]
            public partial void ADD_ATHLETE_TITLE(nint setting); 
*/
            /// <summary>
            ///   System.Void AddBreakThroughCounter(System.Single count)
            /// </summary>
            /// <param name = "count">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddBreakThroughCounter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void ADD_BREAK_THROUGH_COUNTER(System.Single count); 
*/
            /// <summary>
            ///   System.Void AddComprehendCardTypes(GameMain.BattleSystem.BattleCardEffectTypes cardEffectType)
            /// </summary>
            /// <param name = "cardEffectType">enum GameMain.BattleSystem.BattleCardEffectTypes</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddComprehendCardTypes", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.BattleSystem.BattleCardEffectTypes", 0)]
            public partial void ADD_COMPREHEND_CARD_TYPES(GameMain.BattleSystem.BattleCardEffectTypes cardEffectType); 
*/
            /// <summary>
            ///   System.Void AddExpComprehension(System.Int32 exp)
            /// </summary>
            /// <param name = "exp">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddExpComprehension", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_EXP_COMPREHENSION(System.Int32 exp); 
*/
            /// <summary>
            ///   System.Void AddHeroMasteryExp(GameMain.UnitSystem.UnitSetting setting, System.Int32 exp, System.Int32 level)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "exp">struct System.Int32</param>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddHeroMasteryExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void ADD_HERO_MASTERY_EXP(nint setting, System.Int32 exp, System.Int32 level); 
*/
            /// <summary>
            ///   System.Void AddHeroMasteryExpHeroesAddedExp(GameMain.UnitSystem.UnitSetting mainSetting, System.Int32 exp, System.Int32 level)
            /// </summary>
            /// <param name = "mainSetting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "exp">struct System.Int32</param>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddHeroMasteryExpHeroesAddedExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void ADD_HERO_MASTERY_EXP_HEROES_ADDED_EXP(nint mainSetting, System.Int32 exp, System.Int32 level); 
*/
            /// <summary>
            ///   System.Void AddHeroMasteryTree(GameMain.UnitSystem.UnitSetting unitSetting)
            /// </summary>
            /// <param name = "unitSetting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddHeroMasteryTree", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial void ADD_HERO_MASTERY_TREE(nint unitSetting); 
*/
            /// <summary>
            ///   System.Void AddMedal(GameMain.ClubSystem.ClubMedalSetting setting, System.Int32 count)
            /// </summary>
            /// <param name = "setting">class GameMain.ClubSystem.ClubMedalSetting</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddMedal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.ClubMedalSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_MEDAL(nint setting, System.Int32 count); 
*/
            /// <summary>
            ///   System.Boolean AddNewHeroData(GameMain.UnitSystem.UnitSetting setting, GameMain.AthleteSystem.AthleteHeroData heroData, System.Boolean force)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "heroData">struct GameMain.AthleteSystem.AthleteHeroData</param>
            /// <param name = "force">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddNewHeroData", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteHeroData", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial System.Boolean ADD_NEW_HERO_DATA(nint setting, GameMain.AthleteSystem.AthleteHeroData heroData, System.Boolean force); 
*/
            /// <summary>
            ///   System.Void ApplyCharacteristic()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ApplyCharacteristic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void APPLY_CHARACTERISTIC(); 
*/
            /// <summary>
            ///   System.Void AutoBreak(System.Int32 count)
            /// </summary>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoBreak", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void AUTO_BREAK(System.Int32 count); 
*/
            /// <summary>
            ///   System.Void AutoFixMasteryTree()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoFixMasteryTree", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AUTO_FIX_MASTERY_TREE(); 
*/
            /// <summary>
            ///   System.Boolean CanBreakThrough()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanBreakThrough", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean CAN_BREAK_THROUGH(); 
*/
            /// <summary>
            ///   System.Void ChangeAthleteTitle(GameMain.AthleteSystem.AthleteTitleData data)
            /// </summary>
            /// <param name = "data">struct GameMain.AthleteSystem.AthleteTitleData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeAthleteTitle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteTitleData", 0)]
            public partial void CHANGE_ATHLETE_TITLE(GameMain.AthleteSystem.AthleteTitleData data); 
*/
            /// <summary>
            ///   System.Void ChangeAthleteTitle(GameMain.AthleteSystem.AthleteTitleSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.AthleteSystem.AthleteTitleSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeAthleteTitle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteTitleSetting", 0)]
            public partial void CHANGE_ATHLETE_TITLE(nint setting); 
*/
            /// <summary>
            ///   System.Void ChangeCareerLife(System.Int32 value, GameMain.AthleteSystem.CareerLifeChangeReason reason)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "reason">enum GameMain.AthleteSystem.CareerLifeChangeReason</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeCareerLife", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.CareerLifeChangeReason", 1)]
            public partial void CHANGE_CAREER_LIFE(System.Int32 value, GameMain.AthleteSystem.CareerLifeChangeReason reason); 
*/
            /// <summary>
            ///   System.Void ClearHeroData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearHeroData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR_HERO_DATA(); 
*/
            /// <summary>
            ///   System.Void CloneCareer(GameMain.AthleteSystem.Athlete source)
            /// </summary>
            /// <param name = "source">class GameMain.AthleteSystem.Athlete</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CloneCareer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.Athlete", 0)]
            public partial void CLONE_CAREER(nint source); 
*/
            /// <summary>
            ///   System.Void CostCareerLifeMonth()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostCareerLifeMonth", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void COST_CAREER_LIFE_MONTH(); 
*/
            /// <summary>
            ///   System.Void CostCareerLifeNatural()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostCareerLifeNatural", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void COST_CAREER_LIFE_NATURAL(); 
*/
            /// <summary>
            ///   System.Void EnableTreeItem(GameMain.UnitSystem.UnitSetting unitSetting, GameMain.UnitSystem.HeroMasteryUnitItemSetting itemSetting, System.Int32 level)
            /// </summary>
            /// <param name = "unitSetting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "itemSetting">class GameMain.UnitSystem.HeroMasteryUnitItemSetting</param>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EnableTreeItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroMasteryUnitItemSetting", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void ENABLE_TREE_ITEM(nint unitSetting, nint itemSetting, System.Int32 level); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.AthleteSystem.CareerLifeChangeData> get_CareerLifeChangeDatas()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.CareerLifeChangeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CareerLifeChangeDatas", "System.Collections.Generic.List<GameMain.AthleteSystem.CareerLifeChangeData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CAREER_LIFE_CHANGE_DATAS(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteContract get_Contract()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteContract</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Contract", "GameMain.AthleteSystem.AthleteContract", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CONTRACT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.AthleteSystem.AthleteContractPrefer> get_ContractPrefers()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.AthleteContractPrefer></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ContractPrefers", "System.Collections.Generic.List<GameMain.AthleteSystem.AthleteContractPrefer>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CONTRACT_PREFERS(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteEmotion get_CurrentEmotion()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteEmotion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CurrentEmotion", "GameMain.AthleteSystem.AthleteEmotion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CURRENT_EMOTION(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.UnitSystem.Equipment.HeroEquipmentSetting> get_HeroEquipments()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.UnitSystem.Equipment.HeroEquipmentSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_HeroEquipments", "System.Collections.Generic.List<GameMain.UnitSystem.Equipment.HeroEquipmentSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_EQUIPMENTS(); 
*/
            /// <summary>
            ///   GameMain.UnitSystem.Equipment.HeroEquipmentsDefaultSetting get_HeroEquipmentsDefault()
            /// </summary>
            /// <returns>class GameMain.UnitSystem.Equipment.HeroEquipmentsDefaultSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_HeroEquipmentsDefault", "GameMain.UnitSystem.Equipment.HeroEquipmentsDefaultSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_EQUIPMENTS_DEFAULT(); 
*/
            /// <summary>
            ///   System.Boolean get_NeedRenewContract()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_NeedRenewContract", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_NEED_RENEW_CONTRACT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.Career.IOperationAthlete> get_Operations()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.Career.IOperationAthlete></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Operations", "System.Collections.Generic.IEnumerable<GameMain.Career.IOperationAthlete>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_OPERATIONS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.AthleteSystem.AthletePersonality> get_Personalities()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<GameMain.AthleteSystem.AthletePersonality></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Personalities", "System.Collections.Generic.List<GameMain.AthleteSystem.AthletePersonality>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PERSONALITIES(); 
*/
            /// <summary>
            ///   System.String get_Portrait()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Portrait", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PORTRAIT(); 
*/
            /// <summary>
            ///   System.Int32 get_YouthWeeks()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_YouthWeeks", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_YOUTH_WEEKS(); 
*/
            /// <summary>
            ///   UnityEngine.Vector3Int GetAbilityCalculateResult(System.Int32& oldExp, System.Int32& newExp, System.Int32& oldLevel, System.Int32& newLevel)
            /// </summary>
            /// <param name = "oldExp">struct System.Int32&</param>
            /// <param name = "newExp">struct System.Int32&</param>
            /// <param name = "oldLevel">struct System.Int32&</param>
            /// <param name = "newLevel">struct System.Int32&</param>
            /// <returns>struct UnityEngine.Vector3Int</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityCalculateResult", "UnityEngine.Vector3Int", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 3)]
            public partial UnityEngine.Vector3Int GET_ABILITY_CALCULATE_RESULT(System.Int32 &oldExp, System.Int32 &newExp, System.Int32 &oldLevel, System.Int32 &newLevel); 
*/
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
            ///   System.Int32 GetAbilityExpChange(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Int32 oldLevel, System.Int32 oldExp)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "oldLevel">struct System.Int32</param>
            /// <param name = "oldExp">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityExpChange", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Int32 GET_ABILITY_EXP_CHANGE(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Int32 oldLevel, System.Int32 oldExp); 
*/
            /// <summary>
            ///   System.Single GetAbilityExpGainBase()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityExpGainBase", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_ABILITY_EXP_GAIN_BASE(); 
*/
            /// <summary>
            ///   System.Single GetAbilityExpIncrease()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityExpIncrease", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_ABILITY_EXP_INCREASE(); 
*/
            /// <summary>
            ///   System.Single GetAbilityExpPercentage(GameMain.AthleteSystem.AthleteAbilityFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityExpPercentage", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            public partial System.Single GET_ABILITY_EXP_PERCENTAGE(GameMain.AthleteSystem.AthleteAbilityFlags flag); 
*/
            /// <summary>
            ///   System.Single GetAbilityExpPercentage(System.Int32 level, System.Int32 exp)
            /// </summary>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "exp">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityExpPercentage", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Single GET_ABILITY_EXP_PERCENTAGE(System.Int32 level, System.Int32 exp); 
*/
            /// <summary>
            ///   System.Int32 GetAbilityExpPotentialAdjust(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Int32 exp, System.Boolean needOffset)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "exp">struct System.Int32</param>
            /// <param name = "needOffset">struct System.Boolean</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityExpPotentialAdjust", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial System.Int32 GET_ABILITY_EXP_POTENTIAL_ADJUST(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Int32 exp, System.Boolean needOffset); 
*/
            /// <summary>
            ///   System.Int32 GetAbilityLevel(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Boolean withAdjust)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "withAdjust">struct System.Boolean</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Int32 GET_ABILITY_LEVEL(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Boolean withAdjust); 
*/
            /// <summary>
            ///   System.ValueTuple<System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.AthleteSystem.AthleteAbilityFlags , UnityEngine.Vector3Int>>,System.Boolean> GetAbilityLevelCalculate(System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityExpData> datas)
            /// </summary>
            /// <param name = "datas">interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityExpData></param>
            /// <returns>struct System.ValueTuple<System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.AthleteSystem.AthleteAbilityFlags , UnityEngine.Vector3Int>>,System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityLevelCalculate", "System.ValueTuple<System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.AthleteSystem.AthleteAbilityFlags,UnityEngine.Vector3Int>>,System.Boolean>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityExpData>", 0)]
            public partial System.ValueTuple<System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.AthleteSystem.AthleteAbilityFlags, UnityEngine.Vector3Int>>, System.Boolean> GET_ABILITY_LEVEL_CALCULATE(nint datas); 
*/
            /// <summary>
            ///   UnityEngine.Vector3Int GetAbilityLevelCalculate(GameMain.AthleteSystem.AthleteAbilityExpData data, System.Boolean& limited)
            /// </summary>
            /// <param name = "data">class GameMain.AthleteSystem.AthleteAbilityExpData</param>
            /// <param name = "limited">struct System.Boolean&</param>
            /// <returns>struct UnityEngine.Vector3Int</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityLevelCalculate", "UnityEngine.Vector3Int", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityExpData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean&", 1)]
            public partial UnityEngine.Vector3Int GET_ABILITY_LEVEL_CALCULATE(nint data, System.Boolean &limited); 
*/
            /// <summary>
            ///   UnityEngine.Vector3Int GetAbilityLevelCalculateUtilLimited(GameMain.AthleteSystem.AthleteAbilityExpData data, System.Boolean& limited)
            /// </summary>
            /// <param name = "data">class GameMain.AthleteSystem.AthleteAbilityExpData</param>
            /// <param name = "limited">struct System.Boolean&</param>
            /// <returns>struct UnityEngine.Vector3Int</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityLevelCalculateUtilLimited", "UnityEngine.Vector3Int", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityExpData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean&", 1)]
            public partial UnityEngine.Vector3Int GET_ABILITY_LEVEL_CALCULATE_UTIL_LIMITED(nint data, System.Boolean &limited); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.LevelData GetAbilityLevelData(GameMain.AthleteSystem.AthleteAbilityFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <returns>struct GameMain.AthleteSystem.LevelData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityLevelData", "GameMain.AthleteSystem.LevelData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            public partial GameMain.AthleteSystem.LevelData GET_ABILITY_LEVEL_DATA(GameMain.AthleteSystem.AthleteAbilityFlags flag); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.AthleteSystem.AthleteAbilityFlags , System.Int32>> GetAbilityLevelList()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.AthleteSystem.AthleteAbilityFlags , System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityLevelList", "System.Collections.Generic.IEnumerable<System.ValueTuple<GameMain.AthleteSystem.AthleteAbilityFlags,System.Int32>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ABILITY_LEVEL_LIST(); 
*/
            /// <summary>
            ///   System.Int32 GetAbilityLimit()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityLimit", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ABILITY_LIMIT(); 
*/
            /// <summary>
            ///   System.Int32 GetAbilityMax(GameMain.AthleteSystem.AthleteAbilityFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityMax", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            public partial System.Int32 GET_ABILITY_MAX(GameMain.AthleteSystem.AthleteAbilityFlags flag); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AbilityPotentialRank GetAbilityPotentialRank(GameMain.AthleteSystem.AthleteAbilityFlags flag)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <returns>enum GameMain.AthleteSystem.AbilityPotentialRank</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityPotentialRank", "GameMain.AthleteSystem.AbilityPotentialRank", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            public partial GameMain.AthleteSystem.AbilityPotentialRank GET_ABILITY_POTENTIAL_RANK(GameMain.AthleteSystem.AthleteAbilityFlags flag); 
*/
            /// <summary>
            ///   System.Int32 GetAbilityTotalMax()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAbilityTotalMax", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ABILITY_TOTAL_MAX(); 
*/
            /// <summary>
            ///   System.Single GetAge()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAge", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_AGE(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteBreakState GetAthleteBreakState()
            /// </summary>
            /// <returns>enum GameMain.AthleteSystem.AthleteBreakState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAthleteBreakState", "GameMain.AthleteSystem.AthleteBreakState", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.AthleteSystem.AthleteBreakState GET_ATHLETE_BREAK_STATE(); 
*/
            /// <summary>
            ///   System.Int32 GetAthletePrice()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAthletePrice", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_ATHLETE_PRICE(); 
*/
            /// <summary>
            ///   System.String GetAthleteTitle(GameMain.AthleteSystem.AthleteTitleSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.AthleteSystem.AthleteTitleSetting</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAthleteTitle", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteTitleSetting", 0)]
            public partial nint GET_ATHLETE_TITLE(nint setting); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteTitleSetting GetAthleteTitleSetting()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.AthleteTitleSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAthleteTitleSetting", "GameMain.AthleteSystem.AthleteTitleSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATHLETE_TITLE_SETTING(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityFlags> GetBestOrWeekestAbility(System.Boolean isBest)
            /// </summary>
            /// <param name = "isBest">struct System.Boolean</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityFlags></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBestOrWeekestAbility", "System.Collections.Generic.IEnumerable<GameMain.AthleteSystem.AthleteAbilityFlags>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_BEST_OR_WEEKEST_ABILITY(System.Boolean isBest); 
*/
            /// <summary>
            ///   System.Int32 GetCareerLife()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCareerLife", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_CAREER_LIFE(); 
*/
            /// <summary>
            ///   System.Int32 GetCareerLifeCostCalculate(System.Int32 seasonCount)
            /// </summary>
            /// <param name = "seasonCount">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCareerLifeCostCalculate", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_CAREER_LIFE_COST_CALCULATE(System.Int32 seasonCount); 
*/
            /// <summary>
            ///   System.Boolean GetCareerLifeIsEndThisSeason()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCareerLifeIsEndThisSeason", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_CAREER_LIFE_IS_END_THIS_SEASON(); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteCharmRank GetCharm()
            /// </summary>
            /// <returns>enum GameMain.AthleteSystem.AthleteCharmRank</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCharm", "GameMain.AthleteSystem.AthleteCharmRank", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.AthleteSystem.AthleteCharmRank GET_CHARM(); 
*/
            /// <summary>
            ///   GameMain.UnitSystem.HeroMasteryUnitItemSetting GetEnabledItem(GameMain.UnitSystem.UnitSetting unitSetting, System.Int32 level)
            /// </summary>
            /// <param name = "unitSetting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>class GameMain.UnitSystem.HeroMasteryUnitItemSetting</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnabledItem", "GameMain.UnitSystem.HeroMasteryUnitItemSetting", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_ENABLED_ITEM(nint unitSetting, System.Int32 level); 
*/
            /// <summary>
            ///   System.Int32 GetExpComprehension()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExpComprehension", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_EXP_COMPREHENSION(); 
*/
            /// <summary>
            ///   System.Double GetFans(GameMain.StatTimeRangeTypes time)
            /// </summary>
            /// <param name = "time">enum GameMain.StatTimeRangeTypes</param>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFans", "System.Double", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.StatTimeRangeTypes", 0)]
            public partial System.Double GET_FANS(GameMain.StatTimeRangeTypes time); 
*/
            /// <summary>
            ///   System.Single GetFansGainBase()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFansGainBase", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_FANS_GAIN_BASE(); 
*/
            /// <summary>
            ///   System.Int32 GetFinalAbilityExp(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Int32 exp)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "exp">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFinalAbilityExp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 GET_FINAL_ABILITY_EXP(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Int32 exp); 
*/
            /// <summary>
            ///   System.Int32 GetFinalHeroMasteryExp(System.Int32 exp)
            /// </summary>
            /// <param name = "exp">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFinalHeroMasteryExp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Int32 GET_FINAL_HERO_MASTERY_EXP(System.Int32 exp); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.HeroClassAdaption GetHeroAdaption(GameMain.UnitSystem.HeroClassTypes type)
            /// </summary>
            /// <param name = "type">enum GameMain.UnitSystem.HeroClassTypes</param>
            /// <returns>enum GameMain.AthleteSystem.HeroClassAdaption</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroAdaption", "GameMain.AthleteSystem.HeroClassAdaption", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroClassTypes", 0)]
            public partial GameMain.AthleteSystem.HeroClassAdaption GET_HERO_ADAPTION(GameMain.UnitSystem.HeroClassTypes type); 
*/
            /// <summary>
            ///   System.Boolean GetHeroData(GameMain.UnitSystem.UnitSetting setting, GameMain.AthleteSystem.AthleteHeroData& result)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "result">struct GameMain.AthleteSystem.AthleteHeroData&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroData", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteHeroData&", 1)]
            public partial System.Boolean GET_HERO_DATA(nint setting, GameMain.AthleteSystem.AthleteHeroData &result); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.AthleteHeroData GetHeroData()
            /// </summary>
            /// <returns>struct GameMain.AthleteSystem.AthleteHeroData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroData", "GameMain.AthleteSystem.AthleteHeroData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.AthleteSystem.AthleteHeroData GET_HERO_DATA(); 
*/
            /// <summary>
            ///   System.Int32 GetHeroDataCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroDataCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HERO_DATA_COUNT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IReadOnlyCollection<GameMain.UnitSystem.UnitSetting> GetHeroDataKeys()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IReadOnlyCollection<GameMain.UnitSystem.UnitSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroDataKeys", "System.Collections.Generic.IReadOnlyCollection<GameMain.UnitSystem.UnitSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_DATA_KEYS(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<GameMain.UnitSystem.Equipment.HeroEquipmentSetting> GetHeroDefaultEquipment(GameMain.UnitSystem.UnitSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>class System.Collections.Generic.List<GameMain.UnitSystem.Equipment.HeroEquipmentSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroDefaultEquipment", "System.Collections.Generic.List<GameMain.UnitSystem.Equipment.HeroEquipmentSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial nint GET_HERO_DEFAULT_EQUIPMENT(nint setting); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<GameMain.UnitSystem.UnitSetting> GetHeroKeysByMastery(System.Int32 level)
            /// </summary>
            /// <param name = "level">struct System.Int32</param>
            /// <returns>interface System.Collections.Generic.IEnumerable<GameMain.UnitSystem.UnitSetting></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroKeysByMastery", "System.Collections.Generic.IEnumerable<GameMain.UnitSystem.UnitSetting>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_HERO_KEYS_BY_MASTERY(System.Int32 level); 
*/
            /// <summary>
            ///   System.Int32 GetHeroMastery()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroMastery", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HERO_MASTERY(); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 GetHeroMasteryCalculate(GameMain.UnitSystem.UnitSetting setting, System.Int32 exp, System.Int32 level, System.Boolean& limit)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "exp">struct System.Int32</param>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "limit">struct System.Boolean&</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroMasteryCalculate", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean&", 3)]
            public partial UnityEngine.Vector3 GET_HERO_MASTERY_CALCULATE(nint setting, System.Int32 exp, System.Int32 level, System.Boolean &limit); 
*/
            /// <summary>
            ///   System.Int32 GetHeroMasteryExp(GameMain.UnitSystem.UnitSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroMasteryExp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial System.Int32 GET_HERO_MASTERY_EXP(nint setting); 
*/
            /// <summary>
            ///   System.Single GetHeroMasteryExpPercentage(GameMain.UnitSystem.UnitSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroMasteryExpPercentage", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial System.Single GET_HERO_MASTERY_EXP_PERCENTAGE(nint setting); 
*/
            /// <summary>
            ///   System.Single GetHeroMasteryExpPercentage(GameMain.UnitSystem.UnitSetting setting, System.Int32 level, System.Int32 exp)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "exp">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroMasteryExpPercentage", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Single GET_HERO_MASTERY_EXP_PERCENTAGE(nint setting, System.Int32 level, System.Int32 exp); 
*/
            /// <summary>
            ///   System.Int32 GetHeroMasteryLevel(GameMain.UnitSystem.UnitSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroMasteryLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial System.Int32 GET_HERO_MASTERY_LEVEL(nint setting); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.LevelData GetHeroMasteryLevelData(GameMain.UnitSystem.UnitSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct GameMain.AthleteSystem.LevelData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroMasteryLevelData", "GameMain.AthleteSystem.LevelData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial GameMain.AthleteSystem.LevelData GET_HERO_MASTERY_LEVEL_DATA(nint setting); 
*/
            /// <summary>
            ///   System.Int32 GetHeroMasteryTotalExp(GameMain.UnitSystem.UnitSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroMasteryTotalExp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial System.Int32 GET_HERO_MASTERY_TOTAL_EXP(nint setting); 
*/
            /// <summary>
            ///   GameMain.AthleteSystem.HeroMasteryTree GetHeroMasteryTree(GameMain.UnitSystem.UnitSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct GameMain.AthleteSystem.HeroMasteryTree</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroMasteryTree", "GameMain.AthleteSystem.HeroMasteryTree", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial GameMain.AthleteSystem.HeroMasteryTree GET_HERO_MASTERY_TREE(nint setting); 
*/
            /// <summary>
            ///   System.Int32 GetHeroNum()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HERO_NUM(); 
*/
            /// <summary>
            ///   System.Int32 GetHeroPickedCount(GameMain.UnitSystem.UnitSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroPickedCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial System.Int32 GET_HERO_PICKED_COUNT(nint setting); 
*/
            /// <summary>
            ///   System.Int32 GetHeroPoolMax()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroPoolMax", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HERO_POOL_MAX(); 
*/
            /// <summary>
            ///   GameMain.UnitSystem.HeroRoleFlags GetLastRole()
            /// </summary>
            /// <returns>enum GameMain.UnitSystem.HeroRoleFlags</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLastRole", "GameMain.UnitSystem.HeroRoleFlags", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial GameMain.UnitSystem.HeroRoleFlags GET_LAST_ROLE(); 
*/
            /// <summary>
            ///   System.Int32 GetLevelComprehension()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLevelComprehension", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_LEVEL_COMPREHENSION(); 
*/
            /// <summary>
            ///   System.Int32 GetMasteryExp(GameMain.UnitSystem.UnitSetting setting, System.Int32 level, System.Boolean& contains)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "contains">struct System.Boolean&</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMasteryExp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean&", 2)]
            public partial System.Int32 GET_MASTERY_EXP(nint setting, System.Int32 level, System.Boolean &contains); 
*/
            /// <summary>
            ///   System.Int32 GetMasteryExp(GameMain.UnitSystem.HeroClassTypes classType, System.Int32 level, System.Boolean& contains)
            /// </summary>
            /// <param name = "classType">enum GameMain.UnitSystem.HeroClassTypes</param>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "contains">struct System.Boolean&</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMasteryExp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroClassTypes", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean&", 2)]
            public partial System.Int32 GET_MASTERY_EXP(GameMain.UnitSystem.HeroClassTypes classType, System.Int32 level, System.Boolean &contains); 
*/
            /// <summary>
            ///   System.Int32 GetMaxOrMinHeroMastery(System.Boolean isMax)
            /// </summary>
            /// <param name = "isMax">struct System.Boolean</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxOrMinHeroMastery", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial System.Int32 GET_MAX_OR_MIN_HERO_MASTERY(System.Boolean isMax); 
*/
            /// <summary>
            ///   System.Single GetMvpScoreAverage()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMvpScoreAverage", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_MVP_SCORE_AVERAGE(); 
*/
            /// <summary>
            ///   System.Int32 GetNeedExpComprehension()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNeedExpComprehension", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_NEED_EXP_COMPREHENSION(); 
*/
            /// <summary>
            ///   System.Int32 GetNextAbilityLimit()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNextAbilityLimit", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_NEXT_ABILITY_LIMIT(); 
*/
            /// <summary>
            ///   System.Single GetPerComprehension()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPerComprehension", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_PER_COMPREHENSION(); 
*/
            /// <summary>
            ///   System.Int32 GetSkillTraitMaxCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillTraitMaxCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_SKILL_TRAIT_MAX_COUNT(); 
*/
            /// <summary>
            ///   System.Int32 GetTransferPlayerPrice(GameMain.ClubSystem.Club signClub)
            /// </summary>
            /// <param name = "signClub">class GameMain.ClubSystem.Club</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTransferPlayerPrice", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.ClubSystem.Club", 0)]
            public partial System.Int32 GET_TRANSFER_PLAYER_PRICE(nint signClub); 
*/
            /// <summary>
            ///   System.Void InitAthleteTitles(System.Boolean clear, System.Boolean newSetting)
            /// </summary>
            /// <param name = "clear">struct System.Boolean</param>
            /// <param name = "newSetting">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitAthleteTitles", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void INIT_ATHLETE_TITLES(System.Boolean clear, System.Boolean newSetting); 
*/
            /// <summary>
            ///   System.Void InitCareerLife()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitCareerLife", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_CAREER_LIFE(); 
*/
            /// <summary>
            ///   System.Void InitCharm()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitCharm", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_CHARM(); 
*/
            /// <summary>
            ///   System.Void InitHeroAdaption()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitHeroAdaption", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_HERO_ADAPTION(); 
*/
            /// <summary>
            ///   System.Void InitPotentialRank()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitPotentialRank", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_POTENTIAL_RANK(); 
*/
            /// <summary>
            ///   System.Boolean IsAbilityLimit()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsAbilityLimit", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_ABILITY_LIMIT(); 
*/
            /// <summary>
            ///   System.Boolean IsAbilityTotalMax()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsAbilityTotalMax", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_ABILITY_TOTAL_MAX(); 
*/
            /// <summary>
            ///   System.Boolean IsTreeAbnormal(GameMain.UnitSystem.UnitSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsTreeAbnormal", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial System.Boolean IS_TREE_ABNORMAL(nint setting); 
*/
            /// <summary>
            ///   System.Void OnAddHeroMasteryLevel(GameMain.UnitSystem.UnitSetting setting, System.Int32 oldLevel, System.Int32 newLevel, System.Boolean loadGame)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "oldLevel">struct System.Int32</param>
            /// <param name = "newLevel">struct System.Int32</param>
            /// <param name = "loadGame">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAddHeroMasteryLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void ON_ADD_HERO_MASTERY_LEVEL(nint setting, System.Int32 oldLevel, System.Int32 newLevel, System.Boolean loadGame); 
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
            ///   System.Void ProcessExp(System.Int32& exp, System.Int32& oldExp, System.Int32& newExp, System.Int32& oldLevel, System.Int32& newLevel, System.Boolean& limited, System.Int32& abilityMax, System.Boolean limitedStop)
            /// </summary>
            /// <param name = "exp">struct System.Int32&</param>
            /// <param name = "oldExp">struct System.Int32&</param>
            /// <param name = "newExp">struct System.Int32&</param>
            /// <param name = "oldLevel">struct System.Int32&</param>
            /// <param name = "newLevel">struct System.Int32&</param>
            /// <param name = "limited">struct System.Boolean&</param>
            /// <param name = "abilityMax">struct System.Int32&</param>
            /// <param name = "limitedStop">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ProcessExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean&", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 7)]
            public partial void PROCESS_EXP(System.Int32 &exp, System.Int32 &oldExp, System.Int32 &newExp, System.Int32 &oldLevel, System.Int32 &newLevel, System.Boolean &limited, System.Int32 &abilityMax, System.Boolean limitedStop); 
*/
            /// <summary>
            ///   System.Void RemoveAthleteTitle(GameMain.AthleteSystem.AthleteTitleSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.AthleteSystem.AthleteTitleSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveAthleteTitle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteTitleSetting", 0)]
            public partial void REMOVE_ATHLETE_TITLE(nint setting); 
*/
            /// <summary>
            ///   System.Void RemoveHeroData(GameMain.UnitSystem.UnitSetting setting, GameMain.AthleteSystem.AthleteHeroData& data)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "data">struct GameMain.AthleteSystem.AthleteHeroData&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveHeroData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteHeroData&", 1)]
            public partial void REMOVE_HERO_DATA(nint setting, GameMain.AthleteSystem.AthleteHeroData &data); 
*/
            /// <summary>
            ///   System.Void RemoveHeroMasteryTree(GameMain.UnitSystem.UnitSetting unitSetting)
            /// </summary>
            /// <param name = "unitSetting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveHeroMasteryTree", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial void REMOVE_HERO_MASTERY_TREE(nint unitSetting); 
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
            ///   System.Void ResetBreakThroughTask()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetBreakThroughTask", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_BREAK_THROUGH_TASK(); 
*/
            /// <summary>
            ///   System.Void ResetHeroPickedCount()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetHeroPickedCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_HERO_PICKED_COUNT(); 
*/
            /// <summary>
            ///   System.Void ResetMasteryTree(GameMain.UnitSystem.UnitSetting unitSetting, System.Boolean loadGame)
            /// </summary>
            /// <param name = "unitSetting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "loadGame">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetMasteryTree", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void RESET_MASTERY_TREE(nint unitSetting, System.Boolean loadGame); 
*/
            /// <summary>
            ///   System.Void set_Contract(GameMain.AthleteSystem.AthleteContract value)
            /// </summary>
            /// <param name = "value">class GameMain.AthleteSystem.AthleteContract</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Contract", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteContract", 0)]
            public partial void SET_CONTRACT(nint value); 
*/
            /// <summary>
            ///   System.Void set_CurrentEmotion(GameMain.AthleteSystem.AthleteEmotion value)
            /// </summary>
            /// <param name = "value">class GameMain.AthleteSystem.AthleteEmotion</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CurrentEmotion", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteEmotion", 0)]
            public partial void SET_CURRENT_EMOTION(nint value); 
*/
            /// <summary>
            ///   System.Void set_HeroEquipmentsDefault(GameMain.UnitSystem.Equipment.HeroEquipmentsDefaultSetting value)
            /// </summary>
            /// <param name = "value">class GameMain.UnitSystem.Equipment.HeroEquipmentsDefaultSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_HeroEquipmentsDefault", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.Equipment.HeroEquipmentsDefaultSetting", 0)]
            public partial void SET_HERO_EQUIPMENTS_DEFAULT(nint value); 
*/
            /// <summary>
            ///   System.Void set_NeedRenewContract(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_NeedRenewContract", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_NEED_RENEW_CONTRACT(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_YouthWeeks(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_YouthWeeks", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_YOUTH_WEEKS(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetAbilityLevelAndExp(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Int32 level, System.Int32 exp, System.Int32 add)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "level">struct System.Int32</param>
            /// <param name = "exp">struct System.Int32</param>
            /// <param name = "add">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAbilityLevelAndExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial void SET_ABILITY_LEVEL_AND_EXP(GameMain.AthleteSystem.AthleteAbilityFlags flag, System.Int32 level, System.Int32 exp, System.Int32 add); 
*/
            /// <summary>
            ///   System.Void SetAbilityLimit(System.Int32 limit, System.Boolean checkPrime)
            /// </summary>
            /// <param name = "limit">struct System.Int32</param>
            /// <param name = "checkPrime">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAbilityLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SET_ABILITY_LIMIT(System.Int32 limit, System.Boolean checkPrime); 
*/
            /// <summary>
            ///   System.Void SetAbilityPotentialRank(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AbilityPotentialRank rank)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "rank">enum GameMain.AthleteSystem.AbilityPotentialRank</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAbilityPotentialRank", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AbilityPotentialRank", 1)]
            public partial void SET_ABILITY_POTENTIAL_RANK(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AbilityPotentialRank rank); 
*/
            /// <summary>
            ///   System.Void SetAbilityPotentialRankMin(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AbilityPotentialRank rank)
            /// </summary>
            /// <param name = "flag">enum GameMain.AthleteSystem.AthleteAbilityFlags</param>
            /// <param name = "rank">enum GameMain.AthleteSystem.AbilityPotentialRank</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetAbilityPotentialRankMin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteAbilityFlags", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AbilityPotentialRank", 1)]
            public partial void SET_ABILITY_POTENTIAL_RANK_MIN(GameMain.AthleteSystem.AthleteAbilityFlags flag, GameMain.AthleteSystem.AbilityPotentialRank rank); 
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
            ///   System.Void SetBreakThroughCounter(System.Single countRequire)
            /// </summary>
            /// <param name = "countRequire">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetBreakThroughCounter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_BREAK_THROUGH_COUNTER(System.Single countRequire); 
*/
            /// <summary>
            ///   System.Void SetBreakthroughTask(GameMain.AthleteSystem.AthleteBreakthroughTaskSetting taskSetting)
            /// </summary>
            /// <param name = "taskSetting">class GameMain.AthleteSystem.AthleteBreakthroughTaskSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetBreakthroughTask", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteBreakthroughTaskSetting", 0)]
            public partial void SET_BREAKTHROUGH_TASK(nint taskSetting); 
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
            ///   System.Void SetHeroAdaption(GameMain.UnitSystem.HeroClassTypes type, GameMain.AthleteSystem.HeroClassAdaption value)
            /// </summary>
            /// <param name = "type">enum GameMain.UnitSystem.HeroClassTypes</param>
            /// <param name = "value">enum GameMain.AthleteSystem.HeroClassAdaption</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroAdaption", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.HeroClassTypes", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.HeroClassAdaption", 1)]
            public partial void SET_HERO_ADAPTION(GameMain.UnitSystem.HeroClassTypes type, GameMain.AthleteSystem.HeroClassAdaption value); 
*/
            /// <summary>
            ///   System.Void SetHeroData(GameMain.UnitSystem.UnitSetting setting, GameMain.AthleteSystem.AthleteHeroData heroData, System.Boolean force)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "heroData">struct GameMain.AthleteSystem.AthleteHeroData</param>
            /// <param name = "force">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.AthleteSystem.AthleteHeroData", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void SET_HERO_DATA(nint setting, GameMain.AthleteSystem.AthleteHeroData heroData, System.Boolean force); 
*/
            /// <summary>
            ///   System.Void SetHeroPickedCount(GameMain.UnitSystem.UnitSetting setting, System.Int32 value, System.Boolean setValue)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <param name = "value">struct System.Int32</param>
            /// <param name = "setValue">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroPickedCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void SET_HERO_PICKED_COUNT(nint setting, System.Int32 value, System.Boolean setValue); 
*/
            /// <summary>
            ///   System.Void SetHeroPoolMax(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroPoolMax", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_HERO_POOL_MAX(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetHeroPoolMaxRandom(System.Int32 min)
            /// </summary>
            /// <param name = "min">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroPoolMaxRandom", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_HERO_POOL_MAX_RANDOM(System.Int32 min); 
*/
            /// <summary>
            ///   System.Void SyncEquipment(GameMain.UnitSystem.UnitSetting setting)
            /// </summary>
            /// <param name = "setting">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SyncEquipment", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial void SYNC_EQUIPMENT(nint setting); 
*/
            /// <summary>
            ///   System.Void SyncEquipment(System.String key)
            /// </summary>
            /// <param name = "key">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SyncEquipment", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SYNC_EQUIPMENT(nint key); 
*/
            /// <summary>
            ///   System.Void SyncEquipmentReverse(GameMain.UnitSystem.UnitSetting hero)
            /// </summary>
            /// <param name = "hero">class GameMain.UnitSystem.UnitSetting</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SyncEquipmentReverse", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.UnitSystem.UnitSetting", 0)]
            public partial void SYNC_EQUIPMENT_REVERSE(nint hero); 
*/
            /// <summary>
            ///   System.Void UpdateAthleteTitle(GameMain.StatTimeRangeTypes rangeType)
            /// </summary>
            /// <param name = "rangeType">enum GameMain.StatTimeRangeTypes</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAthleteTitle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("GameMain.StatTimeRangeTypes", 0)]
            public partial void UPDATE_ATHLETE_TITLE(GameMain.StatTimeRangeTypes rangeType); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem".""."BaseDataComponent"]
        /// </summary>
        partial struct Ptr_DataComponent
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
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem".""."BaseDataComponent`1"]
        /// </summary>
        partial struct Ptr_DataComponent
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
            ///   System.Type get_SaveDataType()
            /// </summary>
            /// <returns>abstract class System.Type</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SaveDataType", "System.Type", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SAVE_DATA_TYPE(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem".""."BaseComponent"]
        /// </summary>
        partial struct Ptr_DataComponent
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
            ///   GameMain.AthleteSystem.Athlete get_Obj()
            /// </summary>
            /// <returns>class GameMain.AthleteSystem.Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Obj", "GameMain.AthleteSystem.Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_OBJ(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility.GameSystem".""."BaseComponent"]
        /// </summary>
        partial struct Ptr_DataComponent
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
            ///   LogicFramework.LogicEntity_Athlete get_Entity()
            /// </summary>
            /// <returns>class LogicFramework.LogicEntity_Athlete</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Entity", "LogicFramework.LogicEntity_Athlete", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ENTITY(); 
*/
        }

        /// <summary>
        /// abstract class ["Utility".""."BaseComponent"]
        /// </summary>
        partial struct Ptr_DataComponent
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
            ///   System.Guid get_Id()
            /// </summary>
            /// <returns>struct System.Guid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Id", "System.Guid", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Guid GET_ID(); 
*/
            /// <summary>
            ///   System.Boolean get_IsActive()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsActive", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_ACTIVE(); 
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
            ///   Utility.GeneralObject.GeneralObject get_Obj()
            /// </summary>
            /// <returns>abstract class Utility.GeneralObject.GeneralObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Obj", "Utility.GeneralObject.GeneralObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_OBJ(); 
*/
            /// <summary>
            ///   System.Void OnCreate(Utility.GeneralObject.GeneralObject obj)
            /// </summary>
            /// <param name = "obj">abstract class Utility.GeneralObject.GeneralObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnCreate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject", 0)]
            public partial void ON_CREATE(nint obj); 
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
            ///   System.Void OnObjStart()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnObjStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_OBJ_START(); 
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
            ///   System.Void set_IsActive(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsActive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_ACTIVE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Name(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Name", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NAME(nint value); 
*/
            /// <summary>
            ///   System.Void set_Obj(Utility.GeneralObject.GeneralObject value)
            /// </summary>
            /// <param name = "value">abstract class Utility.GeneralObject.GeneralObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Obj", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject", 0)]
            public partial void SET_OBJ(nint value); 
*/
            /// <summary>
            ///   System.Boolean Utility.GeneralObject.GeneralObject.IComponent.get_IsActive()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent.get_IsActive", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean UTILITY_GENERAL_OBJECT_GENERAL_OBJECT_I_COMPONENTGET_IS_ACTIVE(); 
*/
            /// <summary>
            ///   System.Void Utility.GeneralObject.GeneralObject.IComponent.OnAddToObject(Utility.GeneralObject.GeneralObject obj, System.String name)
            /// </summary>
            /// <param name = "obj">abstract class Utility.GeneralObject.GeneralObject</param>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent.OnAddToObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Utility.GeneralObject.GeneralObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void UTILITY_GENERAL_OBJECT_GENERAL_OBJECT_I_COMPONENT_ON_ADD_TO_OBJECT(nint obj, nint name); 
*/
            /// <summary>
            ///   System.Void Utility.GeneralObject.GeneralObject.IComponent.OnObjStart()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent.OnObjStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UTILITY_GENERAL_OBJECT_GENERAL_OBJECT_I_COMPONENT_ON_OBJ_START(); 
*/
            /// <summary>
            ///   System.Void Utility.GeneralObject.GeneralObject.IComponent.set_IsActive(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Utility.GeneralObject.GeneralObject.IComponent.set_IsActive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void UTILITY_GENERAL_OBJECT_GENERAL_OBJECT_I_COMPONENTSET_IS_ACTIVE(System.Boolean value); 
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
        /// abstract class ["Utility.GameSystem".""."BaseComponent"]
        /// </summary>
        partial struct Ptr_DataComponent
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
            ///   Utility.GameSystem.LogicFrameworkX.LogicObject get_Obj()
            /// </summary>
            /// <returns>abstract class Utility.GameSystem.LogicFrameworkX.LogicObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Obj", "Utility.GameSystem.LogicFrameworkX.LogicObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_OBJ(); 
*/
        }
    }
}