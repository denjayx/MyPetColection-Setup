using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using myPetsCollection.Models;
using myPetsCollection.Presenters;
using myPetsCollection._Repositories;
using myPetsCollection.Views;
using System.Configuration;

namespace myPetsCollection
{
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
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView view = new MainView();           
            new MainPresenter(view,sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
