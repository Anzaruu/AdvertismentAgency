﻿#pragma checksum "..\..\PageClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B60F96444246F9577DAC2113D5AAD22202D8CA6E977B59262600C9FF58D0D74F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjectAdvert;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ProjectAdvert {
    
    
    /// <summary>
    /// PageClient
    /// </summary>
    public partial class PageClient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurnameTxtBx;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTxtBx;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastnameTxtBx;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PaspNumTxtBx;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox IdCityCmbBx;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Mistakes;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddClientBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdatetClientBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteClientfBtn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ClientDtGrd;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjectAdvert;component/pageclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageClient.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SurnameTxtBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NameTxtBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LastnameTxtBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PaspNumTxtBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.IdCityCmbBx = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Mistakes = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.AddClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\PageClient.xaml"
            this.AddClientBtn.Click += new System.Windows.RoutedEventHandler(this.AddClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.UpdatetClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\PageClient.xaml"
            this.UpdatetClientBtn.Click += new System.Windows.RoutedEventHandler(this.UpdateClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DeleteClientfBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\PageClient.xaml"
            this.DeleteClientfBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ClientDtGrd = ((System.Windows.Controls.DataGrid)(target));
            
            #line 40 "..\..\PageClient.xaml"
            this.ClientDtGrd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ClientDtGrd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
