using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace NoteApp
    {
        /// <summary>
        /// Класс - список всех заметок
        /// </summary>
        public class Project
        {
            /// <summary>
            /// Список всех заметок
            /// </summary>
            public List<Note> NotesList;
            /// <summary>
            /// Конструктор класса Project
            /// </summary>
            public Project()
            {
                NotesList = new List<Note>();
            }
        }
    }
