﻿#pragma checksum "..\..\..\..\..\Views\Subviews\NavigationView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "757E9E443C7B95EDD6F3574CE11F3BDD636B8F25"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GestImmoWPF.Views.Subviews;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace GestImmoWPF.Views.Subviews {
    
    
    /// <summary>
    /// NavigationView
    /// </summary>
    public partial class NavigationView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\Views\Subviews\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Acceuil;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Views\Subviews\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Biens;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Views\Subviews\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Prets;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\Views\Subviews\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Prestataires;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Views\Subviews\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestImmoWPF;component/views/subviews/navigationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Subviews\NavigationView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Acceuil = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\..\Views\Subviews\NavigationView.xaml"
            this.Acceuil.Click += new System.Windows.RoutedEventHandler(this.Button_Acceuil_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Biens = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\Views\Subviews\NavigationView.xaml"
            this.Biens.Click += new System.Windows.RoutedEventHandler(this.Button_Bien_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Prets = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Prestataires = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

