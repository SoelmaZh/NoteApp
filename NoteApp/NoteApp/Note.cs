using Newtonsoft.Json;
using System;
using System.Data;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace NoteApp
{
    /// <summary>
    /// класс заметка
    /// </summary>
    public class Note : ICloneable
    {

        /// <summary>
        /// название заметки
        /// </summary>
        private string _title;
        /// <summary>
        /// текст заметки
        /// </summary>
        private string _text;
        /// <summary>
        /// время создания заметки
        /// </summary>
        private DateTime _timeCreated;
        /// <summary>
        /// категория заметки
        /// </summary>
        private NoteCategory _noteCategory;
        /// <summary>
        /// время последнего изменения
        /// </summary>
        private DateTime _lastModification;

        /// <summary>
        /// Создание заметки (с указанием времени создания)
        /// </summary>
        /// <param name="CreationTime">Дата созадния заметки</param>
        public Note(DateTime CreationTime)
        {
            if (CreationTime <= DateTime.Now)
            {
                _timeCreated = CreationTime;
                _lastModification = CreationTime;
            }
            else
            {
                throw new ArgumentException("Некорректная дата!");
            }
        }

        /// <summary>
        /// возвращает название заметки
        /// </summary>

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Заголовок должен быть короче 50 символов");
                }
                else
                {
                    _title = value;
                }

            }
        }
        /// <summary>
        /// возвращает текст заметки
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (value != null)
                {
                    _text = value;
                }
                else
                {
                    throw new ArgumentException("Текст заметки должен быть больше 0");
                }
            }
        }


        /// <summary>
        /// возвращает категорию заметки
        /// </summary>
        public NoteCategory Category
        {
            get
            {
                return _noteCategory;
            }
            set
            {
                if (value >= 0)
                {
                    _noteCategory = value;
                }
                else
                {
                    throw new ArgumentException("Некорректная категория");
                }
            }
        }
        /// <summary>
        /// возвращает последнее изменение
        /// </summary>
        public DateTime LastModification
        {
            get
            {
                return _lastModification;
            }

            set
            {
                if (value <= DateTime.Now)
                {
                    _lastModification = value;
                }
                else
                {
                    throw new ArgumentException("Дата изменения не может быть позже текущей даты.");
                }
            }
        }

        /// <summary>
        /// клонирование
        /// </summary>
        /// <returns>возвращает копию данной записи</returns>
        public object Clone()
        {
            var newNote = new Note(_timeCreated);
            newNote.Title = _title;
            newNote.Text = _text;
            newNote.LastModification = _lastModification;
            newNote.Category = _noteCategory;
            return newNote;
        }
    }
}
