﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4963
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxiManager.Classes {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TaxiManager.Classes.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to Record deleted..
        /// </summary>
        internal static string MSG_Del {
            get {
                return ResourceManager.GetString("MSG_Del", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The system encounters error. Please seek advice from the administrator..
        /// </summary>
        internal static string MSG_Err {
            get {
                return ResourceManager.GetString("MSG_Err", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The username and password is incorrect. Please try again..
        /// </summary>
        internal static string MSG_LoginFail {
            get {
                return ResourceManager.GetString("MSG_LoginFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete this record?.
        /// </summary>
        internal static string MSG_RequestDel {
            get {
                return ResourceManager.GetString("MSG_RequestDel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Record saved..
        /// </summary>
        internal static string MSG_Sav {
            get {
                return ResourceManager.GetString("MSG_Sav", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Taxi Management System.
        /// </summary>
        internal static string TTLDefault {
            get {
                return ResourceManager.GetString("TTLDefault", resourceCulture);
            }
        }
    }
}
