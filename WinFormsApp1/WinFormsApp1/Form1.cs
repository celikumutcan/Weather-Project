using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;
using System.Speech.AudioFormat;
using Microsoft.VisualBasic.Devices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //  The code initializes a speech recognition engine in C# with English (United States) as the language.
        //  It allows the program to recognize and convert spoken words into text or commands.
        readonly SpeechRecognitionEngine recognitionEngine = new(new CultureInfo("en-US"));


        //  The function gettemp is defined with a parameter country_name which is used to retrieve weather information for a specific country.
        //  The function updates the text of label1 and label2 controls with the country_name and the current date respectively.
        //  The API key is stored in the my_API variable and the API request URL is constructed using the my_connection variable, which includes the country_name parameter and other request parameters.
        //  Several string variables (wind, temperature, humidity, pressure, feels_like, and s_weather) are declared to store the weather data retrieved from the API.
        //  The weather data is fetched from the API using an XML parser(XDocument). The specific weather attributes are extracted and stored in their respective variables.
        //  The- The temperature, wind speed, humidity, pressure, feels like temperature, and weather description are displayed on different labels in the Windows Forms application.
        //  The weather description is used in a conditional statement (if-else) to determine which image to display in the pictureBox2 control.Different images are assigned based on the weather conditions such as
        //    "açýk" (sunny), "bulutlu" (cloudy), "parçalý bulutlu" (partly cloudy), "karlý" (snowy), or other conditions are considered as "rainy".
        private void Gettemp(string country_name)
        {
            label1.Text = country_name;
            label2.Text = DateTime.Now.ToShortDateString();

            string my_API = "c577d30e760d8b46e7d908d3f15ec49a";
            string my_connection = "https://api.openweathermap.org/data/2.5/weather?q=" + country_name + "&mode=xml&lang=tr&units=metric&appid=" + my_API;


            string wind = "", temperature = "", humidity = "", pressure = "", feels_like = "", s_weather = ""; ;
            try
            {
                XDocument weather = XDocument.Load(my_connection);

                temperature = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                wind = weather.Descendants("speed").ElementAt(0).Attribute("value").Value;
                humidity = weather.Descendants("humidity").ElementAt(0).Attribute("value").Value;
                pressure = weather.Descendants("pressure").ElementAt(0).Attribute("value").Value;
                feels_like = weather.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
                s_weather = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
                richTextBox1.Text = "It's a beautiful place <3";

                label11.Text = temperature.ToString() + "°C";
                label10.Text = wind + " m/s";
                label9.Text = humidity + "%";
                label8.Text = pressure + " hPa";
                label7.Text = feels_like + " celsius";
                label12.Text = s_weather;

                if (s_weather == "açýk")
                {
                    pictureBox2.ImageLocation = @"C:\Users\umutc\OneDrive - metu.edu.tr\Desktop\Projelerim\weather_project\sunny.png";
                }
                else if (s_weather == "bulutlu")
                {
                    pictureBox2.ImageLocation = @"C:\Users\umutc\OneDrive - metu.edu.tr\Desktop\Projelerim\weather_project\cloudy.png";
                }
                else if (s_weather == "parçalý bulutlu")
                {
                    pictureBox2.ImageLocation = @"C:\Users\umutc\OneDrive - metu.edu.tr\Desktop\Projelerim\weather_project\Partly loudy.png";
                }
                else if (s_weather == "karlý")
                {
                    pictureBox2.ImageLocation = @"C:\Users\umutc\OneDrive - metu.edu.tr\Desktop\Projelerim\weather_project\snowy.png";
                }
                else
                {
                    pictureBox2.ImageLocation = @"C:\Users\umutc\OneDrive - metu.edu.tr\Desktop\Projelerim\weather_project\rainy.png";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You entered the wrong country name.\nTry again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                string[] command = { "Adana", "Adiyaman", "Afyonkarahisar", "Agri", "Amasya", "Ankara", "Antalya", "Artvin", "Aydin", "Balikesir", "Bilecik", "Bingol",
                                 "Bitlis", "Bolu", "Burdur", "Bursa", "Canakkale", "Cankiri", "Corum", "Denizli", "Diyarbakir", "Edirne", "Elazig", "Erzincan", "Erzurum",
                                 "Eskisehir", "Gaziantep", "Giresun", "Gumushane", "Hakkari", "Hatay", "Isparta", "Mersin", "Istanbul", "Izmir", "Kars", "Kastamonu", "Kayseri",
                                 "Kirklareli", "Kirsehir", "Kocaeli", "Konya", "Kutahya", "Malatya", "Manisa", "Kahramanmaras", "Mardin", "Mugla", "Mus", "Nevsehir", "Nigde", "Ordu",
                                 "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdag", "Tokat", "Trabzon", "Tunceli", "Sanliurfa", "Usak", "Van", "Yozgat", "Zonguldak",
                                 "Aksaray", "Bayburt", "Karaman", "Kirikkale", "Batman", "Sirnak", "Bartin", "Ardahan", "Igdir", "Yalova", "Karabuk", "Kilis", "Osmaniye", "Duzce",
                                    "China", "India", "USA", "Indonesia", "Pakistan", "Brazil", "Nigeria", "Bangladesh", "Russia", "Mexico",
                                 "Japan", "Ethiopia", "Philippines", "Egypt", "Vietnam", "DR Congo", "Turkey", "Iran", "Germany", "Thailand",
                                 "United Kingdom", "France", "Italy", "Tanzania", "South Africa", "Myanmar", "Kenya", "South Korea", "Colombia",
                                 "Spain", "Cyprus", "Uganda", "Argentina", "Algeria", "Sudan", "Ukraine", "Iraq", "Afghanistan", "Poland",
                                 "Canada", "Morocco", "Saudi Arabia", "Uzbekistan" };
                string searchLetter = textBox1.Text;

                IEnumerable<string> query = from item in command
                                            where item.StartsWith(searchLetter, StringComparison.OrdinalIgnoreCase)
                                            select item;

                richTextBox1.Text = string.Join(Environment.NewLine, query);

                pictureBox2.ImageLocation = @"C:\Users\umutc\OneDrive - metu.edu.tr\Desktop\Projelerim\weather_project\Red_X.svg.png";


                label11.Text = "XX";
                label10.Text = "XX";
                label9.Text = "XX";
                label8.Text = "XX";
                label7.Text = "XX";
                label12.Text = "XX";
                label2.Text = "XX";

            }
        }


        //  The Form1_Load method is executed when the form is loaded.
        //  Inside the method, the gettemp function is called with the argument "Cyprus".
        //  The gettemp function is expected to retrieve and display the weather information for Cyprus.
        private void Form1_Load(object sender, EventArgs e)
        {
            Gettemp("Cyprus");
        }


        //  The button1_Click method is executed when button1 is clicked.
        //  Inside the method, the gettemp function is called with the argument textBox1.Text.
        //  textBox1.Text represents the text entered in a text box control, which is used as the country name input.
        //  The gettemp function is expected to retrieve and display the weather information for the country specified in the textBox1 control.
        private void Button1_Click(object sender, EventArgs e)
        {
            Gettemp(textBox1.Text);
        }


        //  The textBox1_KeyDown method is executed when a key is pressed while textBox1 has focus.
        //  Inside the method, it checks if the key pressed is the Enter key(e.KeyCode == Keys.Enter).
        //  If the Enter key is pressed, the gettemp function is called with the argument textBox1.Text.
        //  textBox1.Text represents the text entered in the text box control, which is used as the country name input.
        //  The gettemp function is expected to retrieve and display the weather information for the country specified in the textBox1 control.
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Gettemp(textBox1.Text);
            }
        }


        //  The code hides a mic control or image, calls a custom method named "MYvoice",
        //    and starts the asynchronous speech recognition process using the recognitionEngine object.
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            mic1.Visible = false;
            MYvoice();
            recognitionEngine.RecognizeAsync();
        }


        //  This code handles the click event on PictureBox4 and ensures that the mic1 control is made visible when the event occurs.
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            mic1.Visible = true;
        }


        //  An array named command is declared, containing a list of strings representing various city names and country names.
        //  A Choices object named options is created, initialized with the command array.This object represents a collection of choices or options that can be recognized by the speech recognition engine.
        //  A GrammarBuilder object named gb is created, and the options object is passed to it.Additionally, the culture is set to "en-US" (English, United States).
        //  A Grammar object named grammar is created, initialized with the gb object.
        //  The grammar object is loaded into the recognitionEngine, which is an instance of a speech recognition engine.
        //  The input source for the recognitionEngine is set to the default audio device.
        //  An event handler named Founded is associated with the SpeechRecognized event of the recognitionEngine.
        void MYvoice()
        {
            string[] command = { "Adana", "Adiyaman", "Afyonkarahisar", "Agri", "Amasya", "Ankara", "Antalya", "Artvin", "Aydin", "Balikesir", "Bilecik", "Bingol",
                                 "Bitlis", "Bolu", "Burdur", "Bursa", "Canakkale", "Cankiri", "Corum", "Denizli", "Diyarbakir", "Edirne", "Elazig", "Erzincan", "Erzurum",
                                 "Eskisehir", "Gaziantep", "Giresun", "Gumushane", "Hakkari", "Hatay", "Isparta", "Mersin", "Istanbul", "Izmir", "Kars", "Kastamonu", "Kayseri",
                                 "Kirklareli", "Kirsehir", "Kocaeli", "Konya", "Kutahya", "Malatya", "Manisa", "Kahramanmaras", "Mardin", "Mugla", "Mus", "Nevsehir", "Nigde", "Ordu",
                                 "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdag", "Tokat", "Trabzon", "Tunceli", "Sanliurfa", "Usak", "Van", "Yozgat", "Zonguldak",
                                 "Aksaray", "Bayburt", "Karaman", "Kirikkale", "Batman", "Sirnak", "Bartin", "Ardahan", "Igdir", "Yalova", "Karabuk", "Kilis", "Osmaniye", "Duzce",
                                    "China", "India", "USA", "Indonesia", "Pakistan", "Brazil", "Nigeria", "Bangladesh", "Russia", "Mexico",
                                 "Japan", "Ethiopia", "Philippines", "Egypt", "Vietnam", "DR Congo", "Turkey", "Iran", "Germany", "Thailand",
                                 "United Kingdom", "France", "Italy", "Tanzania", "South Africa", "Myanmar", "Kenya", "South Korea", "Colombia",
                                 "Spain", "Cyprus", "Uganda", "Argentina", "Algeria", "Sudan", "Ukraine", "Iraq", "Afghanistan", "Poland",
                                 "Canada", "Morocco", "Saudi Arabia", "Uzbekistan" };


            Choices options = new(command);

            var gb = new GrammarBuilder(options)
            {
                Culture = new CultureInfo("en-US")
            };

            Grammar grammer = new(gb);
            recognitionEngine.LoadGrammar(grammer);

            recognitionEngine.SetInputToDefaultAudioDevice();
            recognitionEngine.SpeechRecognized += Founded;
        }


        //  The Founded event handler method is responsible for displaying the recognized speech text in a text box (textBox1) and
        //      making the "mic1" control or image visible when speech is recognized.
        private void Founded(object sender, SpeechRecognizedEventArgs e)
        {
            mic1.Visible = true;
            textBox1.Text = (e.Result.Text);
        }


        //  The richTextBox1_MouseClick function is an event handler that is triggered when a mouse click occurs on the richTextBox1 control.
        //  It retrieves the character index and line index based on the click location.
        //  Then, it extracts the text of the selected line and clears the content of textBox1.
        //  Finally, it passes the extracted line as a parameter to the Gettemp function.
        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = richTextBox1.GetCharIndexFromPosition(e.Location);
            int lineIndex = richTextBox1.GetLineFromCharIndex(index);
            try
            {
                string selectedText = richTextBox1.Lines[lineIndex];
                textBox1.Text = " ";
                Gettemp(selectedText);
            }
            catch
            { }
        }


        //  This code ensures that when the user closes the main form (Form1) of the application,
        //      it will close all other open forms (except for Form1 itself) and then exit the application entirely.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                int formCount = System.Windows.Forms.Application.OpenForms.Count;
                for (int i = formCount - 1; i >= 0; i--)
                {
                    Form form = System.Windows.Forms.Application.OpenForms[i];
                    if (form != this)
                    {
                        form.Close();
                    } 
                }
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}