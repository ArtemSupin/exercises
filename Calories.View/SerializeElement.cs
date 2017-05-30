using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories.View
{
    [Serializable]
    static class SerializeElement
    {
        private static BinaryFormatter formatter = new BinaryFormatter();

        public static void Serilization(CaloriesProject caloriesProject)
        {
            string filename = string.Empty;
            var saveFileDilog = new SaveFileDialog();
            saveFileDilog.Filter = @"txt files (*.ex)|*.ex";
            saveFileDilog.RestoreDirectory = true;
            if (saveFileDilog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDilog.FileName;
            }
            else
            {
                return;
            }
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, caloriesProject);
            }
        }

        public static CaloriesProject Deserilization()
        {
            string filename = string.Empty;
            var openFileDilog = new OpenFileDialog();
            if (openFileDilog.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDilog.FileName;
            }
            else
            {
                return null;
            }

            if (!filename.EndsWith("ex"))
            {
                MessageBox.Show(@"Wrong format");
                return null;
            }
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                var caloriesProject = (CaloriesProject)formatter.Deserialize(fs);
                return caloriesProject;
            }
        }
    }
}
