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

namespace XF.JiGuangPush.Sample.Droid.Notificaiton
{
    [Service(Name = "XF.JiGuangPush.Sample.Droid.Notificaiton.MyJCommonService")]
    public class MyJCommonService : JiGuangPush.Droid.XFJiGuangCommonService
    {
    }
}