﻿#pragma checksum "..\..\..\Pages\MemberMainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1CC3C5F6E41D9CA11FEB07786FCF1F08ACF73838FCEAD88FE66ECC6AA90276F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Tournament_420_Khurmatullin_Bulat_Samatovich.Pages;


namespace Tournament_420_Khurmatullin_Bulat_Samatovich.Pages {
    
    
    /// <summary>
    /// MemberMainPage
    /// </summary>
    public partial class MemberMainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Pages\MemberMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBt;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\MemberMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button JoinBt;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\MemberMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListUsers;
        
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
            System.Uri resourceLocater = new System.Uri("/Tournament_420_Khurmatullin_Bulat_Samatovich;component/pages/membermainpage.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MemberMainPage.xaml"
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
            this.AddBt = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Pages\MemberMainPage.xaml"
            this.AddBt.Click += new System.Windows.RoutedEventHandler(this.AddBt_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.JoinBt = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\MemberMainPage.xaml"
            this.JoinBt.Click += new System.Windows.RoutedEventHandler(this.JoinBt_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListUsers = ((System.Windows.Controls.ListView)(target));
            
            #line 49 "..\..\..\Pages\MemberMainPage.xaml"
            this.ListUsers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListUsers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

