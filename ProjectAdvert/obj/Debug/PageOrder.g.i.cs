﻿#pragma checksum "..\..\PageOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "163BAB511BA12D77B6B38C230D911BB0A6DF628F644627FA3625767F97FE33CC"
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
    /// PageOrder
    /// </summary>
    public partial class PageOrder : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\PageOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox IdCarrierCmbBx;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\PageOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox IdServiceCmbBx;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PageOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTxtBx;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\PageOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Mistakes;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\PageOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddOrderBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\PageOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdatetOrderBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\PageOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteOrderBtn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\PageOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrderDtGrd;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectAdvert;component/pageorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageOrder.xaml"
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
            this.IdCarrierCmbBx = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.IdServiceCmbBx = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.PriceTxtBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Mistakes = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.AddOrderBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\PageOrder.xaml"
            this.AddOrderBtn.Click += new System.Windows.RoutedEventHandler(this.AddOrderBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UpdatetOrderBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\PageOrder.xaml"
            this.UpdatetOrderBtn.Click += new System.Windows.RoutedEventHandler(this.UpdateOrderBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteOrderBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\PageOrder.xaml"
            this.DeleteOrderBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteOrderStaffBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.OrderDtGrd = ((System.Windows.Controls.DataGrid)(target));
            
            #line 39 "..\..\PageOrder.xaml"
            this.OrderDtGrd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OrderDtGrd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

