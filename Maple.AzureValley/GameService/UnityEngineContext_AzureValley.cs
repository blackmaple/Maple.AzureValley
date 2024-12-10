using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Maple.AzureValley.GameService
{
    public class UnityEngineContext_AzureValley(MonoRuntimeContext runtimeContext, ILogger logger) : UnityEngineContext(runtimeContext, logger)
    {
        protected nint UnityPlayer { get; } = MonoCollectorMember.GetModuleBaseAddress("UnityPlayer.dll");

        public int Func_ENCODE_TO_PNG { get; set; } = 0x17C640;
        public int Func_BLIT2 { get; set; } = 0x6CF60;
        public int Func_GET_TEXTURE_RECT_INJECTED { get; set; } = 0xF3850;
        public int Func_READ_PIXELS_IMPL_INJECTED { get; set; } = 0x96D90;

        protected sealed override bool TryGetCustomMethodPointer(MonoCollecotrClassSettings classSettings, string methodName, out nint address)
        {
            address = methodName switch
            {
                "GetTextureRect_Injected" => Func_GET_TEXTURE_RECT_INJECTED + UnityPlayer,
                "EncodeToPNG" => Func_ENCODE_TO_PNG + UnityPlayer,
                "Blit2" => Func_BLIT2 + UnityPlayer,
                "ReadPixelsImpl_Injected" => Func_READ_PIXELS_IMPL_INJECTED + UnityPlayer,
                _ => IntPtr.Zero,
            };
            return address > UnityPlayer;


        }


    }




}
