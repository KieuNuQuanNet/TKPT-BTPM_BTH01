using System;

namespace MementoDemo
{
    // ----- Originator -----
    public class TextEditor
    {
        public string Content { get; set; }

        // Tạo memento (lưu trạng thái)
        public EditorMemento Save()
        {
            Console.WriteLine(">> Lưu trạng thái: " + Content);
            return new EditorMemento(Content);
        }

        // Khôi phục từ memento
        public void Restore(EditorMemento memento)
        {
            Content = memento.Content;
            Console.WriteLine(">> Khôi phục trạng thái: " + Content);
        }
    }

    // ----- Memento -----
    public class EditorMemento
    {
        public string Content { get; }

        public EditorMemento(string content)
        {
            Content = content;
        }
    }

    // ----- Caretaker -----
    public class History
    {
        private EditorMemento _memento;

        public EditorMemento Memento
        {
            get { return _memento; }
            set { _memento = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Originator
            TextEditor editor = new TextEditor();
            editor.Content = "Dòng đầu tiên";

            // Caretaker
            History history = new History();
            history.Memento = editor.Save();

            // Thay đổi nội dung
            editor.Content = "Dòng đã sửa";
            Console.WriteLine("Nội dung hiện tại: " + editor.Content);

            // Khôi phục lại từ memento
            editor.Restore(history.Memento);

            Console.ReadKey();
        }
    }
}
