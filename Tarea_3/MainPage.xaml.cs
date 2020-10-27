using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnNP1_Clicked(object sender, EventArgs e)
        {
            try
            {
                //asignacion de valores desde xaml 
                double nota1 = Convert.ToDouble(txtNota1.Text);
                double nota2 = Convert.ToDouble(txtNota2.Text);
                double examen = Convert.ToDouble(txtExamen.Text);


                // accion 
                double promedio = (nota1 + nota2) / 2;
                double seguimiento = promedio * 0.3;
                double rExamen = examen * 0.2;
                double calcular = seguimiento + rExamen;
                txtRNP1.Text = calcular.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta ", "Error" + ex.Message, "ok");

            }
        }

        private void btnNP2_Clicked(object sender, EventArgs e)
        {
            try
            {
                //asignacion de valores desde xaml 
                double nota3 = Convert.ToDouble(txtNota3.Text);
                double nota4 = Convert.ToDouble(txtNota4.Text);
                double examen2 = Convert.ToDouble(txtExamen2.Text);


                // accion 
                double promedioSegundo = (nota3 + nota4) / 2;
                double seguimientoSegundo = promedioSegundo * 0.3;
                double rExamenSegundo = examen2 * 0.2;
                double calcular2 = seguimientoSegundo + rExamenSegundo;
                txtRNP2.Text = calcular2.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta ", "Error" + ex.Message, "ok");

            }
        }

        private void btnResultado_Clicked(object sender, EventArgs e)
        {

        }

        private void btnFinal_Clicked(object sender, EventArgs e)
        {
            try
            {
                double parcial1 = Convert.ToDouble(txtRNP1.Text);
                double parcial2 = Convert.ToDouble(txtRNP2.Text);


                double notaFinal = parcial1 + parcial2;
                txtNF.Text = notaFinal.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta ", "Error" + ex.Message, "ok");

            }
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Vista_dos());


        }
    }
}
