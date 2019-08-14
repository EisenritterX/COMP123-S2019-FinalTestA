/*
 * STUDENT NAME: QIAN LONG (GEORGE) ZHOU
 * STUDENT ID: 300613283
 * DESCRIPTION: This is the Hero Generator Form
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the Next Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        /// <summary>
        /// This is the event handler for the Back Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }

        }
        /// <summary>
        /// Open Character Sheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            CharacterSheetOpenFileDialog.FileName = "CharacterSheet.txt";
            CharacterSheetOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterSheetOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files{*.*)|*.*";

            //open the file dialog
            var result = CharacterSheetOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //Open the stream for reading
                    using (StreamReader inputStream = new StreamReader(File.Open(CharacterSheetOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //Read from file
                        //Physical Ability
                        Program.hero.Fighting = inputStream.ReadLine();
                        Program.hero.Agility = inputStream.ReadLine();
                        Program.hero.Strength = inputStream.ReadLine();
                        Program.hero.Endurance = inputStream.ReadLine();
                        //Mental Abillity
                        Program.hero.Reason = inputStream.ReadLine();
                        Program.hero.Intuition = inputStream.ReadLine();
                        Program.hero.Psyche = inputStream.ReadLine();
                        Program.hero.Popularity = inputStream.ReadLine();
                        //Clean up
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("ERROR" + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Saving Character Sheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            CharacterSheetSaveFileDialog.FileName = "CharacterSheet.txt";
            CharacterSheetSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterSheetSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files{*.*)|*.*";

            //open the file dialog
            var result = CharacterSheetSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //open the stream for writing
                using (StreamWriter outputStream = new StreamWriter(File.Open(CharacterSheetSaveFileDialog.FileName, FileMode.Create)))
                {
                    //Write to File
                    //Physical Ability
                    outputStream.WriteLine(Program.hero.Fighting);
                    outputStream.WriteLine(Program.hero.Agility);
                    outputStream.WriteLine(Program.hero.Strength);
                    outputStream.WriteLine(Program.hero.Endurance);
                    //Mental Ability
                    outputStream.WriteLine(Program.hero.Reason);
                    outputStream.WriteLine(Program.hero.Intuition);
                    outputStream.WriteLine(Program.hero.Psyche);
                    outputStream.WriteLine(Program.hero.Popularity);
                    //cleanup
                    outputStream.Close();
                    outputStream.Dispose();

                    //Give feedback to the user that the file has been saved
                    MessageBox.Show("File Saved...", "Saving File...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            using (StreamReader inputStream = new StreamReader(@"Data\powers.txt"))
            {

            }
            
        }
    }
}
