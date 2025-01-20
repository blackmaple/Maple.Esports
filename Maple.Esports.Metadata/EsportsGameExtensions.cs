﻿using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Maple.Esports.Metadata
{
    public static class EsportsGameExtensions
    {
        public static EsportsGameEnv GetEsportsGameEnv(this EsportsGameContext context)
        {
            return new EsportsGameEnv(context);
        }

        public static void Test(this EsportsGameEnv @this)
        {
            try
            {
                var c = @this.PtrClub.C_DATA.COACH_POINT;
                var t = @this.PtrClub.C_DATA.TRAIN_POINT;
                @this.Logger.LogInformation("COACH_POINT:{c}/TRAIN_POINT:{t}", c, t);
                @this.PtrClub.C_DATA.COACH_POINT = 1234;
                @this.PtrClub.C_DATA.TRAIN_POINT = 4321;


                GameMain.ClubSystem.ClubDataComponent.Ptr_DataComponent clubDataComponent = @this.PtrClub.C_DATA;
                PMonoDictionary_Esports<GameMain.AthleteSystem.Athlete.Ptr_Athlete, int> dicCLUB_ATTITUDES = clubDataComponent.CLUB_ATTITUDES;
                foreach (var d in dicCLUB_ATTITUDES.AsRefArray())
                {
                    ref var ref_value = ref Unsafe.AsRef(in d.Value);
                    ref_value = 
                }


                PMonoDictionary_Esports<Guid, GameMain.AthleteSystem.Athlete.Ptr_Athlete> dic = clubDataComponent.ATHLETE_DATA.ATHLETES;
                foreach (var athlete_data in dic.AsRefArray())
                {

                    GameMain.AthleteSystem.AthleteDataComponent.Ptr_DataComponent athleteDataComponent = athlete_data.Value.C_DATA;

                    //名字
                    var name = athleteDataComponent.PERSONAL.name.ToString();
                    //职业生涯
                    var careerLife = athleteDataComponent.PERSONAL.careerLife;
                    //年龄
                    var age = athleteDataComponent.PERSONAL.age;
                    //魅力
                    var charm = athleteDataComponent.PERSONAL.charm;
                    @this.Logger.LogInformation("name:{name}/careerLife:{careerLife}/age:{age}/charm:{charm}", name, careerLife, age, charm);
                    athleteDataComponent.PERSONAL.charm = GameMain.AthleteSystem.AthleteCharmRank.S;

                    //能力限制
                    var limit = athleteDataComponent.ABILITIES.limit;
                    //操作
                    var exp = athleteDataComponent.ABILITIES.exercise.exp;
                    var lv = athleteDataComponent.ABILITIES.exercise.level;
                    var potential = athleteDataComponent.ABILITIES.exercise.potential;
                    @this.Logger.LogInformation("limit:{limit}/exp:{exp}/lv:{lv}/potential:{potential}", limit, exp, lv, potential);
                    athleteDataComponent.ABILITIES.exercise.level = 121;
                    athleteDataComponent.ABILITIES.exercise.potential = GameMain.AthleteSystem.AbilityPotentialRank.S_Plus;
                    athleteDataComponent.ABILITIES.limit = 999;



                }
            }
            catch (Exception ex)
            {
                @this.Logger.Error(ex);
            }


        }

    }
}
