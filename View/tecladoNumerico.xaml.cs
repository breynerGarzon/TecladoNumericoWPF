using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PruebaTelado.View
{
    /// <summary>
    /// Lógica de interacción para tecladoNumerico.xaml
    /// </summary>
    public partial class tecladoNumerico : UserControl
    {
        public TextBox campoAEscribir { get; set; }
        public tecladoNumerico()
        {
            InitializeComponent();
        }

        public void EscribirEnCampo(TextBox campo)
        {
            this.campoAEscribir = campo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tecla = (Button)sender;
            var valorTeclaSeleccionada = tecla.Content.ToString();
            campoAEscribir.Text += valorTeclaSeleccionada;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (campoAEscribir.Text.Length > 0)
            {
                var posicionActualCampo = campoAEscribir.SelectionStart -1;
                if (posicionActualCampo >= 0)
                {
                    campoAEscribir.Text = campoAEscribir.Text.Remove(posicionActualCampo, 1);
                    campoAEscribir.SelectionStart = posicionActualCampo;
                }
            }
        }
    }
}
