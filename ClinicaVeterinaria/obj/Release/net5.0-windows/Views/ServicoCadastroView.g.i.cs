#pragma checksum "..\..\..\..\Views\ServicoCadastroView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9CD621797B63CD19C112170EC920B31666058A1E"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// ServicoCadastroView
    /// </summary>
    public partial class ServicoCadastroView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\Views\ServicoCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbClientesCadastrados;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\ServicoCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbAnimais;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Views\ServicoCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHoraInicio;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Views\ServicoCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHoraFim;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Views\ServicoCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tgbAbertoConcluido;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\Views\ServicoCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtxbObservacoes;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\Views\ServicoCadastroView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnForeground;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\Views\ServicoCadastroView.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ClinicaVeterinaria;V1.0.0.0;component/views/servicocadastroview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ServicoCadastroView.xaml"
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
            this.cmbClientesCadastrados = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\..\..\Views\ServicoCadastroView.xaml"
            this.cmbClientesCadastrados.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbClientesCadastrados_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbAnimais = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.txtHoraInicio = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\..\Views\ServicoCadastroView.xaml"
            this.txtHoraInicio.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtHoraInicio_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtHoraFim = ((System.Windows.Controls.TextBox)(target));
            
            #line 81 "..\..\..\..\Views\ServicoCadastroView.xaml"
            this.txtHoraFim.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtHoraFim_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tgbAbertoConcluido = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 88 "..\..\..\..\Views\ServicoCadastroView.xaml"
            this.tgbAbertoConcluido.Checked += new System.Windows.RoutedEventHandler(this.tgbAbertoConcluido_Checked);
            
            #line default
            #line hidden
            
            #line 88 "..\..\..\..\Views\ServicoCadastroView.xaml"
            this.tgbAbertoConcluido.Unchecked += new System.Windows.RoutedEventHandler(this.tgbAbertoConcluido_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rtxbObservacoes = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 7:
            this.btnForeground = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 105 "..\..\..\..\Views\ServicoCadastroView.xaml"
            this.btnForeground.Checked += new System.Windows.RoutedEventHandler(this.btnForeground_Checked);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\..\Views\ServicoCadastroView.xaml"
            this.btnForeground.Unchecked += new System.Windows.RoutedEventHandler(this.btnForeground_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSalvar = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\..\..\Views\ServicoCadastroView.xaml"
            this.btnSalvar.Click += new System.Windows.RoutedEventHandler(this.btnSalvar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

