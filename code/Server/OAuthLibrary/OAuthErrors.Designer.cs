﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialPlus.OAuth {
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
    public class OAuthErrors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OAuthErrors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SocialPlus.Server.AuthLibrary.OAuthErrors", typeof(OAuthErrors).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request could not be understood by the server due to malformed syntax. The client SHOULD NOT repeat the request without modifications..
        /// </summary>
        public static string BadRequest_400 {
            get {
                return ResourceManager.GetString("BadRequest_400", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This form of authentication not implemented for this third party identity provider..
        /// </summary>
        public static string NotImplemented_501 {
            get {
                return ResourceManager.GetString("NotImplemented_501", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Facebook service is unavailable..
        /// </summary>
        public static string ServiceUnavailable_503_Facebook {
            get {
                return ResourceManager.GetString("ServiceUnavailable_503_Facebook", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Google service is unavailable..
        /// </summary>
        public static string ServiceUnavailable_503_Google {
            get {
                return ResourceManager.GetString("ServiceUnavailable_503_Google", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft service is unavailable..
        /// </summary>
        public static string ServiceUnavailable_503_Microsoft {
            get {
                return ResourceManager.GetString("ServiceUnavailable_503_Microsoft", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Twitter service is unavailable because Twitter&apos;s response is malformed upon asking for request token..
        /// </summary>
        public static string ServiceUnavailable_503_Twitter_1 {
            get {
                return ResourceManager.GetString("ServiceUnavailable_503_Twitter_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Twitter service is unavailable because Twitter&apos;s response is malformed upon asking for a profile in exchange for a request token..
        /// </summary>
        public static string ServiceUnavailable_503_Twitter_2 {
            get {
                return ResourceManager.GetString("ServiceUnavailable_503_Twitter_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Twitter service is unavailable because Twitter&apos;s response is malformed upon asking for an access token and an access token secret..
        /// </summary>
        public static string ServiceUnavailable_503_Twitter_3 {
            get {
                return ResourceManager.GetString("ServiceUnavailable_503_Twitter_3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token expired..
        /// </summary>
        public static string Unauthorized_401_1 {
            get {
                return ResourceManager.GetString("Unauthorized_401_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token invalid..
        /// </summary>
        public static string Unauthorized_401_2 {
            get {
                return ResourceManager.GetString("Unauthorized_401_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token contains invalid client identifier (clientID)..
        /// </summary>
        public static string Unauthorized_401_3 {
            get {
                return ResourceManager.GetString("Unauthorized_401_3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token contains invalid user (userID)..
        /// </summary>
        public static string Unauthorized_401_4 {
            get {
                return ResourceManager.GetString("Unauthorized_401_4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown exception fired..
        /// </summary>
        public static string UnknownError_520 {
            get {
                return ResourceManager.GetString("UnknownError_520", resourceCulture);
            }
        }
    }
}
