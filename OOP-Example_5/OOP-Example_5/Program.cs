using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Example_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new Form();
            form.Show();

            var button = new Button();

            button.Text = "Click Me!";
            button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button.Click += (s, e) => { form.Close(); };
            form.Controls.Add(button);

            Application.Run();

        }
    }
}
