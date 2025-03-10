using System.Collections.ObjectModel;
using System.IO;
using System.Security;
using System.Text.Json;
using System.Threading;
using Newtonsoft.Json;

namespace LLModpackCreator
{
    public partial class Form1 : Form
    {
        public string PathToMinecraft = @"%AppData%\.tlauncher\legacy\Minecraft\game";
        public string PathToLLVD = @"LLVD";
        private string VersionSelected = "";
        private string VersionName = "";
        private bool isCreating = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void load_versions()
        {
            VersionsBox.Items.Clear();
            // поиск версий
            PathToMinecraft = Environment.ExpandEnvironmentVariables(PathToMinecraft);
            var directory = new DirectoryInfo(PathToMinecraft + "\\versions");
            if (directory.Exists)
            {
                DirectoryInfo[] dirs = directory.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                    if (File.Exists(dir.FullName+$"\\{dir.Name}.jar"))
                    {
                        VersionsBox.Items.Add(dir.Name);
                    }
                }
            }
            else
            {
                StatusLabel.Text = "Выберите путь до папки с майнкрафтом!";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // запуск
            if (!Directory.Exists(PathToLLVD))
            {
                Directory.CreateDirectory(PathToLLVD);
                var FirstSettingForm = new FirstSetting();
                FirstSettingForm.Show();
                File.Create(PathToLLVD + "\\save.txt").Close();
                File.WriteAllText(PathToLLVD + "\\save.txt", PathToMinecraft);
            }
            else
            {
                PathToMinecraft = File.ReadAllText(PathToLLVD + "\\save.txt");
            }
            load_versions();
            PathToMinecraftBox.Text = PathToMinecraft;
        }

        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive, string replaceble_string = "", string new_replaced_string = "", bool only_main_replace = true)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string file_name = file.Name;
                if (replaceble_string != "" && new_replaced_string != "" && only_main_replace)
                {
                    string targetFilePath = Path.Combine(destinationDir, file_name.Replace(replaceble_string, new_replaced_string));
                    file.CopyTo(targetFilePath);
                }
                else
                {
                    string targetFilePath = Path.Combine(destinationDir, file_name);
                    file.CopyTo(targetFilePath);
                }
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    if (only_main_replace)
                    {
                        CopyDirectory(subDir.FullName, newDestinationDir, true, "", "", true);
                    }
                    else
                    {
                        CopyDirectory(subDir.FullName, newDestinationDir, true, replaceble_string, new_replaced_string, false);
                    }
                }
            }
        }

        private void toggle_creating(bool creating)
        {
            isCreating = creating;
            VersionsBox.Enabled = !creating;
            ModpackName.Enabled = !creating;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (isCreating)
            {
                return;
            }
            if (VersionName == "")
            {
                StatusLabel.Text = "Напишите новое название версии!";
                return;
            }
            if (VersionSelected == "")
            {
                StatusLabel.Text = "Выберите версию!";
                return;
            }
            // Блокировка и настройка перед началом
            StatusLabel.Text = "Начало создания...";
            StatusProgressBar.Value = 0;
            toggle_creating(true);

            // Начало копирования
            StatusLabel.Text = "Копирование версии с новым именем...";
            StatusProgressBar.Value = 1;
            DirectoryInfo VersionsPathNewVersion = new DirectoryInfo(PathToMinecraft + $"\\versions\\{VersionName}");
            if (VersionsPathNewVersion.Exists)
            {
                StatusLabel.Text = "Версия с этим именем уже есть!";
                toggle_creating(false);
                return;
            }
            VersionsPathNewVersion.Create();
            DirectoryInfo VersionsPathOldVersion = new DirectoryInfo(PathToMinecraft + $"\\versions\\{VersionSelected}");
            if (!VersionsPathOldVersion.Exists)
            {
                StatusLabel.Text = $"Не найдена версия {VersionSelected}!";
                toggle_creating(false);
                return;
            }
            StatusProgressBar.Value = 4;
            CopyDirectory(VersionsPathOldVersion.FullName, VersionsPathNewVersion.FullName, true, VersionSelected, VersionName, true);

            // работа с json версии
            try
            {
                string jsonString = File.ReadAllText(VersionsPathNewVersion.FullName + $"\\{VersionName}.json");

                dynamic versionInfo = JsonConvert.DeserializeObject(jsonString);
                versionInfo["id"] = VersionName;
                versionInfo["family"] = VersionName;
                string updatedJsonString = JsonConvert.SerializeObject(versionInfo, Formatting.Indented);
                File.WriteAllText(VersionsPathNewVersion.FullName + $"\\{VersionName}.json", updatedJsonString);
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Не удалось переписать json! :(";
                VersionsPathNewVersion.Delete();
                toggle_creating(false);
                return;
            }

            // сохранение данных или создание пустого католога
            DirectoryInfo HomeNewVersionDir = new DirectoryInfo(PathToMinecraft + $"\\home\\{VersionName}");
            HomeNewVersionDir.Create();
            if (SaveDataBox.Checked)
            {
                StatusProgressBar.Value = 6;
                StatusLabel.Text = "Перенос данных...";
                DirectoryInfo HomeOldVersionDir = new DirectoryInfo(PathToMinecraft + $"\\home\\{VersionSelected}");
                if (HomeOldVersionDir.Exists)
                {
                    CopyDirectory(HomeOldVersionDir.FullName, HomeNewVersionDir.FullName, true);
                }
            }
            StatusProgressBar.Value = 8;
            StatusLabel.Text = "Завершение...";

            // Конец копирования
            StatusProgressBar.Value = 10;
            StatusLabel.Text = $"Версия {VersionSelected} успешно скопировна с именем {VersionName}!";
            toggle_creating(false);
            ModpackName.Text = "";
            load_versions();
        }

        private void VersionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VersionSelected = VersionsBox.SelectedItem.ToString();
        }

        private void ModpackName_TextChanged(object sender, EventArgs e)
        {
            VersionName = ModpackName.Text;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            var HelpForm = new Help();
            HelpForm.Show();
        }

        private void PathToMinecraftBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PathToMinecraftBoxButton_Click(object sender, EventArgs e)
        {
            PathToMinecraft = PathToMinecraftBox.Text;
            File.WriteAllText(PathToLLVD + "\\save.txt", PathToMinecraft);
            load_versions();
        }
    }
}
