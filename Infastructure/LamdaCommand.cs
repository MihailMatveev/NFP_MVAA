using System;
using System.Collections.Generic;
using System.Text;
using TestWPF.Infastructure.Base;

namespace TestWPF.Infastructure
{
    public class LamdaCommand:Command
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExectute;

        public LamdaCommand(Action<object> Execute,Func<object,bool> CanExectute=null )
        {
            execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            canExectute = CanExectute;
        }
        public override bool CanExecute(object parameter)=> canExectute?.Invoke(parameter)??true;
        public override void Execute(object parameter) => execute(parameter);
    }
}
