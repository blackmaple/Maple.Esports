using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.Esports.Metadata
{

    [ContextParentMetadata<ContextMetadataCollector>(true)]
    [ContextMemberMetadata<GameMain.Main>]
    [ContextMemberMetadata<GameMain.Game>]
    [ContextMemberMetadata<GameMain.ClubSystem.Club>]
    [ContextMemberMetadata<GameMain.ClubSystem.ClubDataComponent>]
    [ContextMemberMetadata<GameMain.ClubSystem.ClubAthleteData>]

    
    [ContextMemberMetadata<GameMain.AthleteSystem.Athlete>]
    [ContextMemberMetadata<GameMain.AthleteSystem.AthleteDataComponent>]
    [ContextMemberMetadata<GameMain.AthleteSystem.AthleteContract>]
    [ContextMemberMetadata<GameMain.AthleteSystem.AthleteEmotion>]

    public partial class EsportsGameContext
    {
    }
}
