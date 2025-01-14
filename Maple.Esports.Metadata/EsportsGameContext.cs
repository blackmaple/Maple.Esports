using Maple.Esports.Metadata.MetadataModel;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.Esports.Metadata
{

    [ContextParentMetadata<ContextMetadataCollector>(true)]
    [ContextMemberMetadata<Main>]
    [ContextMemberMetadata<Game>]
    [ContextMemberMetadata<Club>]
    [ContextMemberMetadata<DataComponent>]
    public partial class EsportsGameContext
    {
    }
}
