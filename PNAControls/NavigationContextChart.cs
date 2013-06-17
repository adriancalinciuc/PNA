///////////////////////////////////////////////////////
//Author: Adrian Calinciuc (adrian.calinciuc@gmail.com)
////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;

namespace PNAControls
{
    [Serializable]
    public class NavigationContextChart
    {
        public Type  ApplicationEntryPoint; //aka MainWindow or LoginScreen
        public Panel PrimaryPanel; //aka MainWindow presenting the Company Partners and an EmployeesButton
        public Panel FlowPanel;

    }
    [Serializable]
    public class Panel
    {
        public List<PanelAction> PanelActions;
        public List<Type> PanelDependencies;

    }
    [Serializable]
    public class PanelAction
    {
        public string Name;
        public Panel  ResponsePanel;
    }

}
