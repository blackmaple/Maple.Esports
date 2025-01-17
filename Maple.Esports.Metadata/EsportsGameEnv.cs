using Microsoft.Extensions.Logging;

namespace Maple.Esports.Metadata
{
    public partial class EsportsGameEnv
    {
        public EsportsGameContext Context { get; }
        public ILogger Logger => Context.Logger;
        public GameMain.Main.Ptr_Main PtrMain { get; }
        public GameMain.Game.Ptr_Game PtrGame { get; }
        public GameMain.ClubSystem.Club.Ptr_Club PtrClub => this.PtrGame.CLUB_PLAYER;

        //   public DataComponent.Ptr_DataComponent ClubDataComponent => PtrClub.C_DATA;

        public EsportsGameEnv(EsportsGameContext gameContext)
        {
            this.Context = gameContext;
            this.PtrMain = GameMain.Main.Ptr_Main.INST;
            this.PtrGame = PtrMain.GAME;
        }


        public EsportsGameEnv GetThrowIfNotLoaded()
        {

            if (this.PtrGame)
            {
                return this;
            }
            return Maple.MonoGameAssistant.GameDTO.GameException.ThrowIfNotLoaded<EsportsGameEnv>();

        }


    }
}
