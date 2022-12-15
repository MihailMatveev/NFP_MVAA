using NFP_MVAA.Data;
using NFP_MVAA.Infastructure;
using NFP_MVAA.Views.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NFP_MVAA.ViewModes.Entry
{
    public class RegisterUserViewModel : ViewModes.Base.ViewModelBase
    {

        private string userName;


        public string UserName
        {
            get { return userName; }
            set=> Set(ref userName, value);
        }




        #region Commands
        public ICommand CloseApplicationCommand { get; set; }


      

        private void OnCloseApplicationCommandExecute(object p) => Application.Current.Shutdown(); 

        #endregion


        public RegisterUserViewModel()
        {
            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecute);
        }
    }
}
