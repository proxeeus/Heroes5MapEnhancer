using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes5MapAPI.MapscriptGen.Scripting
{
    public class Trigger
    {
        private List<string> _parameters;
        private Type _type;

        public enum Type
        {
            NEW_DAY_TRIGGER,
            WAR_FOG_EVENT_TRIGGER,
            PLAYER_ADD_HERO_TRIGGER,
            PLAYER_REMOVE_HERO_TRIGGER,
            OBJECTIVE_STATE_CHANGE_TRIGGER,
            OBJECT_CAPTURE_TRIGGER,
            OBJECT_TOUCH_TRIGGER,
            TOWN_HERO_DEPLOY_TRIGGER,
            REGION_ENTER_AND_STOP_TRIGGER,
            REGION_ENTER_WITHOUT_STOP_TRIGGER,
            HERO_LEVELUP_TRIGGER
        }

        public List<string> Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }

        public Trigger(Type type)
        {
            this._type = type;
            this._parameters = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder baseTrigger = new StringBuilder();
            baseTrigger.Append(string.Format(@"Trigger({0},", this._type.ToString()));
            foreach (string param in this._parameters)
            {
                baseTrigger.Append("\""+param+"\",");
            }
            baseTrigger.Append(");\n");
            string trigger = baseTrigger.ToString();
            trigger = trigger.Remove(trigger.LastIndexOf(','), 1);
            return trigger ;
        }
    }
}
