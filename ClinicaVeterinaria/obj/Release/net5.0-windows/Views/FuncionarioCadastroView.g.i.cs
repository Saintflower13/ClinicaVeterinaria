﻿#pragma checksum "..\..\..\..\Views\FuncionarioCadastroView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F7D706CE8239CC465E9256646AC19101928E2420"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using ClinicaVeterinaria.UserControls;
using ClinicaVeterinaria.Views;
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


namespace ClinicaVeterinaria.Views {
    
    
    /// <summary>
    /// FuncionarioCadastroView
    /// </summary>
    public partial class FuncionarioCadastroView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbNomeCompleto;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFuncoes;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tglOperadorAdmin;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbUsuario;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtSenha;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pswSenha;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpDataContratacao;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalvar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ClinicaVeterinaria;V1.0.0.0;component/views/funcionariocadastroview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txbNomeCompleto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cmbFuncoes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.tglOperadorAdmin = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 46 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
            this.tglOperadorAdmin.Checked += new System.Windows.RoutedEventHandler(this.tglOperadorAdmin_Checked);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
            this.tglOperadorAdmin.Unchecked += new System.Windows.RoutedEventHandler(this.tglOperadorAdmin_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbUsuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtSenha = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.pswSenha = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 57 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
            this.pswSenha.KeyUp += new System.Windows.Input.KeyEventHandler(this.pswSenha_KeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dtpDataContratacao = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.btnSalvar = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\Views\FuncionarioCadastroView.xaml"
            this.btnSalvar.Click += new System.Windows.RoutedEventHandler(this.btnSalvar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

