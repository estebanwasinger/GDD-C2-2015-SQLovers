using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AerolineaFrba.Models.Utils
{
    public static class Utils
    {
        /*public static DateTime fechaSistema = 
            Convert.ToDateTime(@System.Configuration.ConfigurationSettings.AppSettings["Fecha"]);*/

        public static int mapBoolToBit(bool bit) {
            return bit ? 1 : 0;
        }

        public static bool isNumeric(char keypress) {
            return isPlainNumeric(keypress) ||
                keypress == ',';
        }

        public static DataGridViewTextBoxColumn crearColumna(String dataPropertyName, String headerText, int width, bool readOnly)
        {
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            columna.DataPropertyName = dataPropertyName;
            columna.HeaderText = headerText;
            columna.Width = width;
            columna.ReadOnly = readOnly;
            return columna;
        }

        public static bool isPlainNumeric(char keypress)
        {
            return keypress == Convert.ToChar(Keys.D0) ||
                            keypress == Convert.ToChar(Keys.D1) ||
                            keypress == Convert.ToChar(Keys.D2) ||
                            keypress == Convert.ToChar(Keys.D3) ||
                            keypress == Convert.ToChar(Keys.D4) ||
                            keypress == Convert.ToChar(Keys.D5) ||
                            keypress == Convert.ToChar(Keys.D6) ||
                            keypress == Convert.ToChar(Keys.D7) ||
                            keypress == Convert.ToChar(Keys.D8) ||
                            keypress == Convert.ToChar(Keys.D9) ||
                            keypress == Convert.ToChar(Keys.NumPad0) ||
                            keypress == Convert.ToChar(Keys.NumPad1) ||
                            keypress == Convert.ToChar(Keys.NumPad2) ||
                            keypress == Convert.ToChar(Keys.NumPad3) ||
                            keypress == Convert.ToChar(Keys.NumPad4) ||
                            keypress == Convert.ToChar(Keys.NumPad5) ||
                            keypress == Convert.ToChar(Keys.NumPad6) ||
                            keypress == Convert.ToChar(Keys.NumPad7) ||
                            keypress == Convert.ToChar(Keys.NumPad8) ||
                            keypress == Convert.ToChar(Keys.NumPad9) ||
                            keypress == Convert.ToChar(Keys.Back);
        }
        
        public static bool isCaracterInvalido(Char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            return false;
        }
    }
}
