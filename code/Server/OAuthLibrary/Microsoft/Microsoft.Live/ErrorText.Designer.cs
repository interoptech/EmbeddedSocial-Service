﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Live {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorText {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorText() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SocialPlus.Server.AuthLibrary.Microsoft.Microsoft.Live.ErrorText", typeof(ErrorText).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current page request does not contain any response data from the authorization server..
        /// </summary>
        internal static string AuthServerResponseNotAvailable {
            get {
                return ResourceManager.GetString("AuthServerResponseNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no default redirect URL provided. A redirect URL is required for this operation..
        /// </summary>
        internal static string DefaultRedirectUrlMissing {
            get {
                return ResourceManager.GetString("DefaultRedirectUrlMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is an existing async task running..
        /// </summary>
        internal static string ExistingAuthTaskRunning {
            get {
                return ResourceManager.GetString("ExistingAuthTaskRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client code is requesting a refresh token, this requires an IRefreshTokenHandler instance to be provided when creating the LiveAuthClient instance..
        /// </summary>
        internal static string IRefreshTokenHandlerNotProvided {
            get {
                return ResourceManager.GetString("IRefreshTokenHandlerNotProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The new session received does not match the user Id from the current session..
        /// </summary>
        internal static string NewSessionDoesNotMatchCurrentUserId {
            get {
                return ResourceManager.GetString("NewSessionDoesNotMatchCurrentUserId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value is invalid. Allowed display parameter values are &quot;popup&quot;, &quot;touch&quot;, &quot;page&quot;, &quot;desktop&quot;, &quot;windows_phone&quot;, &quot;ios_phone&quot;, &quot;ios_tablet&quot;, &quot;android_phone&quot;, &quot;andrioid_tablet&quot; and &quot;none&quot;..
        /// </summary>
        internal static string ParameterInvalidDisplayValue {
            get {
                return ResourceManager.GetString("ParameterInvalidDisplayValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IEnumerable&lt;string&gt; value cannot be empty..
        /// </summary>
        internal static string ParameterInvalidEnumerablerEmpty {
            get {
                return ResourceManager.GetString("ParameterInvalidEnumerablerEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null, empty or white spaces..
        /// </summary>
        internal static string ParameterInvalidStringNullOrEmpty {
            get {
                return ResourceManager.GetString("ParameterInvalidStringNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The URL value is not valid..
        /// </summary>
        internal static string ParameterInvalidUrlFormat {
            get {
                return ResourceManager.GetString("ParameterInvalidUrlFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user ID from the given RefreshTokenInfo instance does not match the refresh token..
        /// </summary>
        internal static string RefereshTokenNotMatchUserId {
            get {
                return ResourceManager.GetString("RefereshTokenNotMatchUserId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user ID from the given RefreshTokenInfo instance does not match the ID in the current session..
        /// </summary>
        internal static string RefereshTokenUserIdNotMatchSession {
            get {
                return ResourceManager.GetString("RefereshTokenUserIdNotMatchSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client_id in the token request from client side does not match the client Id value in the current LiveAuthClient instance..
        /// </summary>
        internal static string RefreshRequestClientIdNotMatch {
            get {
                return ResourceManager.GetString("RefreshRequestClientIdNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while retrieving the user&apos;s refresh token..
        /// </summary>
        internal static string RetrieveRefreshTokenError {
            get {
                return ResourceManager.GetString("RetrieveRefreshTokenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to retrieve user access token..
        /// </summary>
        internal static string RetrieveTokenError {
            get {
                return ResourceManager.GetString("RetrieveTokenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while performing the operation. Please try again later..
        /// </summary>
        internal static string ServerError {
            get {
                return ResourceManager.GetString("ServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current session is expired. Either there is no refresh token available or we are unable to retrieve a new access token..
        /// </summary>
        internal static string SessionExpired {
            get {
                return ResourceManager.GetString("SessionExpired", resourceCulture);
            }
        }
    }
}
