///////////////////////////////////////////////////////
//Author: Adrian Calinciuc (adrian.calinciuc@gmail.com)
////////////////////////////////////////////////////////

using PNAViewModel;

namespace PNAControls
{
    interface IKinectClientNavigationContext
    {
         ViewModelBase GetNextContext();
         ViewModelBase GetPrevContext();
        //home screen?
    }
}
