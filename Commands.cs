using System.Windows.Input;

namespace MyNotepad {
    class Commands {
        static Commands() {
            Exit = new RoutedCommand("Exit", typeof(MainWindow));
            New = new RoutedCommand("New", typeof(MainWindow));
            Open = new RoutedCommand("Open", typeof(MainWindow));
            Save = new RoutedCommand("Save", typeof(MainWindow));
        }
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand New { get; set; }
        public static RoutedCommand Open { get; set; }
        public static RoutedCommand Save { get; set; }
    }
}
