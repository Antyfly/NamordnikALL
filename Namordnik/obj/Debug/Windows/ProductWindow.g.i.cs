﻿#pragma checksum "..\..\..\Windows\ProductWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0160D0A63EC65042789EAA0998D13FD21FEDC923341F4CBA1DA233FF46589173"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Namordnik;
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


namespace Namordnik.Windows {
    
    
    /// <summary>
    /// ProductWindow
    /// </summary>
    public partial class ProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Windows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Windows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortComboBox;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Windows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterComboBox;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Windows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewProductButton;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Windows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeMinCostButton;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Windows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeftButton;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Windows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel NumberButtonStackPanel;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\Windows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RightButton;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Windows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductListView;
        
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
            System.Uri resourceLocater = new System.Uri("/Namordnik;component/windows/productwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ProductWindow.xaml"
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
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\Windows\ProductWindow.xaml"
            this.SearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SortComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 54 "..\..\..\Windows\ProductWindow.xaml"
            this.SortComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FilterComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 72 "..\..\..\Windows\ProductWindow.xaml"
            this.FilterComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NewProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\Windows\ProductWindow.xaml"
            this.NewProductButton.Click += new System.Windows.RoutedEventHandler(this.NewProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ChangeMinCostButton = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\Windows\ProductWindow.xaml"
            this.ChangeMinCostButton.Click += new System.Windows.RoutedEventHandler(this.ChangeMinCostButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LeftButton = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\Windows\ProductWindow.xaml"
            this.LeftButton.Click += new System.Windows.RoutedEventHandler(this.LeftButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NumberButtonStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.RightButton = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\Windows\ProductWindow.xaml"
            this.RightButton.Click += new System.Windows.RoutedEventHandler(this.RightButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ProductListView = ((System.Windows.Controls.ListView)(target));
            
            #line 122 "..\..\..\Windows\ProductWindow.xaml"
            this.ProductListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
