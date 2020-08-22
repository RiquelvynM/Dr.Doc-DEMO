using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Drdoc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavegationRecordatorio : TabbedPage
    {
        public NavegationRecordatorio ()
        {
            InitializeComponent();
        }

        private void Bttn_Clicked(object sender, EventArgs e)
        {

        }
    }
}