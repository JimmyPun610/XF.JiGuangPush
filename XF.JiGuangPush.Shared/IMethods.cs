using System;
using System.Collections.Generic;
using System.Text;

namespace XF.JiGuangPush.Shared
{
    public interface IMethods
    {
        void Init(bool debugMode);
        string GetRegistrationId();

        void SetAlias(JiGuangSequence sequence, string alias);

        void DeleteAlias(JiGuangSequence sequence);

        void GetAlias(JiGuangSequence sequence);

        void SetTags(JiGuangSequence sequence, List<string> tags);

        void AddTags(JiGuangSequence sequence, List<string> tags);

        void DeleteTags(JiGuangSequence sequence, List<string> tags);

        void CleanTags(JiGuangSequence sequence);

        void GetAllTags(JiGuangSequence sequence);

        void SetChannel(string channel);

        void ClearAllNotification();

        void ClearNotifcation(int notificationId);
    }
}
