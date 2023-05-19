using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETAutoMate
{
    internal class Forms
    {
        private static ProvisionPage provisionPage = new ProvisionPage();
        public static ProvisionPage ProvisionPage
        {
            get
            {
                if (provisionPage == null)
                {
                    provisionPage = new ProvisionPage();                  
                }
                return provisionPage;
            }
        }

        private static ConfigType configType = new ConfigType();
        public static ConfigType ConfigType
        {
            get
            {
                if (configType == null)
                {
                    configType = new ConfigType();
                }
                return configType;
            }
        }

        private static WelcomePage welcomePage = new WelcomePage();
        public static WelcomePage WelcomePage
        {
            get
            {
                if (welcomePage == null)
                {
                    welcomePage = new WelcomePage();
                }
                return welcomePage;
            }
        }

        private static SelectionPage selectionPage = new SelectionPage();
        public static SelectionPage SelectionPage
        {
            get
            {
                if (selectionPage == null)
                {
                    selectionPage = new SelectionPage();
                }
                return selectionPage;
            }
        }

        private static PortScanner portScanner = new PortScanner();
        public static PortScanner PortScanner
        {
            get
            {
                if(portScanner.IsDisposed)
                {
                    portScanner = new PortScanner();
                }
                return portScanner;
            }
        }

        private static GetConfig getConfig = new GetConfig();
        public static GetConfig GetConfig
        {
            get
            {
                if(getConfig.IsDisposed)
                {
                    getConfig = new GetConfig();
                }
                return getConfig;
            }
        }

        private static RoutedInterfacesPage interfacesPage = new RoutedInterfacesPage();
        public static RoutedInterfacesPage InterfacesPage
        {
            get
            {
                if(interfacesPage.IsDisposed)
                {
                    interfacesPage = new RoutedInterfacesPage();
                }
                return interfacesPage;
            }
        }

        private static LoopbackInterfacesPage loopbackinterfacesPage = new LoopbackInterfacesPage();
        public static LoopbackInterfacesPage LoopbacktnterfacesPage
        {
            get
            {
                if (loopbackinterfacesPage.IsDisposed)
                {
                    loopbackinterfacesPage = new LoopbackInterfacesPage();
                }
                return loopbackinterfacesPage;
            }
        }

        private static VLANInterfacesPage vLANInterfacesPage = new VLANInterfacesPage();
        public static VLANInterfacesPage VLANInterfacesPage
        {
            get
            {
                if(vLANInterfacesPage.IsDisposed)
                {
                    vLANInterfacesPage = new VLANInterfacesPage();
                }
                return vLANInterfacesPage;
            }
        }
    }
}
