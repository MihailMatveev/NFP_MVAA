using System;
using System.Collections.Generic;
using System.Text;
using TestWPF.Data;
using TestWPF.Models;

namespace TestWPF.ViewModes
{
    public class TableDataViewModel:ViewModes.Base.ViewModelBase
    {



        private List<BallResultExercisesForce> _BallResultForce = DateWork.SearchBallExercisesForce();
        public List<BallResultExercisesForce> BallResultForce
        {
            get { return _BallResultForce; }
            set
            {
                Set(ref _BallResultForce, value);
            }
        }


        private List<BallResultExercisesSpeed> _BallResultSpeed = DateWork.SearchBallExercisesSpeed();
        public List<BallResultExercisesSpeed> BallResultSpeed
        {
            get { return _BallResultSpeed; }
            set
            {
                Set(ref _BallResultSpeed, value);
            }
        }


        private List<BallResultExercisesEndurance> _BallResultEndurance = DateWork.SearchBallExercisesEndurance();
        public List<BallResultExercisesEndurance> BallResultEndurance
        {
            get { return _BallResultEndurance; }
            set
            {
                Set(ref _BallResultEndurance, value);
            }
        }


    }
}
