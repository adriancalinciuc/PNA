using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;

namespace PNAShared
{
    public class AppRoutedCommands
    {

        private static ExtendedCommand showDetail;
        public static ExtendedCommand ShowDetail
        {

            get
            {
                if (showDetail == null)
                {
                    showDetail = new ExtendedCommand();
                }
                return showDetail;
            }
        }

        private static ExtendedCommand showFwd;
        public static ExtendedCommand ShowFwd
        {

            get
            {
                if (showFwd == null)
                {
                    showFwd = new ExtendedCommand();
                }
                return showFwd;
            }
        }


        private static ExtendedCommand showBck;
        public static ExtendedCommand ShowBck
        {

            get
            {
                if (showBck == null)
                {
                    showBck = new ExtendedCommand();
                }
                return showBck;
            }
        }


        
    }

    //copyright Bryan Noise; slightly adapted
    //http://msdn.microsoft.com/en-us/magazine/cc785480.aspx#id0190070

    public class ExtendedCommand : ICommand
    {
        Action<FrameworkElement> m_ExecuteTargets = delegate { };
        Func<bool> m_CanExecuteTargets = delegate { return false; };
        bool m_Enabled = false;

        public bool CanExecute(object parameter)
        {
            Delegate[] targets = m_CanExecuteTargets.GetInvocationList();
            foreach (Func<bool> target in targets)
            {
                m_Enabled = false;
                bool localenable = target.Invoke();
                if (localenable)
                {
                    m_Enabled = true;
                    break;
                }
            } return m_Enabled;
        }
        public void Execute(object parameter)
        {
            if (m_Enabled)
                m_ExecuteTargets(parameter != null ? parameter as FrameworkElement : null);
        }

        public event EventHandler CanExecuteChanged = delegate { };

        public event Action<FrameworkElement> ExecuteTargets
        {
            add { m_ExecuteTargets += value; }
            remove { m_ExecuteTargets -= value; }
        }
        public event Func<bool> CanExecuteTargets
        {
            add { m_CanExecuteTargets += value; CanExecuteChanged(this, EventArgs.Empty); }
            remove { m_CanExecuteTargets -= value; CanExecuteChanged(this, EventArgs.Empty); }
        }
    }
}
