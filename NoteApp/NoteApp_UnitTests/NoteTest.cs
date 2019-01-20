using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;

        [SetUp]
        public void Note()
        {
            _note = new Note("default name", "default content", NoteCategory.Other);
        }

        [TestCase("default name", "default content", NoteCategory.Other,
            TestName = "Тест конструктора")]
        public void TestNoteConstructor(string expectedName, string expectedContent,
            NoteCategory expectedCategory)
        {
            Assert.AreEqual(expectedName, _note.Name);
            Assert.AreEqual(expectedContent, _note.Content);
            Assert.AreEqual(expectedCategory, _note.Category);
        }

        [Test(Description = "Позитивный тест геттера name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Note";
            _note.Name = expected;
            var actual = _note.Name;

            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void TestNameSet_CorrectValue()
        {
            Assert.DoesNotThrow(
                        () => { _note.Name = "default name"; },
                        "Не должно возникать исключения"
                    );
        }

        [Test(Description = "Позитивный тест геттера Content")]
        public void TestContentGet_CorrectValue()
        {
            
            var expected = "default content";
            _note.Content = expected;
            var actual = _note.Content;
            
            Assert.AreEqual(expected, actual, "Геттер Content возвращает неправильное содержимое");
        }

        [Test(Description = "Позитивный тест сеттера Content")]
        public void TestContentSet_CorrectValue()
        {
            Assert.DoesNotThrow(
                () => { _note.Content = "default content"; },
                "Не должно возникать исключения"
            );
        }

        [Test(Description = "Позитивный тест геттера Category")]
        public void TestCategoryGet_CorrectValue()
        {
            var expected = NoteCategory.Other;
            _note.Category = expected;

            var actual = _note.Category;

            Assert.AreEqual(expected, actual, "Геттер Category возвращает неправильную категорию");
        }

        [Test(Description = "Позитивный тест сеттера Category")]
        public void TestCategorySet_CorrectValue()
        {
            Assert.DoesNotThrow(
                () => { _note.Category = NoteCategory.Other; },
                "Не должно возникать исключения"
            );
        }

        [Test(Description = "Позитивный тест геттера DateOfCreation")]
        public void TestDateOfCreationGet_CorrectValue()
        {
            var expected = DateTime.Now;
            _note.DateOfCreation = expected;

            var actual = _note.DateOfCreation;

            Assert.AreEqual(expected, actual, "Геттер DateOfCreation возвращает неправильное время");
        }

        [Test(Description = "Позитивный тест сеттера DateOfCreation")]
        public void TestDateOfCreationSet_CorrectValue()
        {
            Assert.DoesNotThrow(
                () => { _note.DateOfCreation = DateTime.Now; },
                "Не должно возникать исключения"
            );
        }

        [Test(Description = "Позитивный тест геттера DateOfLastEdit")]
        public void TestDateOfLastEditGet_CorrectValue()
        {
            var expected = DateTime.Now;
            _note.DateOfCreation = expected;

            var actual = _note.DateOfCreation;

            Assert.AreEqual(expected, actual, "Геттер DateOfCreation возвращает неправильное время");
        }

        [Test(Description = "Позитивный тест сеттера DateOfLastEdit")]
        public void TestDateOfLastEditSet_CorrectValue()
        {
            Assert.DoesNotThrow(
                () => { _note.DateOfLastEdit = DateTime.Now; },
                "Не должно возникать исключения"
            );
        }
    }
}