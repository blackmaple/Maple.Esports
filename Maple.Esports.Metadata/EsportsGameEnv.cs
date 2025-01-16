using Maple.Esports.Metadata.MetadataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Esports.Metadata
{
    public partial class EsportsGameEnv
    {
        public EsportsGameContext Context { get; }
        public Main.Ptr_Main PtrMain { get; }
        public Game.Ptr_Game PtrGame { get; }
        public Club.Ptr_Club PtrClub => this.PtrGame.CLUB_PLAYER;

        public DataComponent.Ptr_DataComponent DataComponent => PtrClub.C_DATA;

        public EsportsGameEnv(EsportsGameContext gameContext)
        {
            this.Context = gameContext;
            this.PtrMain = Main.Ptr_Main.INST;
            this.PtrGame = PtrMain.GAME;
        }


        public bool ThrowNotLoadGame()
        {
        
            if (this.PtrGame)
            {
                return true;
            }
            return Maple.MonoGameAssistant.GameDTO.GameException.ThrowIfNotLoaded<bool>();
          
        }

     
    }

 }
