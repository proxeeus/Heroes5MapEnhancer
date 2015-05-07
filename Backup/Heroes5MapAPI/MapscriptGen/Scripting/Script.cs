using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Heroes5MapAPI.LINQLayer;
using Heroes5MapAPI.MapObjects;
using Heroes5MapEnhancerDAL;

namespace Heroes5MapAPI.MapscriptGen.Scripting
{
    public class Script
    {
        private string _mapXDBPath;
        private List<Trigger> _triggers;

        public Script(string mapXDBPath)
        {
            this._triggers = new List<Trigger>();
            this._mapXDBPath = mapXDBPath;
        }

        public void GenerateScript()
        {
            this.Generate_OBJECT_TOUCH_Triggers();
        }

        private void Generate_OBJECT_TOUCH_Triggers()
        {
            ArtifactReader artifactReader = new ArtifactReader(this._mapXDBPath);
            List<Artifact> artifacts = artifactReader.GetArtifacts();

            int triggerCounter = 0;

            foreach (Artifact artifact in artifacts)
            {
                foreach (DArtifact dArtifact in Database.Instance.Artifacts)
                {
                    if(artifact.SharedHref.ToLower().Contains(dArtifact.Id.ToLower()))
                    {
                        Trigger trigger = new Trigger(Trigger.Type.OBJECT_TOUCH_TRIGGER);
                        if (artifact.Name == string.Empty)
                            artifact.Name = dArtifact.Id.ToLower() + triggerCounter.ToString();
                        triggerCounter++;
                        string functionName = string.Concat(dArtifact.Id,"_MsgBox");
                        trigger.Parameters.Add(artifact.Name);
                        trigger.Parameters.Add(functionName);

                        this._triggers.Add(trigger);
                    }
                }
            }

        }

        public override string ToString()
        {
            StringBuilder fullScript = new StringBuilder();
            foreach (Trigger trigger in this._triggers)
            {
                fullScript.Append(trigger.ToString() + "\n");
            }

            return fullScript.ToString();
        }
    }
}
