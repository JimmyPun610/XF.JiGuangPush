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
using CN.Jpush.Android.Service;
using XF.JiGuangPush.Droid;

namespace XF.JiGuangPush.Sample.Droid.Notificaiton
{
    [BroadcastReceiver(Name = "XF.JiGuangPush.Sample.Droid.Notificaiton.MyJPushMessageReceiver")]
    //public class MyJPushMessageReceiver : XFJiGuangPushMessageReceiver
    public class MyJPushMessageReceiver : XFJiGuangPushMessageReceiver
    {
        public override void OnNotifyMessageOpened(Context p0, NotificationMessage p1)
        {
            //Open your application before trigger the open action
            Intent i = new Intent(p0, typeof(MainActivity));
            i.AddFlags(ActivityFlags.SingleTop);
            Android.App.Application.Context.StartActivity(i);
            base.OnNotifyMessageOpened(p0, p1);
        }
    }
}