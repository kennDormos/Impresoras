using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impresoras.Clases
{
    public class OldPrinter
    {
        public void PrintOldVersion(string document)
        {
            MessageBox.Show($"Imprimiendo con la impresora antigua: {document}");
        }
    }
}

