using clases_heredadas.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clases_heredadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        //Clase Auto:
        public class auto
        {
            private int cantidadDeRuedas = 0;
            public string tipoDeMotor = "";
            public double cantidadDeCombustible = 0.0;
            public int cantidadDePasajeros = 0;
            public double pesoMaximoAlcanzable = 0.0;
            public string matricula = "";
            public double velocidadAlcanzada = 0.0;
            public bool encendido = false;

            //Getters & Setters:
            public double getVelocidadAlcanzada()
            {
                return velocidadAlcanzada;
            }
            public void setVelocidadAlcanzada(double velocidadAlcanzada)
            {

            }

            public bool getEncendido()
            {
                return encendido;
            }
            public void setEncendido(bool encendido)
            {

            }
            public int getCantidadDeRuedas()
            {
                return cantidadDeRuedas;
            }
            public void setCantidadDeRuedas(int cantidad)
            {

            }

            public string getTipoDeMotor()
            {
                return tipoDeMotor;
            }
            public void setTipoDeMotor(string tipoDeMotor)
            {

            }

            public double getCantidadDeCombustible()
            {
                return cantidadDeCombustible;
            }
            public void setCantidadDeCombustible(double cantidadDeCombustible)
            {

            }
            public int getCantidadDePasajeros()
            {
                return cantidadDePasajeros;
            }
            public void setCantidadDePasajeros(int cantidadDePasajeros)
            {

            }

            public double getPesoMaximoAlcanzable()
            {
                return pesoMaximoAlcanzable;
            }
            public void setPesoMaximoAlcanzable(double pesoMaximoAlcanzable)
            {

            }

            public string getMatricula()
            {
                return matricula;
            }
            public void setMatricula(string matricula)
            {

            }

        }

        //delcaración de la llamada a la clase auto:
        auto autoStatement = new auto();
        ////////////////////////////////////////////

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            autoStatement.getEncendido();

            string sonidoDeAuto1 = Path.Combine(Application.StartupPath, "sonido", "poco combustible.wav");
            string sonidoDeAuto2 = Path.Combine(Application.StartupPath, "sonido", "bien de combustible.wav");

            if (autoStatement.cantidadDeCombustible <= 14.9 && chbEncenderElAuto.Checked)
            {
                SoundPlayer sonar = new SoundPlayer(sonidoDeAuto1);

                sonar.Play();
            }
            else
            {
                
            }
            if (autoStatement.cantidadDeCombustible >= 15 && chbEncenderElAuto.Checked)
            {
                SoundPlayer sonar = new SoundPlayer(sonidoDeAuto2);

                sonar.Play();
            }
            



            if (chbEncenderElAuto.Checked || autoStatement.encendido == false)
            {
                autoStatement.setEncendido(true);
                txtCombustible.Enabled = false;
                txtCantPasajeros.Enabled = false;
                txtPeso.Enabled = false;
                txtTipoDeMotor.Enabled = false;
                txtMatricula.Enabled = false;
                labEncendidoApagado.Text = "Encendido";

                if (autoStatement.encendido == true || chbEncenderElAuto.Checked == false)
                {
                    autoStatement.setEncendido(false);
                    txtCantPasajeros.Enabled = true;
                    txtCombustible.Enabled = true;
                    txtMatricula.Enabled = true;
                    txtTipoDeMotor.Enabled = true;
                    txtPeso.Enabled = true;
                    labEncendidoApagado.Text = "Apagado";
                }
                
            }
            if (chbEncenderElAuto.Checked)
            {
                txtVelocidadKMPH.Enabled = true;
                btnAdelante.Enabled = true;
                btnAtras.Enabled = true;
                btnDerecha.Enabled = true;
                btnIzquierda.Enabled = true;
            }
            if (chbEncenderElAuto.Checked == false)
            {
                txtVelocidadKMPH.Enabled = false;
                btnAdelante.Enabled = false;
                btnAtras.Enabled = false;
                btnDerecha.Enabled = false;
                btnIzquierda.Enabled = false;
            }
        }

        private void btnCombustibleDetalles_Click(object sender, EventArgs e)
        {
            MessageBox.Show(autoStatement.cantidadDeCombustible.ToString() + " lt", "Detalles del Tanque de Combustible", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Si... Zurdos de Mierda, exclamó.
        private void pbJavierMilei_Click(object sender, EventArgs e)
        {
            string rutaDeArchivo = Path.Combine(Application.StartupPath, "sonido", "zurdos_de_Mierda.wav");

            if (File.Exists(rutaDeArchivo))
            {
                MessageBox.Show("Si no bajó el volumen, HÁGALO YA!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                SoundPlayer hacerSoanr = new SoundPlayer(rutaDeArchivo);

                hacerSoanr.Play();
            }
            else
            {
                MessageBox.Show("El archivo de Sonido no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



            if (double.TryParse(txtCombustible.Text, out double seteoCombustible))
            {
                autoStatement.cantidadDeCombustible = seteoCombustible;
            }
            else
            {
                autoStatement.setCantidadDeCombustible(0);
            }

            if (autoStatement.cantidadDeCombustible <= (-0))
            {
                labCombustibleTexto.Text = "BLACKHOLE";
            }
            else if (autoStatement.cantidadDeCombustible == 0.0)
            {
                labCombustibleTexto.Text = "Vacío";
            }
            else if (autoStatement.cantidadDeCombustible >= 1 && autoStatement.cantidadDeCombustible <= 14.9)
            {
                labCombustibleTexto.Text = "Casi Vacío";
            }
            else if (autoStatement.cantidadDeCombustible >= 15 && autoStatement.cantidadDeCombustible <= 44.9)
            {
                labCombustibleTexto.Text = "Medio Vacío";
            }
            else if (autoStatement.cantidadDeCombustible >= 45.0 && autoStatement.cantidadDeCombustible <= 59.9)
            {
                labCombustibleTexto.Text = "Medio Tanque";
            }
            else if (autoStatement.cantidadDeCombustible >= 60.0 && autoStatement.cantidadDeCombustible <= 75.9)
            {
                labCombustibleTexto.Text = "Medio Lleno";
            }
            else if (autoStatement.cantidadDeCombustible >= 76.0 && autoStatement.cantidadDeCombustible <= 90.0)
            {
                labCombustibleTexto.Text = "Casi Lleno";
            }
            else if (autoStatement.cantidadDeCombustible >= 99.0 && autoStatement.cantidadDeCombustible >= 104)
            {
                labCombustibleTexto.Text = "Lleno";
            }
            else if (autoStatement.cantidadDeCombustible >= 105.0)
            {
                labCombustibleTexto.Text = "DESBORDANDO!";
            }

            if (autoStatement.cantidadDeCombustible <= 0.0)
            {
                chbEncenderElAuto.Checked = false;
                chbEncenderElAuto.Enabled = false;
            }
            else
            {
                chbEncenderElAuto.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtCombustible.TextChanged += textBox1_TextChanged;
            txtVelocidadKMPH.TextChanged += textBox1_TextChanged;
            txtTipoDeMotor.TextChanged += textBox1_TextChanged;

            if (autoStatement.cantidadDeCombustible == 0)
            {
                txtCombustible.Text = "0";
            }
            if (autoStatement.velocidadAlcanzada == 0)
            {
                txtVelocidadKMPH.Text = "0";
            }

            if (chbEncenderElAuto.Checked == false)
            {
                txtVelocidadKMPH.Enabled = false;
                btnAdelante.Enabled = false;
                btnAtras.Enabled=false;
                btnDerecha.Enabled = false;
                btnIzquierda.Enabled = false;
            }
            

            MessageBox.Show("Si va a apretar al Javier Milei, por favor baje el volumen de su computadora hasta un 20%", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtVelocidadKMPH_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtVelocidadKMPH.Text, out double setterVelocidad))
            {
                autoStatement.velocidadAlcanzada = setterVelocidad;

            }
            else
            {
                autoStatement.setVelocidadAlcanzada(0);
            }

            labVelocidadAlcanzada.Text = ("kmph " + setterVelocidad.ToString());

            if (autoStatement.velocidadAlcanzada > 1)
            {
                btnPM.Enabled = false;
                labPosicionamiento.Text = "Quemando motor";
            }

            if (autoStatement.velocidadAlcanzada == 0)
            {
                btnPM.Enabled = true;
                labPosicionamiento.Text = "Nada";
            }
        }

        private void txtCantPasajeros_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantPasajeros.Text, out int setterCantPasajeros))
            {
                autoStatement.cantidadDePasajeros = setterCantPasajeros;
            }
            else
            {
                autoStatement.setCantidadDePasajeros(0);
            }

            labPasajeros.Text = setterCantPasajeros.ToString();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out double setterPeso))
            {
                autoStatement.pesoMaximoAlcanzable = setterPeso;
            }
            else
            {
                autoStatement.setPesoMaximoAlcanzable(0);
            }
            labPesoMaximo.Text = ("kg " + setterPeso.ToString());
        }

        private void txtTipoDeMotor_TextChanged(object sender, EventArgs e)
        { 
            autoStatement.tipoDeMotor = txtTipoDeMotor.Text;

            labTipoDeMotor.Text = txtTipoDeMotor.Text;
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            autoStatement.matricula = txtMatricula.Text;

            labMatricula.Text = txtMatricula.Text;
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            labPosicionamiento.Text = "Doblando Izquierda";
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            labPosicionamiento.Text = "Doblando Derecha";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            labPosicionamiento.Text = "Marcah atrás";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            
            labPosicionamiento.Text = "Punto Muerto";
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            labPosicionamiento.Text = "Hacia Adelante";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

