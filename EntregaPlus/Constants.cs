using System;
using System.Collections.Generic;
using System.Text;

namespace EntregaPlus
{
    public static class Constants
    {
        public static string AppName = "OAuthNativeFlow";

        // Google OAuth
        // For Google login, configure at https://console.developers.google.com/
        public static string GoogleiOSClientId = "<insert IOS client ID here>";
        public static string GoogleAndroidClientId = "683603945861-hnc8rnu8m71dh1juerek7bhd6vpst6r0.apps.googleusercontent.com.apps.googleusercontent.com";

        // These values do not need changing
        public static string GoogleScope = "https://www.googleapis.com/auth/userinfo.email https://www.googleapis.com/auth/userinfo.profile";
        public static string GoogleAuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
        public static string GoogleAccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
        public static string GoogleUserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

        // Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
        public static string GoogleiOSRedirectUrl = "<insert IOS redirect URL here>:/oauth2redirect";
        public static string GoogleAndroidRedirectUrl = "com.googleusercontent.apps.683603945861-hnc8rnu8m71dh1juerek7bhd6vpst6r0.apps.googleusercontent.com:/oauth2redirect";

    }
}
