using VungleSDK;
using System;


namespace CSharpWrapper
{
    public sealed class CSharpBridge
    {
        static VungleAd globalAd = null;

        public string TestCSharpFunctionCall()
        {
            return "This is result returned from CSharp function";
        }

        public string callVungleSDK()
        {
            globalAd = AdFactory.GetInstance("vungleTest", new VungleSDKConfig() { });
            return string.Empty;
        }
    }
}
