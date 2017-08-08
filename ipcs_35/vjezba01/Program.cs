using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vjezba1
{
    //definisemo delegat
    delegate void MyDelegate();

    class MyEvent : Form
    {
        //definisemo dogadjaj
        event MyDelegate EventExample;

        public MyEvent()
        {
            Button b1 = new Button();
            b1.Parent = this;
            b1.Text = "Desio se";

            //dodjeljujemo nas delegat dogadjaju EventExample
            //tj. registrujemo ga na dogadjaj EventExample
            EventExample += new MyDelegate(OnStartEvent);

            //zapocinje nas dogadjaj
            EventExample();
        }

        //ovja metod se poziva kad se dogodi "EventExample" : Event handelr
        public void OnStartEvent()
        {
            MessageBox.Show("Hej! Klikni na ok da bi vidjeo kako funkcionise dogadjaj!");
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyEvent());
        }
    }
}
