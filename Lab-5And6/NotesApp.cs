using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5And6
{
    public class NotesApp
    {
        private string notesDirectory = @"C:\NotesApp";

        // 1. SetupNoteDirectory()
        public void SetupNoteDirectory()
        {
            if (!Directory.Exists(notesDirectory))
            {
                Directory.CreateDirectory(notesDirectory);
                Console.WriteLine("NotesApp directory created.");
            }
            else
            {
                Console.WriteLine("NotesApp directory already exists.");
            }
        }

        // 2. CreateNote()
        public void CreateNote(string title, string content)
        {
            string filePath = Path.Combine(notesDirectory, title + ".txt");

            // Check whether the file already exists
            if (File.Exists(filePath))
            {
                Console.Write("File already exists. Do you want to overwrite it? (y/n): ");
                string choice = Console.ReadLine();

                if (choice.ToLower() != "y")
                {
                    Console.WriteLine("Note was not overwritten.");
                    return;
                }
            }

            // Create or overwrite the file
            File.WriteAllText(filePath, content);

            Console.WriteLine("Note created successfully.");
        }
        //3.ReadNote()
        public void ReadNote(string title)
        {
            string filePath = Path.Combine(notesDirectory, title + ".txt");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Note not found.");
                return;
            }

            string content = File.ReadAllText(filePath);

            Console.WriteLine("\n--- Note Content ---");
            Console.WriteLine(content);
        }

        // 4. ListAllNotes()
        public void ListAllNotes()
        {
            string[] files = Directory.GetFiles(notesDirectory, "*.txt");

            Console.WriteLine("\n--- All Notes ---");

            if (files.Length == 0)
            {
                Console.WriteLine("No notes found.");
                return;
            }

            foreach (string file in files)
            {
                string title = Path.GetFileNameWithoutExtension(file);
                Console.WriteLine(title);
            }
        }

        // 5. CopyNote()
        public void CopyNote(string originalTitle, string copyTitle)
        {
            string originalPath =
                Path.Combine(notesDirectory, originalTitle + ".txt");

            string copyPath =
                Path.Combine(notesDirectory, copyTitle + ".txt");

            if (!File.Exists(originalPath))
            {
                Console.WriteLine("Original note not found.");
                return;
            }

            if (File.Exists(copyPath))
            {
                Console.WriteLine("Copy destination already exists.");
                return;
            }

            File.Copy(originalPath, copyPath);

            Console.WriteLine("Note copied successfully.");
        }

        // 6. MoveNote()
        public void MoveNote(string oldTitle, string newTitle)
        {
            string oldPath =
                Path.Combine(notesDirectory, oldTitle + ".txt");

            string newPath =
                Path.Combine(notesDirectory, newTitle + ".txt");

            if (!File.Exists(oldPath))
            {
                Console.WriteLine("Note not found.");
                return;
            }

            if (File.Exists(newPath))
            {
                Console.WriteLine("A note with the new title already exists.");
                return;
            }

            File.Move(oldPath, newPath);

            Console.WriteLine("Note renamed successfully.");
        }

        // 7. DeleteNote()
        public void DeleteNote(string title)
        {
            string filePath =
                Path.Combine(notesDirectory, title + ".txt");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Note not found.");
                return;
            }

            Console.Write(
                $"Are you sure you want to delete '{title}'? (y/n): ");

            string choice = Console.ReadLine();

            if (choice.ToLower() == "y")
            {
                File.Delete(filePath);
                Console.WriteLine("Note deleted successfully.");
            }
            else
            {
                Console.WriteLine("Deletion cancelled.");
            }
        }

        // 8. ReadNoteLineByLine()
        public void ReadNoteLineByLine(string title)
        {
            string filePath =
                Path.Combine(notesDirectory, title + ".txt");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Note not found.");
                return;
            }

            Console.WriteLine("\n--- Note Line By Line ---");

            int lineNumber = 1;

            foreach (string line in File.ReadLines(filePath))
            {
                Console.WriteLine($"{lineNumber}: {line}");
                lineNumber++;
            }
        }
    }
}
