using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CN.Jpush.Android.Api;
using XF.JiGuangPush.Droid;
using XF.JiGuangPush.Shared;

[assembly: Xamarin.Forms.Dependency(typeof(Methods))]
namespace XF.JiGuangPush.Droid
{
    public class Methods : IMethods
    {
        public void Init(bool debugMode)
        {
            JPushInterface.SetDebugMode(debugMode);
            JPushInterface.Init(Android.App.Application.Context);
        }

        public string GetRegistrationId()
        {
            return JPushInterface.GetRegistrationID(Android.App.Application.Context);
            
        }

        public void SetAlias(JiGuangSequence sequence, string alias)
        {
            JPushInterface.SetAlias(Android.App.Application.Context, (int)sequence, alias);
        }

        public void DeleteAlias(JiGuangSequence sequence)
        {
            JPushInterface.DeleteAlias(Android.App.Application.Context, (int)sequence);
        }

        public void GetAlias(JiGuangSequence sequence)
        {
            JPushInterface.GetAlias(Android.App.Application.Context, (int)sequence);
        }

        public void SetTags(JiGuangSequence sequence, List<string> tags)
        {
            JPushInterface.SetTags(Android.App.Application.Context, (int)sequence, tags);
        }

        public void AddTags(JiGuangSequence sequence, List<string> tags)
        {
            JPushInterface.AddTags(Android.App.Application.Context, (int)sequence, tags);
        }

        public void DeleteTags(JiGuangSequence sequence, List<string> tags)
        {
            JPushInterface.DeleteTags(Android.App.Application.Context, (int)sequence, tags);
        }

        public void CleanTags(JiGuangSequence sequence)
        {
            JPushInterface.CleanTags(Android.App.Application.Context, (int)sequence);
        }

        public void GetAllTags(JiGuangSequence sequence)
        {
            JPushInterface.GetAllTags(Android.App.Application.Context, (int)sequence);
        }

        public void SetChannel(string channel)
        {
            JPushInterface.SetChannel(Android.App.Application.Context, channel);
        }

        public void ClearAllNotification()
        {
            JPushInterface.ClearAllNotifications(Android.App.Application.Context);
        }

        public void ClearNotifcation(int notificationId)
        {
            JPushInterface.ClearNotificationById(Android.App.Application.Context, notificationId);
        }
    }
}