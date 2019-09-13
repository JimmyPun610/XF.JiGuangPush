using System;
using System.Collections.Generic;
using System.Text;

namespace XF.JiGuangPush.Shared.Classes
{
    public class JOperationMessage
    {
        public string Alias { get; set; }
        public string CheckTag { get; set; }
        public int ErrorCode { get; set; }
        public string MobileNumber { get; set; }
        public JiGuangSequence Sequence { get; set; }
        public bool TagCheckOperator { get; set; }
        public bool TagCheckStateResult { get; set; }
        public List<string> Tags { get; set; }
    }
}
