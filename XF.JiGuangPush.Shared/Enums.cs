using System;
using System.Collections.Generic;
using System.Text;

namespace XF.JiGuangPush.Shared
{
    public enum JiGuangSequence
    {
        SetAlias = 30000,
        DeleteAlias = 30001,
        GetAlias = 30002,
        SetTags = 40000,
        AddTags = 40001,
        DeleteTags = 40002,
        CleanTags = 40003,
        GetAllTags = 40004
    }
}
