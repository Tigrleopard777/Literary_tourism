/*
 * Maps form
 * contains Google or Yandex maps
 * are opening in included web-browser
 * created by: Vlasov R.E.
 * e-mail: ryslanvlasov@mail.ru
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LiteraryTourism.Forms
{
    public partial class MapsForm : Form
    {
        public MapsForm(string url)
        {
            InitializeComponent();
            try
            {
                web.Url = new Uri(url);
            }
            catch
            {
                Messages.ErrorConnection();
            }
        }
    }
}
