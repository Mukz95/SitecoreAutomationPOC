using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SitecoreAutomationPOC.Tests.EnviromentSettings
{
    public class EnviromentSettings
    {
        public static string SitecoreLoginUrl
        {
            get { return ConfigurationManager.AppSettings["SitecoreContentAuthoringLoginUrl"]; }
        }

        public static string SitecoreLoginWeb
        {
            get
            {
                return ConfigurationManager.AppSettings["SitecoreContentAuthoringLoginWeb"];
                
            }
        }

        public static string SitecoreEnviromentUsername
        {
            get { return ConfigurationManager.AppSettings["SitecoreEnvironmentValidationUsername"]; }
        }

        public static string SitecoreEnviromentPassword
        {
            get { return ConfigurationManager.AppSettings["SitecoreEnvironmentValidationPassword"]; }
        }

    }
}
