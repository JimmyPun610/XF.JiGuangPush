using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XF.JiGuangPush.Shared.Classes;

namespace XF.JiGuangPush.Shared
{
    public class JPushInstance
    {
        private static JPushInstance _instance { get; set; }
        public static JPushInstance Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new JPushInstance();
                return _instance;
            }
        }
        
        public event EventHandler<JNotificationMessage> OnMessageReceived;
        public event EventHandler<JNotificationMessage> OnMessageOpened;
        public event EventHandler<JOperationMessage> OnOperationResult;
        public event EventHandler<bool> OnConnected;
        public event EventHandler<string> OnRegistered;

        #region Event
        public void TriggerOnRegistered(string regId)
        {
            OnRegistered?.Invoke(this, regId);
        }

        public void TriggerOnConnected(bool isConnected)
        {
            OnConnected?.Invoke(this, isConnected);
        }

        public void TriggerOnOperationResult(JOperationMessage jOperationMessage)
        {
            OnOperationResult?.Invoke(this, jOperationMessage);
        }
        public void TriggerOnMessageReceived(JNotificationMessage jNotificationMessage)
        {
            OnMessageReceived?.Invoke(this, jNotificationMessage);
        }
        public void TriggerOnMessageOpened(JNotificationMessage jNotificationMessage)
        {
            OnMessageOpened?.Invoke(this, jNotificationMessage);
        }

        #endregion


        #region Function
        public void Init(bool debugMode)
        {
            DependencyService.Get<IMethods>().Init(debugMode);
        }
        public string GetRegistrationId()
        {
            return DependencyService.Get<IMethods>().GetRegistrationId();
        }

        public void SetAlias(JiGuangSequence sequence, string alias)
        {
            DependencyService.Get<IMethods>().SetAlias(sequence, alias);
        }

        public void DeleteAlias(JiGuangSequence sequence)
        {
            DependencyService.Get<IMethods>().DeleteAlias(sequence);
        }

        public void GetAlias(JiGuangSequence sequence)
        {
            DependencyService.Get<IMethods>().GetAlias(sequence);
        }

        public void SetTags(JiGuangSequence sequence, List<string> tags)
        {
            DependencyService.Get<IMethods>().SetTags(sequence, tags);
        }

        public void AddTags(JiGuangSequence sequence, List<string> tags)
        {
            DependencyService.Get<IMethods>().AddTags(sequence, tags);
        }

        public void DeleteTags(JiGuangSequence sequence, List<string> tags)
        {
            DependencyService.Get<IMethods>().DeleteTags(sequence, tags);
        }

        public void CleanTags(JiGuangSequence sequence)
        {
            DependencyService.Get<IMethods>().CleanTags(sequence);
        }

        public void GetAllTags(JiGuangSequence sequence)
        {
            DependencyService.Get<IMethods>().GetAllTags(sequence);
        }

        public void SetChannel(string channel)
        {
            DependencyService.Get<IMethods>().SetChannel(channel);
        }


        public void ClearAllNotification()
        {
            DependencyService.Get<IMethods>().ClearAllNotification();
        }

        public void ClearNotifcation(int notificationId)
        {
            DependencyService.Get<IMethods>().ClearNotifcation(notificationId);
        }
        #endregion
    }
}
