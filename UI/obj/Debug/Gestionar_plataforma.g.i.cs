#pragma checksum "..\..\Gestionar_Plataforma.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "70141E77701121EF8F3002EC22C67EB79488D3E6F2F9A7356E02D17ED99296BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using UI;


namespace UI {
    
    
    /// <summary>
    /// Gestionar_plataforma
    /// </summary>
    public partial class Gestionar_plataforma : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Gestionar_Plataforma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Gestionar_Plataforma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem contenido;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Gestionar_Plataforma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_principal;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Gestionar_Plataforma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addplataforma;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\Gestionar_Plataforma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editplataforma;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Gestionar_Plataforma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteplataforma;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Gestionar_Plataforma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_datos;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/gestionar_plataforma.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Gestionar_Plataforma.xaml"
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
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.contenido = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 39 "..\..\Gestionar_Plataforma.xaml"
            this.contenido.Selected += new System.Windows.RoutedEventHandler(this.contenido_Selected);
            
            #line default
            #line hidden
            return;
            case 3:
            this.grid_principal = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.addplataforma = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\Gestionar_Plataforma.xaml"
            this.addplataforma.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.editplataforma = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\Gestionar_Plataforma.xaml"
            this.editplataforma.Click += new System.Windows.RoutedEventHandler(this.editplataforma_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.deleteplataforma = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\Gestionar_Plataforma.xaml"
            this.deleteplataforma.Click += new System.Windows.RoutedEventHandler(this.deleteplataforma_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.grid_datos = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

