﻿#pragma checksum "C:\Users\arnes\Desktop\Untitled\RRentingProjekat\RRentingProjekat\EtfHotel\Views\RecepcionerView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B0A9E3BB5ADD2C354A6B888E824D3CBB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RRentingProjekat.RRentingBaza.Views
{
    partial class RecepcionerView : 
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
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.btnDodajGosta = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\..\EtfHotel\Views\RecepcionerView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDodajGosta).Click += this.btnDodajGosta_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnUplati = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\..\EtfHotel\Views\RecepcionerView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnUplati).Click += this.btnUplati_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnAzurirajSobe = (global::Windows.UI.Xaml.Controls.Button)(target);
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

