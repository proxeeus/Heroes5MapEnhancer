using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Heroes5MapAPI.LINQLayer;
using Heroes5MapAPI.MapObjects;
using System.IO;
using System.Xml.Serialization;
using Heroes5MapEnhancerDAL;

namespace Heroes5MapEnhancer
{
    public partial class MainForm : Form
    {
        private Database _database = null;
        private DArtifact _selectedArtifact = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void artifactsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<DArtifact> items =
                 from artifactItem in this._database.Artifacts
                 where (bool)artifactItem.Id.Equals(artifactsComboBox.SelectedItem.ToString())
                 select artifactItem;

            foreach (DArtifact artifact in items)
            {
                artifactSoundTextBox.Text = artifact.Sound;
                foreach (string text in artifact.Texts)
                {
                    artifactTextsListBox.Items.Add(text);
                }
                _selectedArtifact = artifact;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("Database.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Database));
                _database = (Database)serializer.Deserialize(reader);
            }
            using (StreamWriter writer = new StreamWriter("Database.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Database));
                serializer.Serialize(writer, _database);
            }

            foreach (DArtifact artifact in _database.Artifacts)
            {
                artifactsComboBox.Items.Add(artifact.Id);
            }
        }
    }
}
