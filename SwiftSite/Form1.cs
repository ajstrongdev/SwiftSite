using System.Runtime.InteropServices;

namespace SwiftSite
{
    public partial class Form1 : Form
    {
        List<string> uiElements = new List<string> { "labelTitle", "labelContent", "tbxTitle", "rtbContent", "btnAdd" };
        Render render = new Render();
        int action = 0;
        int orderID = 0;
        int debug = 0;

        // Import console - Ref: https://stackoverflow.com/questions/4362111/how-do-i-show-a-console-output-window-in-a-forms-application
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Form1(int debugEnabled)
        {
            InitializeComponent();
            debug = debugEnabled;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (debug == 1)
            {
                AllocConsole();
                Console.WriteLine("Debug mode:");
            }
            hideUIElements();
            if (Directory.Exists(@"C:\SwiftSite") == false)
            {
                Directory.CreateDirectory(@"C:\SwiftSite"); // Create generated files directory.
            }
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            action = 1;
            foreach (var element in uiElements)
            {
                Control[] controls = this.Controls.Find(element, true);
                if (controls.Length > 0)
                {
                    controls[0].Visible = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (action == 1)
            {
                Database.sections = Database.sections.Append(new Sections { id = orderID, title = tbxTitle.Text, content = rtbContent.Text }).ToList(); // Add item to database.
                render.order.Add(action);
                orderID++;
            }
            if (action == 2)
            {
                Database.title = tbxTitle.Text;
            }
            if (action == 3)
            {
                Database.images = Database.images.Append(new Image { id = orderID, url = tbxTitle.Text }).ToList(); // Add item to database.
                render.order.Add(action);
                orderID++;
            }

            // Debug
            if (debug == 1)
            {
                if (action == 1) { Console.WriteLine("Added SECTION to build queue."); }
                if (action == 2) { Console.WriteLine("Added TITLE to build queue."); }
                if (action == 3) { Console.WriteLine("Added IMAGE to build queue."); }
            }

            hideUIElements();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
            string filePath = @$"C:\SwiftSite\generated-{datetime}.html";
            string[] prelude = { $"<!DOCTYPE html><html><head><title>{Database.title}</title></head><body>" };
            string[] postlude = { "</body></html>" };
            File.AppendAllLines(filePath, prelude); // Add prelude to HTML file.

            int sectionIndex = 0;
            int imageIndex = 0;

            for (var i = 0; i < render.order.Count; i++)
            {
                if (render.order[i] == 1 && sectionIndex < Database.sections.Count)
                {
                    string[] sectionData = { $"<section>\n<h1>{Database.sections[sectionIndex].title}</h1>\n" + $"<p>{Database.sections[sectionIndex].content}</p>\n</section>" };
                    File.AppendAllLines(filePath, sectionData);
                    sectionIndex++;
                }
                else if (render.order[i] == 3 && imageIndex < Database.images.Count)
                {
                    string[] imageData = { $"<img src=\"{Database.images[imageIndex].url}\" alt=\"{Database.images[imageIndex].id}\" width=\"100\" />" };
                    File.AppendAllLines(filePath, imageData);
                    imageIndex++;
                }
            }

            File.AppendAllLines(filePath, postlude); // Add postlude to HTML file.
            MessageBox.Show($"Website generated successfully at: {filePath}");
        }


        void hideUIElements()
        {
            action = 0;
            tbxTitle.Text = null;
            rtbContent.Text = null;
            foreach (var element in uiElements)
            {
                Control[] controls = this.Controls.Find(element, true);
                if (controls.Length > 0)
                {
                    controls[0].Visible = false;
                }
            }
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Website Title:";
            action = 2;
            tbxTitle.Show();
            labelTitle.Show();
            btnAdd.Show();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Image URL:";
            action = 3;
            tbxTitle.Show();
            labelTitle.Show();
            btnAdd.Show();
        }
    }
}

