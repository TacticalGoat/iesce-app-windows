﻿#pragma checksum "F:\Projects\IECSE app\iesce-app-windows\IECSE\Views\StuffPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FA8D0FE41612946446E20B72FA117C91"
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
    partial class StuffPage : 
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
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.HomeButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 31 "..\..\..\Views\StuffPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.HomeButton).Click += this.HomeButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.StuffButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 32 "..\..\..\Views\StuffPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.StuffButton).Click += this.StuffButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.SettingsButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 33 "..\..\..\Views\StuffPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.SettingsButton).Click += this.SettingsButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.AboutButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 34 "..\..\..\Views\StuffPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.AboutButton).Click += this.AboutButton_Click;
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

