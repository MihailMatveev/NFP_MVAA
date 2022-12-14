using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using TestWPF.Data;
using TestWPF.Infastructure;
using TestWPF.Models;

namespace TestWPF.ViewModes
{
    public class BasicViewModel:ViewModes.Base.ViewModelBase
    {
        #region ComboBox
        private List<Name_Exercises> _Force =NameAndNumberExercisesbyqualities.ForceExercisesNameAndNumber;

        public List<Name_Exercises> Force
        {
            get { return _Force; }
            set
            {
                Set(ref _Force, value);
            } 
               
        }

        private List<Name_Exercises> _Speed = NameAndNumberExercisesbyqualities.SpeedExercisesNameAndNumber;

        public List<Name_Exercises> Speed
        {
            get { return _Speed; }
            set
            {
                Set(ref _Speed, value);
            }

        }

        private List<Name_Exercises> _Endurance = NameAndNumberExercisesbyqualities.EnduranceExercisesNameAndNumber;

        public List<Name_Exercises> Endurance
        {
            get { return _Endurance; }
            set
            {
                Set(ref _Endurance, value);
            }

        }
        #endregion
        #region Fields
        #region result

        private string force_result;
        public string Force_result
        {
            get { return force_result; }
            set
            {
                Set(ref force_result, value);
                Force_Ball = DateWork.ForceSearchBall(force_result,SelectedForce);
            }
        }

        private string speed_result;
        public string Speed_result
        {
            get { return speed_result; }
            set
            {
                Set(ref speed_result, value);
                Speed_Ball = DateWork.SpeedSearchBall(speed_result,SelectedSpeed);
            }
        }

        private string endurance_result;
        public string Endurance_result
        {
            get { return endurance_result; }
            set
            {
                Set(ref endurance_result, value);
                IsChekResultNull();            
            }
        }

        #endregion
        #region Ball

        private string force_ball;
        public string Force_Ball
        {
            get { return force_ball; }
            set
            {
                Set(ref force_ball, value);
                if(force_result != null)
                 Sum_Ball = Convert.ToInt32(endurance_ball) + Convert.ToInt32(speed_ball) + Convert.ToInt32(force_ball);
            }

        }

        private string speed_ball;
        public string Speed_Ball
        {
            get { return speed_ball; }
            set
            {
                Set(ref speed_ball, value);
                if (speed_result != null)
                    Sum_Ball = Convert.ToInt32(endurance_ball) + Convert.ToInt32(speed_ball) + Convert.ToInt32(force_ball);
            }
        }

        private string endurance_ball;
        public string Endurance_Ball
        {
            get { return endurance_ball; }
            set
            {
                Set(ref endurance_ball, value);
                if (endurance_result != null)
                    Sum_Ball = Convert.ToInt32(endurance_ball) + Convert.ToInt32(speed_ball) + Convert.ToInt32(force_ball);
            }
        }


        private int sum_ball;
        public int Sum_Ball
        {
            get { return sum_ball; }
            set
            {
                Set(ref sum_ball, value);
            }
        }

        void IsChekResultNull()
        {
            if (endurance_result == null)
                return;
           if(DateWork.EnduranceSearchBall(endurance_result, SelectedEndurance) == null
                || DateWork.EnduranceSearchBall(endurance_result, SelectedEndurance)=="")
            {
                string[] resultMinAndSec=endurance_result.Split('.');
                if ((Convert.ToInt32(resultMinAndSec[1]) + 1).ToString()=="60")
                {
                    resultMinAndSec[0] = (Convert.ToInt32(resultMinAndSec[0]) + 1).ToString();
                    resultMinAndSec[1] = "00";
                    endurance_result = resultMinAndSec[0] + "." + resultMinAndSec[1];
                    IsChekResultNull();
                    return;
                }
                endurance_result = resultMinAndSec[0]+"."+(Convert.ToInt32(resultMinAndSec[1])+1).ToString();
                IsChekResultNull();
            }
            Endurance_Ball = DateWork.EnduranceSearchBall(endurance_result, SelectedEndurance);
        }

        #endregion
        #region SelectedComboBox
        private int _SelectedForce=2;

        public int SelectedForce
        {
            get { return _SelectedForce; }
            set
            {
                Set(ref _SelectedForce, value);
                Force_Ball = DateWork.ForceSearchBall(force_result, SelectedForce);
            }

        }

        private int _SelectedSpeed = 1;

        public int SelectedSpeed
        {
            get { return _SelectedSpeed; }
            set
            {
                Set(ref _SelectedSpeed, value);
                Speed_Ball = DateWork.SpeedSearchBall(speed_result, SelectedSpeed);
            }
        }

        private int _SelectedEndurance = 2;

        public int SelectedEndurance
        {
            get { return _SelectedEndurance; }
            set
            {
                Set(ref _SelectedEndurance, value);
                IsChekResultNull();
            }
        }

        #endregion
        #endregion
        #region Commands
        public ICommand CloseApplicationCommand { get; set; }

        private void OnCloseApplicationCommandExecute(object p) => Application.Current.Shutdown();
        #endregion
       
        public BasicViewModel()
        {
            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecute);
        }
    }
}
