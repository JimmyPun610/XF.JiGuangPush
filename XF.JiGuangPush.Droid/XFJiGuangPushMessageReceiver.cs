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
using XF.JiGuangPush.Shared.Classes;

namespace XF.JiGuangPush.Droid
{
    [BroadcastReceiver]
    public class XFJiGuangPushMessageReceiver : JPushMessageReceiver
    {
        public override void OnRegister(Context p0, string p1)
        {
            base.OnRegister(p0, p1);
        }

        public override void OnConnected(Context p0, bool p1)
        {
            base.OnConnected(p0, p1);
         
        }

        public override void OnTagOperatorResult(Context p0, JPushMessage p1)
        {
            base.OnTagOperatorResult(p0, p1);
            JOperationMessage jOperationMessage = new JOperationMessage
            {
                Alias = p1.Alias,
                Sequence = (Shared.JiGuangSequence)p1.Sequence,
                TagCheckStateResult = p1.TagCheckStateResult,
                CheckTag = p1.CheckTag,
                ErrorCode = p1.ErrorCode,
                MobileNumber = p1.MobileNumber,
                TagCheckOperator = p1.TagCheckOperator,
                Tags = p1.Tags.ToList()
            };
            JiGuangPush.Shared.JPushInstance.Instance.TriggerOnOperationResult(jOperationMessage);
        }

        public override void OnAliasOperatorResult(Context p0, JPushMessage p1)
        {
            base.OnAliasOperatorResult(p0, p1);
            JOperationMessage jOperationMessage = new JOperationMessage
            {
                Alias = p1.Alias,
                Sequence = (Shared.JiGuangSequence)p1.Sequence,
                TagCheckStateResult = p1.TagCheckStateResult,
                CheckTag = p1.CheckTag,
                ErrorCode = p1.ErrorCode,
                MobileNumber = p1.MobileNumber,
                TagCheckOperator = p1.TagCheckOperator,
                Tags = p1.Tags.ToList()
            };
            JiGuangPush.Shared.JPushInstance.Instance.TriggerOnOperationResult(jOperationMessage);

        }

        public override void OnNotifyMessageArrived(Context p0, NotificationMessage p1)
        {
            base.OnNotifyMessageArrived(p0, p1);
            JNotificationMessage jNotificationMessage = new JNotificationMessage
            {
                Category = p1.NotificationCategory,
                ChannelId = p1.NotificationChannelId,
                Content = p1.NotificationContent,
                Extras = p1.NotificationExtras,
                Title = p1.NotificationTitle
            };
            JiGuangPush.Shared.JPushInstance.Instance.TriggerOnMessageReceived(jNotificationMessage);
            
        }

     

        public override void OnNotifyMessageOpened(Context p0, NotificationMessage p1)
        {
            base.OnNotifyMessageOpened(p0, p1);
            JNotificationMessage jNotificationMessage = new JNotificationMessage
            {
                Category = p1.NotificationCategory,
                ChannelId = p1.NotificationChannelId,
                Content = p1.NotificationContent,
                Extras = p1.NotificationExtras,
                Title = p1.NotificationTitle
            };
            JiGuangPush.Shared.JPushInstance.Instance.TriggerOnMessageOpened(jNotificationMessage);
        }
    }
}
