﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SlowPerformanceMonitor.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.1.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.bing.com;http://www.douban.com;http://www.google.com")]
        public string Url {
            get {
                return ((string)(this["Url"]));
            }
            set {
                this["Url"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int BroswerType {
            get {
                return ((int)(this["BroswerType"]));
            }
            set {
                this["BroswerType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public int MonitorDays {
            get {
                return ((int)(this["MonitorDays"]));
            }
            set {
                this["MonitorDays"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int TimeSpanToSleepInSeconds {
            get {
                return ((int)(this["TimeSpanToSleepInSeconds"]));
            }
            set {
                this["TimeSpanToSleepInSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int SlowPerformancePageLoadThreshold {
            get {
                return ((int)(this["SlowPerformancePageLoadThreshold"]));
            }
            set {
                this["SlowPerformancePageLoadThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int SlowPerformanceReoccurrenceThreshold {
            get {
                return ((int)(this["SlowPerformanceReoccurrenceThreshold"]));
            }
            set {
                this["SlowPerformanceReoccurrenceThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsSignInRequired {
            get {
                return ((bool)(this["IsSignInRequired"]));
            }
            set {
                this["IsSignInRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("180")]
        public int ManuallySignInTimeInSeconds {
            get {
                return ((int)(this["ManuallySignInTimeInSeconds"]));
            }
            set {
                this["ManuallySignInTimeInSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("chunlonl@microsoft.com")]
        public string EmailToEmailAddress {
            get {
                return ((string)(this["EmailToEmailAddress"]));
            }
            set {
                this["EmailToEmailAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("57795973@qq.com")]
        public string EmailFromEmailAddress {
            get {
                return ((string)(this["EmailFromEmailAddress"]));
            }
            set {
                this["EmailFromEmailAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("57795973@qq.com")]
        public string EmailCcEmailAddress {
            get {
                return ((string)(this["EmailCcEmailAddress"]));
            }
            set {
                this["EmailCcEmailAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Slow performance was detected")]
        public string EmailSubject {
            get {
                return ((string)(this["EmailSubject"]));
            }
            set {
                this["EmailSubject"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Slow performance was detected just now, pls check PageLoadMetricsCsv and log file" +
            " for more details. ")]
        public string EmailBody {
            get {
                return ((string)(this["EmailBody"]));
            }
            set {
                this["EmailBody"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("smtp.qq.com")]
        public string EmailSmtpAddress {
            get {
                return ((string)(this["EmailSmtpAddress"]));
            }
            set {
                this["EmailSmtpAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("465")]
        public int EmailSmtpPort {
            get {
                return ((int)(this["EmailSmtpPort"]));
            }
            set {
                this["EmailSmtpPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("57795973")]
        public string EmailSenderLoginName {
            get {
                return ((string)(this["EmailSenderLoginName"]));
            }
            set {
                this["EmailSenderLoginName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ljdrkepotropbieg")]
        public string EmailSenderLoginPasswords {
            get {
                return ((string)(this["EmailSenderLoginPasswords"]));
            }
            set {
                this["EmailSenderLoginPasswords"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Beta1.0")]
        public string Version {
            get {
                return ((string)(this["Version"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public int PageLoadTimeoutInSeconds {
            get {
                return ((int)(this["PageLoadTimeoutInSeconds"]));
            }
            set {
                this["PageLoadTimeoutInSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Chunlong")]
        public string EmailFromName {
            get {
                return ((string)(this["EmailFromName"]));
            }
            set {
                this["EmailFromName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Chunlong")]
        public string EmailToName {
            get {
                return ((string)(this["EmailToName"]));
            }
            set {
                this["EmailToName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Chunlong")]
        public string EmailCcName {
            get {
                return ((string)(this["EmailCcName"]));
            }
            set {
                this["EmailCcName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EmailIsSenderLoginPasswordsEncrypted {
            get {
                return ((bool)(this["EmailIsSenderLoginPasswordsEncrypted"]));
            }
            set {
                this["EmailIsSenderLoginPasswordsEncrypted"] = value;
            }
        }
    }
}
