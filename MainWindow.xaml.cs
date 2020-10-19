using MaterialDesignThemes.Wpf;

namespace Axen.Minecraft.Launcher
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public DialogHost DialogHost => DialogHostMain;
    }
}