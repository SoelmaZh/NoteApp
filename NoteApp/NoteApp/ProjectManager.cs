using System;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Сериализация для класса Note
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <param name="listNotes">Список заметок</param>
        /// <param name="fileName">Имя файла</param>
        public static void Save(Project project, string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();
            //Открытие потока
            string path = "C:\\Users\\Соя\\source\\repos\\NoteApp\\NoteApp\\docs\\1.txt";
            using (StreamWriter sw = new StreamWriter(@path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаём объект для сериализации
                serializer.Serialize(writer, project.NotesList);
            }
        }

        public static Project Load(string fileName)
        {
            Project notes = new Project();
            //Создаём экземпляр сериализатора.
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути.
            using (StreamReader sr = new StreamReader(fileName))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию 
                var noteList = (Project)serializer.Deserialize<Project>(reader);
                notes = noteList;
            }

            return notes;
        }

    }
}

