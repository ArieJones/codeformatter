﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.DotNet.CodeFormatting
{
    static class RuleTypeConstants
    {
        public const string PartMetadataKey = "RuleType";

        public const string FormatCodeRuleType = "FormatCode";
        public const string ConvertTestsRuleType = "ConvertTests";        
    }
}