﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObdExpress.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class ApplicationSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ApplicationSettings defaultInstance = ((ApplicationSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ApplicationSettings())));
        
        public static ApplicationSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string settings_dashboard_handlers {
            get {
                return ((string)(this["settings_dashboard_handlers"]));
            }
            set {
                this["settings_dashboard_handlers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int settings_dashboard_columns {
            get {
                return ((int)(this["settings_dashboard_columns"]));
            }
            set {
                this["settings_dashboard_columns"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF000000")]
        public string settings_console_background {
            get {
                return ((string)(this["settings_console_background"]));
            }
            set {
                this["settings_console_background"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFFFFFF")]
        public string settings_console_foreground {
            get {
                return ((string)(this["settings_console_foreground"]));
            }
            set {
                this["settings_console_foreground"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int settings_console_buffered_rows {
            get {
                return ((int)(this["settings_console_buffered_rows"]));
            }
            set {
                this["settings_console_buffered_rows"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string settings_application_plugins {
            get {
                return ((string)(this["settings_application_plugins"]));
            }
            set {
                this["settings_application_plugins"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9600")]
        public int settings_connection_baudrate {
            get {
                return ((int)(this["settings_connection_baudrate"]));
            }
            set {
                this["settings_connection_baudrate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int settings_connection_databits {
            get {
                return ((int)(this["settings_connection_databits"]));
            }
            set {
                this["settings_connection_databits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::System.IO.Ports.Parity settings_connection_parity {
            get {
                return ((global::System.IO.Ports.Parity)(this["settings_connection_parity"]));
            }
            set {
                this["settings_connection_parity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("One")]
        public global::System.IO.Ports.StopBits settings_connection_stopbits {
            get {
                return ((global::System.IO.Ports.StopBits)(this["settings_connection_stopbits"]));
            }
            set {
                this["settings_connection_stopbits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OBDII to RS232 Interpreter")]
        public string settings_connection_devicedescription {
            get {
                return ((string)(this["settings_connection_devicedescription"]));
            }
            set {
                this["settings_connection_devicedescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string settings_vehicleinformation_handlers {
            get {
                return ((string)(this["settings_vehicleinformation_handlers"]));
            }
            set {
                this["settings_vehicleinformation_handlers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int settings_connection_read_timeout {
            get {
                return ((int)(this["settings_connection_read_timeout"]));
            }
            set {
                this["settings_connection_read_timeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int settings_connection_write_timeout {
            get {
                return ((int)(this["settings_connection_write_timeout"]));
            }
            set {
                this["settings_connection_write_timeout"] = value;
            }
        }
    }
}
