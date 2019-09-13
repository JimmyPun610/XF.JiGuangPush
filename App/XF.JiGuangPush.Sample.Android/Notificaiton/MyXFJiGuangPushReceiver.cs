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
using XF.JiGuangPush.Droid;

namespace XF.JiGuangPush.Sample.Droid.Notificaiton
{
    [BroadcastReceiver(Name = "XF.JiGuangPush.Sample.Droid.Notificaiton.MyXFJiGuangPushReceiver")]
    public class MyXFJiGuangPushReceiver : XFJiGuangPushReceiver
    {
    }
}