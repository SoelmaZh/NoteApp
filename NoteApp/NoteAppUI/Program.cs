using NoteApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            Project project = new Project();
            Note note = new Note(DateTime.Now);
            note.Title = "заметка";
            note.Category = NoteCategory.Other;
            project.NotesList.Add(note);
            string fileName = "file";
            ProjectManager.Save(project, fileName);
        }
    }
}