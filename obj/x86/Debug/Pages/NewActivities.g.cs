﻿#pragma checksum "C:\Projects\Master\TripPlanner-master\TripPlanner\Pages\NewActivities.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C42836957A9AE55FD9B1731B63E2BE55"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TripPlanner.Pages
{
    partial class NewActivities : 
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
                    this.mySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.activity = (global::Windows.UI.Xaml.Controls.RichEditBox)(target);
                }
                break;
            case 3:
                {
                    this.activityLocation = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.activityEndTime = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 5:
                {
                    this.activityStartTime = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 6:
                {
                    this.menuItems = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 29 "..\..\..\Pages\NewActivities.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.menuItems).SelectionChanged += this.menuItems_SelectionChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.hamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\Pages\NewActivities.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.hamburgerButton).Click += this.hamburgerButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.addNewActivity = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 81 "..\..\..\Pages\NewActivities.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.addNewActivity).Click += this.addNewActivity_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.cancelNewActivity = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 86 "..\..\..\Pages\NewActivities.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.cancelNewActivity).Click += this.cancelNewActivity_Click;
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

