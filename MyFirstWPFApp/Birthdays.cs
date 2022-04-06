using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
using Newtonsoft.Json;
using System.Reflection;
using Path = System.IO.Path;
using System.Windows.Markup;



namespace MyFirstWPFApp
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static Dictionary<string, CountdownDate> birthdayDictionary = new Dictionary<string, CountdownDate>();

        static List<CountdownDate> dateList = new List<CountdownDate>();

        static List<TextBlock> selectedTextBlockList = new List<TextBlock>();

        public MainWindow()
        {
            InitializeComponent();

            ReadDateFile();

            //sort list by days until date, then cycle through and send to addToPanel function to add to the panel.
            SortListAndDislay();
                    

        }

        public static void ReadDateFile()
        {
            string fileName = String.Format(@"{0}\DateListFileLocalised.txt", System.Windows.Forms.Application.StartupPath);

            MessageBox.Show(fileName);

            if (File.Exists(fileName))
            {
                var lines = File.ReadLines(fileName);
                
                if (lines != null)
                {
                    foreach (var line in lines)
                    {
                        string[] splitLineList = line.Split("-");
                        DateTime splitDate = DateTime.Parse(splitLineList[1]);
                        dateList.Add(new CountdownDate(splitLineList[0], splitDate, bool.Parse(splitLineList[2])));
                    }
                }                
            }   
        }

        public static void SortListAndDislay()
        {
            //need this to access wrap panel in static method
            MainWindow ExistingInstanceOfMainWindow = Window.GetWindow(Application.Current.MainWindow) as MainWindow;

            //clear wrap panel to make sure empty
            ClearWrapPanel(ExistingInstanceOfMainWindow.DisplayWrapPanel);

            List <CountdownDate> sorted = dateList.OrderBy(o => o.DaysUntilDate).ToList();

            

            foreach (var date in sorted)
            {
                TextBlock customTextBlock = CreateDaysText(date.Name, date.DaysUntilDate, date.IsEvent);

                AddToWrapPanel(customTextBlock, ExistingInstanceOfMainWindow.DisplayWrapPanel);
            }

        }

        

        public static void ClearWrapPanel(WrapPanel displayWrapPanel)
        {
            displayWrapPanel.Children.Clear();
        }

        private static void AddToWrapPanel(TextBlock customTextBlock, WrapPanel displayWrapPanel)
        {
            Border border = new Border();
            border.Child = customTextBlock;
            displayWrapPanel.Children.Add(border);
        }

                
        public static TextBlock CreateDaysText(string name, int days, bool isEvent)
        {

            TextBlock tempTextBlock = new TextBlock();

            tempTextBlock.TextAlignment = TextAlignment.Center;
            tempTextBlock.TextWrapping = TextWrapping.Wrap;
            tempTextBlock.Margin = new Thickness(5);
            tempTextBlock.PreviewMouseDown += EventClicked;
            tempTextBlock.Foreground = new SolidColorBrush(Colors.Black);
            tempTextBlock.Name = name;

            if (isEvent)
            {
                tempTextBlock.Inlines.Add($"{ days} days until \n");
                tempTextBlock.Inlines.Add(new Run($"{name}") { FontWeight = FontWeights.Bold });
                tempTextBlock.Inlines.Add(".");
            }
            else
            {
                tempTextBlock.Inlines.Add(new Run($"{name}\n ") { FontWeight = FontWeights.Bold });
                tempTextBlock.Inlines.Add($"{ days} days until your birthday!\n");

            }

            return tempTextBlock;


        }

        private static void EventClicked(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (selectedTextBlockList.Contains(textBlock))
            {
                selectedTextBlockList.Remove(textBlock);
                textBlock.Foreground = new SolidColorBrush(Colors.Black);
            }
            else
            {
                selectedTextBlockList.Add(textBlock);
                textBlock.Foreground = new SolidColorBrush(Colors.Red);
            }
  
        }

        public void OpenCreateNewDatePage(object sender, EventArgs e)
        {
            Myfirstapp.CreateNewDateWindow p = new Myfirstapp.CreateNewDateWindow();
            p.Show();
        }

        public static void AddNewDateToList(string name, DateTime date, bool isEvent)
        {
            dateList.Add(new CountdownDate(name, date, isEvent));
            SortListAndDislay();
            SaveDateList();
            
        }

        public static void SaveDateList()
        {
            string fileName = String.Format(@"{0}\DateListFileLocalised.txt", System.Windows.Forms.Application.StartupPath);
            
            using (TextWriter tw = new StreamWriter(fileName))
            {
                foreach (var item in dateList)
                {
                    tw.WriteLine($"{item.Name}-{item.Date}-{item.IsEvent}");
                }
            }
        }

        public void ClickDelete(object sender, RoutedEventArgs e)
        {
            foreach(TextBlock textBlock in selectedTextBlockList)
            {
                for (int i = 0; i < dateList.Count; i++)
                {
                    if (dateList[i].Name == textBlock.Name)
                    {
                        dateList.Remove(dateList[i]);
                    }
                }
            }

            SortListAndDislay();
            SaveDateList();

        }

    }
}
