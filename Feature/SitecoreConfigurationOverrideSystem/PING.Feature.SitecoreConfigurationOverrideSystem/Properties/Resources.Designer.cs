﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PING.Feature.SitecoreConfigurationOverrideSystem.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PING.Feature.SitecoreConfigurationOverrideSystem.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to using Sitecore.Configuration;
        ///using Sitecore.Diagnostics;
        ///using System.Collections.Generic;
        ///using System.Configuration;
        ///using System.Linq;
        ///using System.Xml;
        ///
        ///namespace $NameSpaceToken
        ///{
        ///    public class $ClassNameToken : $BaseTypeToken
        ///    {
        ///        private const string SettingPrefixKey = &quot;SitecoreSetting.&quot;;
        ///        private const string SitecoreSettingXpathTemplate = &quot;/sitecore/settings/setting[@name=&apos;{0}&apos;]&quot;;
        ///
        ///        private const string VariablePrefixKey = &quot;SitecoreVariable.&quot;;
        ///        priva [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PingSitecoreConfigOverrideReaderTemplate {
            get {
                return ResourceManager.GetString("PingSitecoreConfigOverrideReaderTemplate", resourceCulture);
            }
        }
    }
}
