using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.Esports.Metadata
{

    [ContextParentMetadata<ContextMetadataCollector>(true)]
    [ContextMemberMetadata<GameMain.Main>]
    [ContextMemberMetadata<GameMain.Game>]
    [ContextMemberMetadata<GameMain.ClubSystem.Club>]
    [ContextMemberMetadata<GameMain.ClubSystem.DataComponent>]
    public partial class EsportsGameContext
    {
    }
}
