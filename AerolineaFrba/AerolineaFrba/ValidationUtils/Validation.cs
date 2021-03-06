﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.ValildationUtils
{
    class Validation
    {
        public static bool isFilled(TextBox txtBox)
        {
            return String.IsNullOrWhiteSpace(txtBox.Text) ? false : true;
        }

        public static bool isFilled(ComboBox cmbBox)
        {
            return cmbBox.SelectedItem == null ? false : true;
        }

        public static void AcceptOnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
