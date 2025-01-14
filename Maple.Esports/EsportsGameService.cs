﻿using Maple.Esports.Metadata;
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


        protected override ValueTask F9_KeyDown()
        {
            return base.F9_KeyDown();
        }
    }
}