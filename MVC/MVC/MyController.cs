using MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC
{
    public class MyController
    {
        string lang = null;
        HttpCookie langCookie = Request.Cookies["culture"];  
            if (langCookie != null) {  
                lang = langCookie.Value;  
            } else {  
                var userLanguage = Request.UserLanguages;
    var userLang = userLanguage != null ? userLanguage[0] : "";  
                if (userLang != "") {  
                    lang = userLang;  
                } else {  
                    lang = LanguageMang.GetDefaultLanguage();  
                }  
            }  
            new LanguageMang().SetLanguage(lang);  
            return base.BeginExecuteCore(callback, state);  
        }  
    }
}
