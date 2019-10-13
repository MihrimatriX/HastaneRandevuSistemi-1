using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaKayitSistemi.UI
{
   public static class Metotlar
    {
        public static bool BosAlanVarMi(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text.Trim() == "") return true;
                }
                else if (item is ComboBox)
                {
                    if (((ComboBox)item).SelectedIndex == -1) return true;
                }
                else if (item is DateTimePicker)
                {
                    if (((DateTimePicker)item).Value.Date == DateTime.Now.Date)
                        return true;
                }
            }
            return false;
        }


        public static void Temizle(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is TextBox) item.Text = "";
                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;
                else if (item is DateTimePicker) ((DateTimePicker)item).Value = DateTime.Now;
                else if (item is MaskedTextBox) ((MaskedTextBox)item).ResetText();
                else if (item is ListBox) ((ListBox)item).DataSource = null;
                else if (item is Label && item.Name.StartsWith("lbl")) item.Text = "";
            }
        }








    }
}
