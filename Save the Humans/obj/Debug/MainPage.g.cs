﻿

#pragma checksum "C:\Users\William\documents\visual studio 2013\Projects\Save the Humans\Save the Humans\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3E5A3610131A71E5D69EA8F87D7E11D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Save_the_Humans
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 72 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.startButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 81 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerMoved += this.playArea_PointerMoved;
                 #line default
                 #line hidden
                #line 81 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerExited += this.playArea_PointerExited;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 88 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.human_PointerPressed;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 93 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerEntered += this.target_PointerEntered;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


