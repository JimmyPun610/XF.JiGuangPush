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

namespace XF.JiGuangPush.Droid
{
    [BroadcastReceiver]
    public class XFJiGuangPushReceiver : PushReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            base.OnReceive(context, intent);
            if (intent.Action == JPushInterface.ActionNotificationOpened)
            {
                //When user tap the notification on notification center
                Bundle bundle = intent.Extras;
                string jsonData = bundle.GetString(JPushInterface.ExtraExtra);
            }

            if(intent.Action == JPushInterface.ActionMessageReceived)
            {
                //When user tap the notification on notification center
                Bundle bundle = intent.Extras;
                string jsonData = bundle.GetString(JPushInterface.ExtraExtra);
                
            }

            if (intent.Action == JPushInterface.ActionRegistrationId)
            {
                //Only call when first launch, get the registrationID
                string regID = JPushInterface.GetRegistrationID(context);
            }

            if(intent.Action == JPushInterface.ActionConnectionChange)
            {
                Bundle bundle = intent.Extras;
                string jsonData = bundle.GetString(JPushInterface.ExtraExtra);
                string s = JPushInterface.GetRegistrationID(context);
            }
        }
    }
}