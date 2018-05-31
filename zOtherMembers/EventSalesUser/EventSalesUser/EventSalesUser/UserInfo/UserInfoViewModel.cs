using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace EventSalesUser
{
    public class UserInfoViewModel : ViewModelBase
    {
        public delegate void Alert(string txt);
        public event Alert OnAlert;

        UserInfoPage infoPage;

        public ICommand IBtnLogin { private set; get; }

        private bool bSingInBtnState;
        public bool SingInBtnState
        {
            private set { bSingInBtnState = value; }
            get { return bSingInBtnState; }
        }

        private bool bLoginBtnState;
        public bool LoginBtnState
        {
            private set { bLoginBtnState = value; }
            get { return bLoginBtnState; }
        }

        string sLoingStateText;
        public string LoginStateStr
        {
            private set { sLoingStateText = value; }
            get { return sLoingStateText; }
        }

        [DataContract]
        public class ResultDataUser
        {
            [DataMember(Name = "userIdCode")]
            public string sUserIdCode;

            [DataMember(Name = "userName")]
            public string sUserName;

            [DataMember(Name = "userNickName")]
            public string sUserNickName;
        }

        [DataContract]
        public class JUserData
        {
            [DataMember(Name = "completeDateTime")]
            public string sLoginTimer;

            [DataMember(Name = "resultCode")]
            public int nResultCode;

            [DataMember(Name = "resultMessage")]
            public string sResultMessage;

            [DataMember(Name = "resultMessage")]
            public string cResultMessage;
        }

        JUserData cUserDate;

        public void Init(UserInfoPage _page)
        {
            infoPage = _page;

            if (App.sApp.UserState == null)
            {
                return;
            }

            ChageState();

            SetCommands();
        }

        public void ChageState()
        {
            LoginBtnState = !App.sApp.UserState.BLogin;
            SingInBtnState = !App.sApp.UserState.BLogin;

            if (App.sApp.UserState.BLogin)
            {
                LoginStateStr = App.sApp.UserState.str_json;

                //cUserDate = JsonConvert.DeserializeObject<JUserData>(LoginStateStr);
            }
            else
            {
                LoginStateStr = "로그인 안함";
            }

            OnPropertyChanged("LoginStateStr");

            OnPropertyChanged("LoginBtnState");
            OnPropertyChanged("SingInBtnState");            
        }

        void SetCommands()
        {
            IBtnLogin = new Command(
                execute: () =>
                {
                    App.sApp.MsgView("로그인상태", "로그인 창 나와라 얍");

                    GoToLoginPage();
                });
        }

        public async void GoToLoginPage()
        {
            await infoPage.Navigation.PushModalAsync(new EventSalesUser.LoginPage(this));
        }

        public void LoginStateCheck()
        {
            if (bLoginBtnState)
            {
                //if(OnAlert != null)
                    //OnAlert("fsfdjf");
                App.sApp.MsgView("로그인상태", "로그인 중");
            }
            else
            {
                App.sApp.MsgView("로그인상태", "로그인 해야합니다.");
            }
        }

        //MVVM은 Page 권한이 없어서 경고문을 띄울수가 없는데 이렇게 연결을 해두면
        //자신과 연결된 Page를 알기 때문에 경고문을 띄울수 있다.
        /*
        public async void MsgView(string _str)
        {
            await infoPage.DisplayAlert("errer", _str, "OK");
        }
        */
    }
}
