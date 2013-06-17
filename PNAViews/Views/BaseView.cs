using System;
using System.Windows.Controls;

namespace PNAViews
{
    public class BaseView : UserControl
    {
        public object model;
     
        public BaseView()
        {

        }

        public void  InitialiseModel(Type modelType)
        {
            model = Activator.CreateInstance(modelType) ;
            if (model == null)
                throw new ApplicationException("ViewModel not initialised for current view");
            this.DataContext = model;
        }
    }
}
