using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Heroes5MapAPI.MapMiscDataStructures;

namespace Heroes5MapAPI.MapObjects
{
    public class Artifact : Item
    {
        #region Private Fields
        private Pos _pos;
        private decimal _rot;
        private int _floor;
        private string _name;
        private string _combatScriptHref;
        private List<PointLightsItem> _pointLights;    // TODO: redo pointLights implementation (like armySlots?)
        private string _sharedHref;
        private string _messageFileRefHref;
        private List<ArmySlotsItem> _armySlots;
        private string _spellId;
        private int _randomShiftRadius; // TODO: check if this is really an int.
        private bool _untransferable;
        #endregion

        #region Public Properties

        public List<PointLightsItem> PointLights
        {
            get { return _pointLights; }
            set { _pointLights = value; }
        }

        public string MessageFileRefHref
        {
            get { return _messageFileRefHref; }
            set { _messageFileRefHref = value; }
        }

        public static string InternalType
        {
            get { return "AdvMapArtifact"; }
        }

        public Pos Pos
        {
            get { return _pos; }
            set { _pos = value; }
        }

        public decimal Rot
        {
            get { return _rot; }
            set { _rot = value; }
        }

        public int Floor
        {
            get { return _floor; }
            set { _floor = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string CombatScriptHref
        {
            get { return _combatScriptHref; }
            set { _combatScriptHref = value; }
        }

        public string SharedHref
        {
            get { return _sharedHref; }
            set { _sharedHref = value; }
        }

        public List<ArmySlotsItem> ArmySlots
        {
            get { return _armySlots; }
            set { _armySlots = value; }
        }

        public string SpellId
        {
            get { return _spellId; }
            set { _spellId = value; }
        }

        public int RandomShiftRadius
        {
            get { return _randomShiftRadius; }
            set { _randomShiftRadius = value; }
        }

        public bool Untransferable
        {
            get { return _untransferable; }
            set { _untransferable = value; }
        }
        #endregion

        public Artifact()
        {
            this._armySlots = null;
            this._pointLights = null;
            this._combatScriptHref = string.Empty;
            this._floor = 0;
            this._name = string.Empty;
            this._pos = new Pos(0, 0, 0);
            this._randomShiftRadius = 0;
            this._rot = 0.0m;
            this._sharedHref = string.Empty;
            this._messageFileRefHref = string.Empty;
            this._spellId = string.Empty;
            this._untransferable = false;
            this.Href = string.Empty;
            this.Id = string.Empty;
        }
    }
}
