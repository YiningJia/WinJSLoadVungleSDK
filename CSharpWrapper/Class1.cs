//using VungleSDK;
using System;


namespace CSharpWrapper
{
    public sealed class CSharpBridge
    {
        //      static VungleAd globalAd = null;

        public string TestCSharpFunctionCall()
        {
            return "This is result returned from CSharp function";
        }

        public string callVungleSDK()
        {
            return GetInstance("This code is used inside Vungle SDK");
        }

        public static string GetInstance(string appID)
        {

            string originalStr = string.Empty;
            try
            {
                // Vungle SDK reply on XAML framework directly, so it is important that the XAML view hierachy is set properly.
                // Vungle SDK will check this and if not, will throw below exception.
                var test = Windows.UI.Xaml.Application.Current;
            }
            catch (Exception e)
            {
                originalStr = e.ToString();
                //throw new NotSupportedException("Vungle SDK does not support environments that does not provide XAML framework");
            }

            return originalStr;
        }
    }
}
