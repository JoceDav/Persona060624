using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (radioalumno.Checked)
            {

                MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
                + "\nEdad: " + textBox3.Text + "\nMatricula: " + textBox4.Text + "\nCarrera: "
                , MessageBoxButtons.OK, MessageBox.Icon.Information);
                //uso los parametros del constructor 
                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                Alumno alumno = new Alumno(nom, edad, fech, carrera, mat);
                //guardar los datos en el archivo txt
                alumno.Guardar_info();
            }
            else
            {
                if (radiodocente.Checked || radioempleado.Checked)
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
              + "\nEdad: " + textBox3.Text + "\nDNI: " + textBox4.Text + "\nPuesto: " + textBox5.Text + "\nSueldo: " + textBox6.Text, "datos",
              MessageBoxButtons.OK, MessageBox.Icon.Information);
                    if (radioempleado_CheckedChanged)
                    {
                        string nom = textBox1.Text;
                        string fech = textBox2.Text;
                        int edad = Convert.ToInt32(textBox3.Text);
                        int mat = Convert.ToInt32(textBox4.Text);
                        string puesto = textBox5.Text;
                        float sueldo = Convert.ToSingle(textBox6.text);
                        Empleado empleado = new Empleado(nom, edad, fech, mat, puesto, sueldo);
                        //guardar los datos en el archivo txt
                        empleado.Guardar_info();
                    }
                }
                else
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
              + "\nEdad: " + textBox3.Text + "\nDNI: " + textBox4.Text + "\nPuesto: " + textBox5.Text + "\nSueldo: " + textBox6.Text, "datos",
              MessageBoxButtons.OK, MessageBox.Icon.Information);
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.text);
                    Docente docente = new Empleado(nom, edad, fech, mat, puesto, sueldo);
                    //guardar los datos en el archivo txt
                    docente.Guardar_info();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rutaImagen;
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen= "C:\\Users\\chipi\\Downloads\\Parcial2-main\\Parcial2-main\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\mensaje-de-bienvenida.png");
            radioalumno.Checked = false;
            radioButton1.Checked = false;
            radiodocente.Checked = false;
            radioempleado.Checked = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            string rutaImagen= "C:\\Users\\chipi\\Downloads\\Parcial2-main\\Parcial2-main\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\persona.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label6.Visible = false;
            textBox6.Visible = false;
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label6.Visible = false;
            textBox6.Visible = false;

        }

        private void radioempleado_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\chipi\\Downloads\\Parcial2-main\\Parcial2-main\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\empleado.png";
            label6.Visible = false;
            textBox6.Visible = false;
        }

        private void radiodocente_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\chipi\\Downloads\\Parcial2-main\\Parcial2-main\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\docente.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label6.Visible = false;
            textBox6.Visible = false;
        }

        private void radioalumno_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen= "C:\\Users\\chipi\\Downloads\\Parcial2-main\\Parcial2-main\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\alumno.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label6.Visible = false;
            textBox6.Visible = false;

            if (label4.Visible == false && textBox4.Visible == false && label5.Visible == false && textBox5.Visible == false) //comprobar que los label y textbox estem
                                                                                                                              //apagados o prendidos
            {
                label4.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void validar_Click_1(object sender, EventArgs e)
        {
            if (radioalumno.Checked)
            {
                
                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                Alumno alumno = new Alumno(nom, edad, fech, carrera, mat);
                
            }
            else
            {
                if (radioempleado.Checked)
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.Text);
                    Empleado empleado = new Empleado(nom, edad, fech, puesto, sueldo);
                }
                else if (radiodocente.Checked)
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.Text);
                    Docente docente = new Docente(nom, edad, fech, puesto, sueldo);
                }
                else
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                }
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Este cierra las ventanas y finaliza la ejecucion del programa. 
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            //Los textBox son las cajas de lso botones 
            //Clear como su mismo nombre lo dice, limpia/quita lo que se escribrio en esa caja de texto. 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}

