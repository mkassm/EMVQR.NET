﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMVQR {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LibraryResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LibraryResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EMVQR.LibraryResources", typeof(LibraryResources).Assembly);
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
        ///   Looks up a localized string similar to Validation for {0} failed..
        /// </summary>
        internal static string CompositeValidationFailed {
            get {
                return ResourceManager.GetString("CompositeValidationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to decode the QR code..
        /// </summary>
        internal static string FailedToDecode {
            get {
                return ResourceManager.GetString("FailedToDecode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If Tip or Convenience Indicator is set to 2, Value of Convenience Fee Fixed is required. .
        /// </summary>
        internal static string IfTipOrConvenienceIndicator2ThenDependencyRequired {
            get {
                return ResourceManager.GetString("IfTipOrConvenienceIndicator2ThenDependencyRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If Tip or Convenience Indicator is set to 3, Value of Convenience Fee Percentage is required..
        /// </summary>
        internal static string IfTipOrConvenienceIndicator3ThenDependencyRequired {
            get {
                return ResourceManager.GetString("IfTipOrConvenienceIndicator3ThenDependencyRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to QR data has an invalid CRC..
        /// </summary>
        internal static string InvalidCrc {
            get {
                return ResourceManager.GetString("InvalidCrc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Merchant Account Information ID allocation must be between 26 and 51..
        /// </summary>
        internal static string MerchantAccountInformationInvalidIdentifier {
            get {
                return ResourceManager.GetString("MerchantAccountInformationInvalidIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one Globally Unique Identifier of the Merchant Account Information node is required..
        /// </summary>
        internal static string MerchantAccountInformationIsRequired {
            get {
                return ResourceManager.GetString("MerchantAccountInformationIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In this version of the specification, the Payload Format Indicator has the value &quot;01&quot;..
        /// </summary>
        internal static string PayloadFormatIndicatorMustBe1 {
            get {
                return ResourceManager.GetString("PayloadFormatIndicatorMustBe1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tip or Convenience Indicator must be either 1, 2, or 3..
        /// </summary>
        internal static string TipOrConvenienceIndicatorMustBeBetween1and3 {
            get {
                return ResourceManager.GetString("TipOrConvenienceIndicatorMustBeBetween1and3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The payload cannot be generated because there are validation errors..
        /// </summary>
        internal static string ValidationError {
            get {
                return ResourceManager.GetString("ValidationError", resourceCulture);
            }
        }
    }
}
