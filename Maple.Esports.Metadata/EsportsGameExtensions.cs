using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

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
                PMonoDictionary_Esports<Guid, GameMain.AthleteSystem.Athlete.Ptr_Athlete> dic = clubDataComponent.ATHLETE_DATA.ATHLETES;
                @this.Logger.LogInformation("size:{s}", dic.AsRef().Size);

                foreach (var athlete_data in dic.AsRefArray())
                {

                    GameMain.AthleteSystem.AthleteDataComponent.Ptr_DataComponent athleteDataComponent = athlete_data.Value.C_DATA;

                    var name = athleteDataComponent.PERSONAL.name.ToString();
                    var careerLife = athleteDataComponent.PERSONAL.careerLife;
                    var age = athleteDataComponent.PERSONAL.age;
                    var charm = athleteDataComponent.PERSONAL.charm;
                    @this.Logger.LogInformation("name:{name}/careerLife:{careerLife}/age:{age}/charm:{charm}", name, careerLife, age, charm);
                    athleteDataComponent.PERSONAL.charm = GameMain.AthleteSystem.AthleteCharmRank.S;

                    //
                    var limit = athleteDataComponent.ABILITIES.limit;
                    var exp = athleteDataComponent.ABILITIES.exercise.exp;
                    var lv = athleteDataComponent.ABILITIES.exercise.level;
                    var potential = athleteDataComponent.ABILITIES.exercise.potential;
                    @this.Logger.LogInformation("limit:{limit}/exp:{exp}/lv:{lv}/potential:{potential}", limit, exp, lv, potential);
                    athleteDataComponent.ABILITIES.exercise.level = 99;
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
