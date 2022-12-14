using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestWPF.Data;
using TestWPF.Infastructure;
using TestWPF.ViewModes.Base;
using TestWPF.Views.Pages;

namespace TestWPF.ViewModes
{
    public class MainWindowViewModel:ViewModes.Base.ViewModelBase
    {

        #region Page

        private Page basicView=new BasicView();
        private Page methodologyView=new MethodologyView();
        private Page tableDataView=new TableDataView();
        private Page settingView=new SettingView();
        private Page _CurrentPage=new BasicView();
        #endregion

        public Page CurrentPage
        {
            get =>_CurrentPage;
            set=> Set(ref _CurrentPage, value);
        }

        #region Command
        #region Закрытие приложения
        public ICommand CloseApplicationCommand { get; set; }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecute(object p)=> Application.Current.Shutdown();
        #endregion


        #region отображение страницы
        public ICommand ShowHomeViewCommand  { get; set; }
        private void OnShowHomeView(object obj)
        {
            CurrentPage = basicView;
        }

        public ICommand ShowMethodologyViewViewCommand { get; set; }
        private void OnShowMethodologyViewlView(object obj)
        {
            CurrentPage = methodologyView;
        }

        public ICommand ShowTableViewCommand { get; set; }
        private void OnShowTableView(object obj)
        {
            CurrentPage = tableDataView;
        }

        public ICommand ShowSettingsViewCommand { get; set; }
        private void OnShowSettingView(object obj)
        {
            CurrentPage = settingView;
        }

        #endregion
        #endregion


        private void InitialCommand()
        {
            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);

            ShowHomeViewCommand  = new LamdaCommand(OnShowHomeView);
            ShowMethodologyViewViewCommand = new LamdaCommand(OnShowMethodologyViewlView);
            ShowSettingsViewCommand = new LamdaCommand(OnShowSettingView);
            ShowTableViewCommand = new LamdaCommand(OnShowTableView);
            OnShowHomeView(null);
        }

       

        public MainWindowViewModel()
        {
            InitialCommand();
        }

    }
}
