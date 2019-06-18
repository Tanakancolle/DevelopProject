using System.IO;
using System.Collections.Generic;


namespace TemplateEditor.Sample
{
    public class SceneNamesProcessor : IProcessChain
    {
        private static readonly string[] ReplaceWords = {"Scenes"};

        #region IProcessChain implementation

        public void Process(ProcessMetadata metadata, ProcessDictionary result)
        {
            var list = new List<string>(UnityEditor.EditorBuildSettings.scenes.Length);
            foreach (var scene in UnityEditor.EditorBuildSettings.scenes)
            {
                list.Add(Path.GetFileNameWithoutExtension(scene.path));
            }

            result.Add(ReplaceWords[0], list);
        }

        public string[] GetReplaceWords()
        {
            return ReplaceWords;
        }

        public string GetDescription()
        {
            return "シーン名をリストで渡します";
        }

        #endregion
    }
}
