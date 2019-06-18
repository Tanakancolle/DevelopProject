using System.IO;
using System.Collections.Generic;
using UnityEditorInternal;

namespace TemplateEditor.Sample
{
    public class TagNamesProcessor : IProcessChain
    {
        private static readonly string[] ReplaceWords = {"Tags"};

        #region IProcessChain implementation

        public void Process(ProcessMetadata metadata, ProcessDictionary result)
        {
            var list = new List<string>(InternalEditorUtility.tags.Length);
            foreach (var tag in InternalEditorUtility.tags)
            {
                list.Add(tag);
            }

            result.Add(ReplaceWords[0], list);
        }

        public string[] GetReplaceWords()
        {
            return ReplaceWords;
        }

        public string GetDescription()
        {
            return "Set unity tags";
        }

        #endregion
    }
}
