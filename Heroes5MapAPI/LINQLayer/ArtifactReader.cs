using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Heroes5MapAPI.MapObjects;
using Heroes5MapAPI.MapMiscDataStructures;

namespace Heroes5MapAPI.LINQLayer
{
    public class ArtifactReader
    {
        private XElement _root;

        public ArtifactReader(string mapFile)
        {
            this._root = XElement.Load(mapFile);
        }

        public List<Artifact> GetArtifacts()
        {
            List<Artifact> artifacts = new List<Artifact>();

            IEnumerable<XElement> items =
                from linqItems in this._root.Elements("objects").Elements()
                where (bool)linqItems.FirstAttribute.Value.Contains(Artifact.InternalType)
                select linqItems;

            foreach (XElement linqItem in items)
            {
                Artifact artifact = new Artifact();
                artifact = this.BuildArtifactFromXElement(artifact, linqItem);
                artifacts.Add(artifact);
            }

            return artifacts;
        }

        private Pos BuildPosFromXElements(IEnumerable<XElement> linqPosElements)
        {
            Pos pos = new Pos();
            foreach (XElement linqPosElement in linqPosElements)
            {
                pos.X = Convert.ToInt16(linqPosElement.Element("x").Value);
                pos.Y = Convert.ToInt16(linqPosElement.Element("y").Value);
                pos.Z = Convert.ToInt16(linqPosElement.Element("z").Value);
            }

            return pos;
        }

        private Color BuildColorFromXElements(IEnumerable<XElement> linqColorElements)
        {
            Color color = new Color();
            foreach (XElement linqColorElement in linqColorElements)
            {
                color.X = Convert.ToDecimal(linqColorElement.Element("x").Value);
                color.Y = Convert.ToDecimal(linqColorElement.Element("y").Value);
                color.Z = Convert.ToDecimal(linqColorElement.Element("z").Value);
            }

            return color;
        }

        private List<ArmySlotsItem> BuildArmySlotsFromXElements(IEnumerable<XElement> linqArmySlotsElements)
        {
            List<ArmySlotsItem> armySlots = new List<ArmySlotsItem>();
            foreach (XElement linqArtifactArmySlotsItem in linqArmySlotsElements)
            {
                ArmySlotsItem slotItem = new ArmySlotsItem();
                slotItem.Creature = linqArtifactArmySlotsItem.Element("Creature").Value;
                slotItem.Count = Convert.ToInt16(linqArtifactArmySlotsItem.Element("Count").Value);
                armySlots.Add(slotItem);
            }

            return armySlots;
        }

        private List<PointLightsItem> BuildPointLightsFromXEelements(IEnumerable<XElement> linqPointLightsElements)
        {
            List<PointLightsItem> pointLightsItems = new List<PointLightsItem>();
            foreach (XElement linqArtifactPointLightsItem in linqPointLightsElements)
            {
                PointLightsItem pointLightsItem = new PointLightsItem();
                pointLightsItem.Pos = this.BuildPosFromXElements(linqArtifactPointLightsItem.Elements("Pos"));
                pointLightsItem.Color = this.BuildColorFromXElements(linqArtifactPointLightsItem.Elements("Color"));
                pointLightsItem.Radius = Convert.ToInt16(linqArtifactPointLightsItem.Element("Radius").Value);
                pointLightsItems.Add(pointLightsItem);
            }

            return pointLightsItems;
        }

        private Artifact BuildArtifactFromXElement(Artifact artifact, XElement linqItem)
        {
            artifact.Href = linqItem.FirstAttribute.Value;
            artifact.Id = linqItem.LastAttribute.Value;

            IEnumerable<XElement> linqArtifacts = linqItem.Elements(Artifact.InternalType);
            foreach (XElement linqArtifact in linqArtifacts)
            {
                artifact.Rot = Convert.ToDecimal(linqArtifact.Element("Rot").Value);
                artifact.Floor = Convert.ToInt16(linqArtifact.Element("Floor").Value);
                artifact.Name = linqArtifact.Element("Name").Value;
                if (linqArtifact.Element("CombatScript").HasAttributes)
                {
                    artifact.CombatScriptHref = linqArtifact.Element("CombatScript").FirstAttribute.Value;
                }
                artifact.SharedHref = linqArtifact.Element("Shared").FirstAttribute.Value;
                artifact.SpellId = linqArtifact.Element("spellID").Value;
                artifact.MessageFileRefHref = linqArtifact.Element("MessageFileRef").FirstAttribute.Value;
                artifact.RandomShiftRadius = Convert.ToInt16(linqArtifact.Element("RandomShiftRadius").Value);
                artifact.Untransferable = Convert.ToBoolean(linqArtifact.Element("untransferable").Value);
                artifact.Pos = this.BuildPosFromXElements(linqArtifact.Elements("Pos"));
                if (linqArtifact.Element("armySlots").Elements().Count() > 0)
                {
                    artifact.ArmySlots = this.BuildArmySlotsFromXElements(linqArtifact.Element("armySlots").Elements());
                }
                if (linqArtifact.Element("pointLights").Elements().Count() > 0)
                {
                    artifact.PointLights = this.BuildPointLightsFromXEelements(linqArtifact.Element("pointLights").Elements());
                }
            }

            return artifact;
        }

        public Artifact GetArtifactById(string id)
        {
            Artifact artifact = null;
            if (this._root != null)
            {
                
            }

            return artifact;
        }
    }
}
