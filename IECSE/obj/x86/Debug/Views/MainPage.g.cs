﻿#pragma checksum "F:\Projects\IECSE app\iesce-app-windows\IECSE\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "98B1270EDA21B65FE0C89A7CF98250AC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IECSE.Views
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MainSplit = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.PaneStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.MenuButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 21 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.MenuButton).Checked += this.MenuButton_Checked;
                    #line default
                }
                break;
            case 4:
                {
                    this.HomeButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 26 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.HomeButton).Checked += this.HomeButton_Checked;
                    #line default
                }
                break;
            case 5:
                {
                    this.AccountButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 31 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.AccountButton).Checked += this.AccountButton_Checked;
                    #line default
                }
                break;
            case 6:
                {
                    this.SettingsButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 36 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.SettingsButton).Checked += this.SettingsButton_Checked;
                    #line default
                }
                break;
            case 7:
                {
                    this.AboutButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 41 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.AboutButton).Checked += this.AboutButton_Checked;
                    #line default
                }
                break;
            case 8:
                {
                    this.ShellGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    this.HomeGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10:
                {
                    this.SettingsGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 11:
                {
                    this.AccountGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 12:
                {
                    this.AboutGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13:
                {
                    this.ButtonHolder = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 14:
                {
                    this.UsernameBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.PasswordBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 16:
                {
                    this.LoginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 66 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LoginButton).Click += this.LoginButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

