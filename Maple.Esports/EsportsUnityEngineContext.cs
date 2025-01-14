using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;

namespace Maple.Esports
{
    internal partial class EsportsUnityEngineContext(MonoRuntimeContext runtimeContext, ILogger logger) : UnityEngineContext(runtimeContext,  logger  )
    {
    }
}
