using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DateCounter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //создание связи с другими компонентами
        private Model model;
        private Presenter presenter;
        public MainWindow()
        {
            InitializeComponent();
            model = new Model();
            presenter = new Presenter(model);
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            this.model = this.presenter.Login(dayAndMonth.Text);
            Update();
        }

        private void Update()
        { textBlock.Text=this.model.Message; }
    }
}
