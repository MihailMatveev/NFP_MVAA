using NFP_MVAA.Data;
using NFP_MVAA.Infastructure;
using NFP_MVAA.Views.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NFP_MVAA.ViewModes.Entry
{
    public class RegisterUserViewModel : ViewModes.Base.ViewModelBase,IDataErrorInfo
    {

        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
               
                Set(ref userName, value);
            }
        }


        #region Commands
        public ICommand CloseApplicationCommand { get; set; }


        #region Validation
        public string Error { get { return null; } }

        private string errorMessege;
        public string ErrorMessege
        {
            get { return errorMessege; }
            set { Set(ref errorMessege, value); }
        }

        public string this[string columnName]
        {
            get
            {
                string result = null;
                switch (columnName)
                {
                    case "UserName":
                        if (string.IsNullOrEmpty(UserName))
                            result = "Введите имя";
                        else if (UserName.Length<=5)  //проверка на наличие пользователя
                            result = "Количество символов меньше 6";
                        break;

                    default:
                        break;
                }

                ErrorMessege=result;

                return result;
            }
        }

        #endregion

        private void OnCloseApplicationCommandExecute(object p) => Application.Current.Shutdown(); 

        #endregion


        public RegisterUserViewModel()
        {
            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecute);
        }
    }
}
