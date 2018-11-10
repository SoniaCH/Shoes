using Xamarin.Forms;

namespace Shoes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            
            SetFontSize();
        }
        public void SetFontSize()
        {
            var SmallFont = App.ScreenWidth / 30;
            ProductDiscrp.FontSize = SmallFont;
            Productname.FontSize = SmallFont;
            ProductSize.FontSize = SmallFont;
            sellerAdress.FontSize = SmallFont;
            sellerAge.FontSize = SmallFont;
            sellerName.FontSize = SmallFont;
            abtSeller.FontSize = SmallFont;
            var common = App.ScreenHeight / 12;
            btnMore.FontSize = SmallFont;
            btnMore.HeightRequest = common;
            btnReport.FontSize = SmallFont;
            btnReport.HeightRequest = common;
            var margin = App.ScreenWidth / 45;
            if (Device.RuntimePlatform == Device.iOS)
            {
                btnMore.CornerRadius = (int)(App.ScreenHeight / 34);
                btnReport.CornerRadius = (int)(App.ScreenHeight / 34);
                btnSend.CornerRadius = (int)(App.ScreenHeight / 34);
                receiverLabel.HeightRequest = common/2;
                sentLabel.HeightRequest = common/2;
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                btnMore.CornerRadius = (int)(common);
                btnReport.CornerRadius = (int)(common);
                btnSend.CornerRadius = (int)(common);
            }
            SellerInfoStack.HeightRequest = App.ScreenHeight / 6.8;
            SellerInfoStack.ColumnSpacing = App.ScreenHeight / 43;
            SellerInfoStack.RowSpacing = App.ScreenHeight / 30;
            receiverDatelabel.FontSize = SmallFont;
            receiverLabel.FontSize = SmallFont;
            sentDatelabel.FontSize = SmallFont;
            sentLabel.FontSize = SmallFont;
            emiticon.Margin = margin;
            btnSend.Margin = margin/1.5;
            btnSend.WidthRequest =App.ScreenWidth/5;
            btnSend.FontSize = SmallFont;
            btnSend.Padding = 0;
            msg.FontSize = SmallFont;
        }
    }
}
