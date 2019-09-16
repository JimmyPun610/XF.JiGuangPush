using Newtonsoft.Json;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.JiGuangPush.Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            setupNotification();
        }

        private void setupNotification()
        {
            JiGuangPush.Shared.JPushInstance.Instance.OnMessageReceived  += Instance_OnMessageReceived;
            JiGuangPush.Shared.JPushInstance.Instance.OnMessageOpened += Instance_OnMessageOpened;
            JiGuangPush.Shared.JPushInstance.Instance.OnConnected += Instance_OnConnected;
            JiGuangPush.Shared.JPushInstance.Instance.OnRegistered += Instance_OnRegistered;
            JiGuangPush.Shared.JPushInstance.Instance.OnOperationResult += Instance_OnOperationResult;
            JiGuangPush.Shared.JPushInstance.Instance.Init(true);

            string id = JiGuangPush.Shared.JPushInstance.Instance.GetRegistrationId();
        }

        private void Instance_OnOperationResult(object sender, Shared.Classes.JOperationMessage e)
        {
            MainPage.DisplayAlert("OnOperationResult", JsonConvert.SerializeObject(e), "OK");
        }

        private void Instance_OnRegistered(object sender, string e)
        {
            MainPage.DisplayAlert("OnRegistered", e, "OK");
        }

        private void Instance_OnConnected(object sender, bool e)
        {
            MainPage.DisplayAlert("OnConnected", e.ToString(), "OK");
        }

        private void Instance_OnMessageOpened(object sender, Shared.Classes.JNotificationMessage e)
        {
            MainPage.DisplayAlert("OnMessageOpened", JsonConvert.SerializeObject(e), "OK");
        }

        private void Instance_OnMessageReceived(object sender, Shared.Classes.JNotificationMessage e)
        {
            MainPage.DisplayAlert("OnMessageReceived", JsonConvert.SerializeObject(e), "OK");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
