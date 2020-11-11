using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace variant3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class page : ContentPage
    {
        TimeSpan _triggerTime;
        public page()
       /* {
            TimePicker timePicker = new TimePicker() { Time = new TimeSpan(22, 0, 0) };
            this.Content = timePicker;
        }*/
        private void timePicker_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _triggerTime = timepicker.Time;

            if (_triggerTime.Hours.ToString() == "0")
                {
                    info.Text = "";
                    imageforpicker.Source = "";
                }
        }
    }
}