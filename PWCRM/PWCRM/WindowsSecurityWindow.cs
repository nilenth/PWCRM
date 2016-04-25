using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace PWCRM
{
    public class WindowsSecurityWindow : WinWindow
    {
        private WinText uiUseanotheraccountText;
        private WinEdit uiUsernameEdit;
        private WinEdit uiPasswordEdit;
        private WinButton uiokButton;

        public WindowsSecurityWindow()
        {
            SearchProperties[PropertyNames.Name] = "Windows Security";
            SearchProperties[PropertyNames.ClassName] = "#32770";
            TechnologyName = "MSAA";
            WindowTitles.Add("Windows Security");
        }

        public WinText UseAnotherAccountText
        {
            get
            {
                if ((uiUseanotheraccountText == null))
                {
                    uiUseanotheraccountText = new WinText(this);
                    uiUseanotheraccountText.SearchProperties[WinText.PropertyNames.Name] = "Use another account";
                }

                return uiUseanotheraccountText;
            }
        }

        public WinEdit UsernameEdit
        {
            get
            {
                if ((uiUsernameEdit == null))
                {
                    uiUsernameEdit = new WinEdit(this);
                    uiUsernameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "User name";
                }

                return uiUsernameEdit;
            }
        }

        public WinEdit PasswordEdit
        {
            get
            {
                if ((uiPasswordEdit == null))
                {
                    uiPasswordEdit = new WinEdit(this);
                    uiPasswordEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Password";
                }

                return uiPasswordEdit;
            }
        }

        public WinButton OkButton
        {
            get
            {
                if ((uiokButton == null))
                {
                    uiokButton = new WinButton(this);
                    uiokButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                }

                return uiokButton;
            }
        }

        public void Authenticate(string userName, string password)
        {
            if (UseAnotherAccountText.Exists)
            {
                Mouse.Click(UseAnotherAccountText);
            }

            UsernameEdit.Text = userName;
            PasswordEdit.Text = password;

            Mouse.Click(OkButton);
        }
    }
}
