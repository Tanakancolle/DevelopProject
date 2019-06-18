using UnityEditor;
using System.IO;
using System.Collections.Generic;

namespace TemplateEditor
{
    public class ProcessChainSampleProcessor : IProcessChain
    {
        private static readonly string[] ReplaceWords =
        {
            "ProcessChainSample",
        };

        public void Process(ProcessMetadata metadata, ProcessDictionary result)
        {
            result.Add(ReplaceWords[0], "Test");
        }

        public string[] GetReplaceWords()
        {
            return ReplaceWords;
        }

        public string GetDescription()
        {
            return "Set 'Replace Word'";
        }
    }
}
