using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранит экземпляр текущего проекта
        /// </summary>
        private Project _currentProject;

        /// <summary>
        /// Хранит номер текущей заметки
        /// </summary>
        private int _noteId;

        public int NoteId
        {
            get { return _noteId; }
            set { _noteId = value; }
        }

        public Project CurrentProject
        {
            get { return _currentProject; }
            set { _currentProject = value; }
        }

        public MainForm()
        {
            InitializeComponent();

            CurrentProject = ProjectManager.LoadFromFile();

            try
            {
                CurrentProject.SortNotesCollection();
            }
            catch (NullReferenceException)
            {

            }

            this.NotesListBox.DataSource = CurrentProject.NotesCollection;
            this.NotesListBox.DisplayMember = "Name";

            // Чистим поля
            ClearFields();
        }

        /// <summary>
        /// Обновляет данные ListBox заметок
        /// </summary>
        private void UpdateNotesList()
        {
            // Перезагружаем проект
            CurrentProject = ProjectManager.LoadFromFile();
            CurrentProject.SortNotesCollection();

            // Обновляем данные коллекции
            NotesListBox.DataSource = null;
            NotesListBox.DataSource = CurrentProject.NotesCollection;
            NotesListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Чистит все информационные поля заметки
        /// </summary>
        private void ClearFields()
        {
            NoteNameLabel.Text = "";
            CategoryLabel.Text = "";
            DateOfCreationTextBox.Text = "";
            DateOfLastEditTextBox.Text = "";
            ContentTextBox.Text = "";
        }


        /// <summary>
        /// Пункт меню Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyAddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Можно добавить только до 200 заметок
            if (CurrentProject.NotesCollection.Count < 200)
            {
                AddEditNote addEditNote = new AddEditNote();
                addEditNote.AddNote();

                if (addEditNote.ShowDialog() == DialogResult.OK)
                {
                    CurrentProject.NotesCollection.Add(addEditNote.CurrentNote);
                    ProjectManager.SaveToFile(CurrentProject);
                    UpdateNotesList();
                }
            }
            else
            {
                // Подсвечиваем ListBox заметок
                NotesListBox.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Кнопка редактировать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyEditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Должна быть выбрана заметка
            if (NotesListBox.SelectedIndex != -1)
            {
                AddEditNote addEditNote = new AddEditNote();
                addEditNote.EditNote(CurrentProject.NotesCollection[NoteId]);
                
                if (addEditNote.ShowDialog() == DialogResult.OK)
                {
                    CurrentProject.NotesCollection[NoteId] = addEditNote.CurrentNote;
                    ProjectManager.SaveToFile(CurrentProject);
                    UpdateNotesList();
                }
            }
            else
            {
                NotesListBox.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Кнопка О программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();

            about.ShowDialog();
        }

        /// <summary>
        /// Кнопка меню Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Список должен быть не пустым
            if (CurrentProject.NotesCollection.Count != 0)
            {
                ProjectManager.SaveToFile(CurrentProject);
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Кнопка меню Удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyRemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Должна быть выбрана заметка
            if (NotesListBox.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Do you want to remove note?", "NoteApp", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CurrentProject.NotesCollection.RemoveAt(NoteId);
                    ProjectManager.SaveToFile(CurrentProject);
                    UpdateNotesList();

                    this.DialogResult = DialogResult.Cancel;
                }

                if (result == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                NotesListBox.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Кнопка Создать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddEditNote addEditNote = new AddEditNote();
            addEditNote.AddNote();

            // Ограничение до 200 заметок
            if (CurrentProject.NotesCollection.Count < 200)
            {
                if (addEditNote.ShowDialog() == DialogResult.OK)
                {
                    CurrentProject.NotesCollection.Add(addEditNote.CurrentNote);
                    ProjectManager.SaveToFile(CurrentProject);
                    UpdateNotesList();
                }
            }
            else
            {
                // Подсветка заметок
                NotesListBox.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Кнопка Edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            // Должна быть выбрана заметка
            if (NotesListBox.SelectedIndex != -1)
            {
                AddEditNote addEditNote = new AddEditNote();
                addEditNote.EditNote(CurrentProject.NotesCollection[NoteId]);

                if (addEditNote.ShowDialog() == DialogResult.OK)
                {
                    CurrentProject.NotesCollection[NoteId] = addEditNote.CurrentNote;
                    ProjectManager.SaveToFile(CurrentProject);
                    UpdateNotesList();
                }
            }
            else
            {
                NotesListBox.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Кнопка Remove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            // Должна быть выбрана заметка
            if (NotesListBox.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Do you want to remove note?", "NoteApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Удаляем заметку по id
                    CurrentProject.NotesCollection.RemoveAt(NoteId);
                    ProjectManager.SaveToFile(CurrentProject);
                    UpdateNotesList();

                    this.DialogResult = DialogResult.Cancel;
                }

                if (result == DialogResult.No)
                {
                    // Закрытие диалога
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                NotesListBox.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Изменение индекса выбранной заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NoteId = NotesListBox.SelectedIndex;

            // Возвращаем цвет
            NotesListBox.BackColor = Color.White;

            if (NoteId != -1)
            {
                NoteNameLabel.Text = CurrentProject.NotesCollection[NoteId].Name;

                // Категории
                if (CurrentProject.NotesCollection[NoteId].Category == NoteCategory.HealthAndSport)
                {
                    CategoryLabel.Text = "Health and Sport";
                }
                else
                {
                    CategoryLabel.Text = CurrentProject.NotesCollection[NoteId].Category.ToString();
                }

                DateOfCreationTextBox.Text = CurrentProject.NotesCollection[NoteId].DateOfCreation.ToString();
                DateOfLastEditTextBox.Text = CurrentProject.NotesCollection[NoteId].DateOfLastEdit.ToString();
                ContentTextBox.Text = CurrentProject.NotesCollection[NoteId].Content;
            }
            else
            {
                ClearFields();
            }
        }

        /// <summary>
        /// Закрытие окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "NoteApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Список не должен быть пустым
                if (CurrentProject.NotesCollection.Count != 0)
                {
                    ProjectManager.SaveToFile(CurrentProject);
                }
            }

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Фокусировка на ListBox заметок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_Enter(object sender, EventArgs e)
        {
            NotesListBox.BackColor = Color.White;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
