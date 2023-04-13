using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using NastinCOFE.ClassHelper;
using NastinCOFE.DB;
namespace NastinCOFE.Windows
{
    /// <summary>
    /// Логика взаимодействия для Employ.xaml
    /// </summary>
    public partial class Employ : Window
    {
        List<DB.User> users = new List<DB.User>();
        public Employ()
        {

            var correct = HELP.Context.User.ToList();
            //  string[] words2 = correct.Split(new char[] { ' ' });
            //  List<object> users2 = new List<object>();
            ////  string[] words3 = HELP.Context.
            }
        }
    }
}
