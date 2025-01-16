using Maple.MonoGameAssistant.Common;
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
            var clubDataComponent = @this.PtrClub.C_DATA;
            var c = clubDataComponent.COACH_POINT;
            @this.Logger.LogInformation("{c}", c);

            var t = clubDataComponent.TRAIN_POINT;
            @this.Logger.LogInformation("{t}", t);

            @this.PtrClub.C_DATA2.COACH_POINT = 1234;
            @this.PtrClub.C_DATA2.TRAIN_POINT = 4321;
        }

    }
}
