using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Impresoras.Clases;

namespace Impresoras.Adapters
{
    public class PrinterAdapter : IPrinter
    {
        private ModernPrinter _modernPrinter;
        private OldPrinter _oldPrinter;
        private bool _isModernPrinter;

        // Constructor que recibe una impresora y un flag que indica qué tipo de impresora es
        public PrinterAdapter(ModernPrinter modernPrinter)
        {
            _modernPrinter = modernPrinter;
            _isModernPrinter = true;
        }

        public PrinterAdapter(OldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
            _isModernPrinter = false;
        }

        // Implementa el método Print de IPrinter
        public void Print(string document)
        {
            if (_isModernPrinter)
            {
                _modernPrinter.PrintDocument(document);
            }
            else
            {
                _oldPrinter.PrintOldVersion(document);
            }
        }
    }
}
