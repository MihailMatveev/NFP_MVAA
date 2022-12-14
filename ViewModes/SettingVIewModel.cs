using System;
using System.Collections.Generic;
using System.Text;
using NFP_MVAA.Data;
using NFP_MVAA.Models;

namespace NFP_MVAA.ViewModes
{
    public class SettingVIewModel:ViewModes.Base.ViewModelBase
    {
        private List<CategoryMillitary> category=DateWork.SearchCategory();

        public List<CategoryMillitary> Category
        {
            get { return category; }
            set
            {
                Set(ref category, value);
            }
        }


        private int _SelectedCategory=6;

        public int SelectedFCategory
        {
            get { return _SelectedCategory; }
            set
            {
                Set(ref _SelectedCategory, value);
            }

        }
    }
}
