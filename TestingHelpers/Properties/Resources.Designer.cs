﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.IO.Abstractions.TestingHelpers.Properties {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {

#if NET40
                    Assembly assembly = typeof(Resources).Assembly;
#elif DOTNET5_4
                    Assembly assembly = typeof(Resources).GetTypeInfo().Assembly;
#endif

                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TestingHelpers.Properties.Resources", assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to Could not find a part of the path &apos;{0}&apos;..
        /// </summary>
        internal static string COULD_NOT_FIND_PART_OF_PATH_EXCEPTION {
            get {
                return ResourceManager.GetString("COULD_NOT_FIND_PART_OF_PATH_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Illegal characters in path..
        /// </summary>
        internal static string ILLEGAL_CHARACTERS_IN_PATH_EXCEPTION {
            get {
                return ResourceManager.GetString("ILLEGAL_CHARACTERS_IN_PATH_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to This test helper hasn&apos;t been implemented yet. They are implemented on an as-needed basis. As it seems like you need it, now would be a great time to send us a pull request over at https://github.com/tathamoddie/System.IO.Abstractions. You know, because it&apos;s open source and all..
        /// </summary>
        internal static string NOT_IMPLEMENTED_EXCEPTION {
            get {
                return ResourceManager.GetString("NOT_IMPLEMENTED_EXCEPTION", resourceCulture);
            }
        }
    }
}
