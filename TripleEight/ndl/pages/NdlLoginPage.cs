using com.tripleEigth.auto.ndl.pages.lobby;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tripleEigth.auto.ndl.pages
{
    public class NdlLoginPage : SeleniumPageObject
    {
       private const string usernameFieldSelector = "//input[@data-automationid='loginUsernameInput']";
       private const string passwordFieldSelector = "//input[@data-automationid='loginPasswordInput']";
       private const string loginBtnSelector = "//div[@data-automationid='loginEnterButton']";
        
        public NdlLoginPage(SeleniumDriver driver) : base(driver, "http://ndl.triple8holdem.com"){}

        public string Username
        {
            get
            {
                return getDriver().GetAttribute(usernameFieldSelector, "value");
            }
            set
            {
                getDriver().Type(usernameFieldSelector, value);
            }
        }

        public string Password
        {
            get
            {
                return getDriver().GetAttribute(passwordFieldSelector, "value");
            }
            set
            {
                getDriver().Type(passwordFieldSelector, value);
            }
        }

        public void ClickLoginBtn()
        {
            getDriver().Click(loginBtnSelector, 10);
        }

        ////

        public NdlLobbyPage doLogin(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            ClickLoginBtn();
            return new NdlLobbyPage(this.getDriver());
        }
    }
}
