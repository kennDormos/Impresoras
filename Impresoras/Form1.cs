using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impresoras.Adapters;
using Impresoras.Clases;

namespace Impresoras
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbPrinter.Items.Add("Impresora Moderna");
            cmbPrinter.Items.Add("Impresora Antigua");
            cmbPrinter.SelectedIndex = 0; 
            cmbPrinter.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string document = "Documento de prueba";

            // Determinamos qué impresora seleccionar según la opción del usuario
            IPrinter printer = null;

            if (cmbPrinter.SelectedItem.ToString() == "Impresora Moderna")
            {
                ModernPrinter modernPrinter = new ModernPrinter();
                printer = new PrinterAdapter(modernPrinter); // Usamos el adaptador para la impresora moderna
            }
            else if (cmbPrinter.SelectedItem.ToString() == "Impresora Antigua")
            {
                OldPrinter oldPrinter = new OldPrinter();
                printer = new PrinterAdapter(oldPrinter); // Usamos el adaptador para la impresora antigua
            }

            // Usamos el adaptador para imprimir el documento
            printer.Print(document);

            // Mostrar mensaje indicando que se ha impreso
            MessageBox.Show("Documento impreso utilizando el adaptador.");
        }
    }
    }

