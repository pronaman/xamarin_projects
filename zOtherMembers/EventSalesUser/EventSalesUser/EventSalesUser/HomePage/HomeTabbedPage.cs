using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EventSalesUser
{
    // 탭 페이지로 메인 홈페이지.
	public class HomeTabbedPage : TabbedPage
    {
        ShopListPage shopListPage;
        UserInfoPage infoPage;

        public HomeTabbedPage ()
		{
            Title = "HomePage";
            InitPage();
        }

        public void InitPage()
        {
            shopListPage = new ShopListPage();
            infoPage = new UserInfoPage();

            Children.Add(shopListPage);
            Children.Add(infoPage);

            CurrentPageChanged += MainPage_CurrentPageChanged;
        }

        // 탭 페이지 이동으로 보여지는 페이지가 바뀌게 되었을때 작동하는 녀석.
        private void MainPage_CurrentPageChanged(object sender, EventArgs e)
        {
            if (CurrentPage != null)
            {
                if(CurrentPage.Title.Equals("내 정보"))
                {
                    infoPage.PageChageed();
                }
            }
        }

    }
}