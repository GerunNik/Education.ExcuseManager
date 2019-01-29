using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcuseManager
{
    public partial class Form1 : Form
    {
        Excuse mostRecentSave = new Excuse();
        public Form1()
        {
            InitializeComponent();
            updateButtons();
        }
        void updateMostRecentSave()
        {
            mostRecentSave.Explanation = txt_Excuse.Text;
            mostRecentSave.Reaction = txt_Reaction.Text;
            mostRecentSave.DataDate = txt_Date.Text;
            mostRecentSave.LastUsed = datePicker_lastUsed.Text;
        }
        void updateButtons()
        {
            if (Excuse.Path == string.Empty)
            {
                btn_Save.Enabled = false;
                btn_Open.Enabled = false;
                btn_quickExcuse.Enabled = false;
                btn_LoadSerializable.Enabled = false;
                btn_Serialize.Enabled = false;
            }
            else
            {
                btn_Save.Enabled = true;
                btn_Open.Enabled = true;
                btn_quickExcuse.Enabled = true;
                btn_LoadSerializable.Enabled = true;
                btn_Serialize.Enabled = true;
            }
        }

        private void btn_Directory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Explorer = new FolderBrowserDialog();
            Explorer.ShowDialog();
            Excuse.Path = Explorer.SelectedPath;

            updateButtons();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveExcuse = new SaveFileDialog();
            saveExcuse.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveExcuse.InitialDirectory = Excuse.Path;
            
            if (saveExcuse.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveExcuse.FileName, txt_Excuse.Text + "\n" + txt_Reaction.Text + "\n" + txt_Date.Text + "\n" + datePicker_lastUsed.Text);
            }

            updateMostRecentSave();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openExcuse = new OpenFileDialog();
            openExcuse.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openExcuse.InitialDirectory = Excuse.Path;

            string openText = string.Empty;
            if (openExcuse.ShowDialog() == DialogResult.OK)
            {
                openText = File.ReadAllText(openExcuse.FileName);
            }

            string[] fillFields = openText.Split('\n');

            txt_Excuse.Text = fillFields[0];
            txt_Reaction.Text = fillFields[1];
            txt_Date.Text = fillFields[2];
            datePicker_lastUsed.Text = fillFields[3];

            updateMostRecentSave();
        }

        private void btn_quickExcuse_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int subject = r.Next(6);
            int incident = r.Next(4);

            if (subject == (int)Nouns.Dog)
            {
                txt_Excuse.Text = "Mein Hund ";
            }
            else if (subject == (int)Nouns.Wife)
            {
                txt_Excuse.Text = "Meine Frau ";
            }
            else if (subject == (int)Nouns.Cat)
            {
                txt_Excuse.Text = "Meine Katze ";
            }
            else if (subject == (int)Nouns.Child)
            {
                txt_Excuse.Text = "Mein Kind ";
            }
            else if (subject == (int)Nouns.Father)
            {
                txt_Excuse.Text = "Mein Vater ";
            }
            else if (subject == (int)Nouns.Mother)
            {
                txt_Excuse.Text = "Meine Mutter ";
            }

            if (incident == (int)Incident.Leg)
            {
                txt_Excuse.Text += "hat sich das Bein gebrochen.";
            }
            else if (incident == (int)Incident.Head)
            {
                txt_Excuse.Text += "hat Kopfschmerzen.";
            }
            else if (incident == (int)Incident.Fever)
            {
                txt_Excuse.Text += "hat Fieber.";
            }
            else if (incident == (int)Incident.Stomach)
            {
                txt_Excuse.Text += "hat Bauchschmerzen.";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Excuse currentExcuse = new Excuse();

            currentExcuse.Explanation = txt_Excuse.Text;
            currentExcuse.Reaction = txt_Reaction.Text;
            currentExcuse.DataDate = txt_Date.Text;
            currentExcuse.LastUsed = datePicker_lastUsed.Text;

            if (!Excuse.checkSavedExcuse(mostRecentSave, currentExcuse))
            {
                if (MessageBox.Show("Die neuesten Änderungen wurden noch nicht gesichert, möchtest du diese Speichern?",
                    "Ungesicherte Änderungen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
                {
                    btn_Save_Click(new object(), new EventArgs());
                }
            }
        }

        private void btn_Serialize_Click(object sender, EventArgs e)
        {
            Excuse serializeObject = new Excuse();
            serializeObject.Explanation = txt_Excuse.Text;
            serializeObject.Reaction = txt_Reaction.Text;
            serializeObject.DataDate = txt_Date.Text;
            serializeObject.LastUsed = datePicker_lastUsed.Text;

            IFormatter formatter = new BinaryFormatter();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None);

                formatter.Serialize(stream, serializeObject);
                stream.Close();
            }
        }

        private void btn_LoadSerializable_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Excuse.Path;
            dialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                Excuse obj = (Excuse)formatter.Deserialize(stream);
                stream.Close();
                txt_Excuse.Text = obj.Explanation;
                txt_Reaction.Text = obj.Reaction;
                txt_Date.Text = obj.DataDate;
                datePicker_lastUsed.Text = obj.LastUsed;
                updateMostRecentSave();
            }
        }
    }
}
