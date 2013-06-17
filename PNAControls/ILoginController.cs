///////////////////////////////////////////////////////
//Author: Adrian Calinciuc (adrian.calinciuc@gmail.com)
////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PNAControls
{
    interface ILoginController
    {
        bool ValidateSecretGesture();
        bool ValidateViaMobile();

    }
}
