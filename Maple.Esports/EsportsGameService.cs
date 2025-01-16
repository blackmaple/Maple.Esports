using Maple.Esports.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataService;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Microsoft.Extensions.Logging;

namespace Maple.Esports
{
    internal sealed class EsportsGameService
        (ILogger<EsportsGameService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
                : GameContextService<EsportsGameContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)
    {
        protected override EsportsGameContext LoadGameContext()
        {
            var searchService = new MetadataCollectorSearchService();
            searchService.UpdateMetadata(new MonoDescriptionCollectionDTO()
            {
                Classes = EsportsGameContext.MonoJsonClassDTO,
                Methods = EsportsGameContext.MonoJsonMethodDTO,
                Fields = EsportsGameContext.MonoJsonFieldDTO,
            });
            return new EsportsGameContext(this.Logger, searchService, this.RuntimeContext);
        }

        public Task<EsportsGameEnv> GetEsportsGameEnvAsync()
        {
            return this.MonoTaskAsync(p => p.GetEsportsGameEnv());
        }
        public async Task<EsportsGameEnv> GetEsportsGameEnvThrowIfNotLoadedAsync()
        {
            var gameEnv = await this.MonoTaskAsync(p => p.GetEsportsGameEnv()).ConfigureAwait(false);
            return gameEnv.GetThrowIfNotLoaded();
        }
        protected override async ValueTask F9_KeyDown()
        {
            var gameEnv = await this.GetEsportsGameEnvThrowIfNotLoadedAsync().ConfigureAwait(false);
            gameEnv.Test();
        }
    }
}
