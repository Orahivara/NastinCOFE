﻿using Microsoft.Win32;
using NastinCOFE.ClassHelper;
using NastinCOFE.DB;
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
using System.Windows.Shapes;

namespace NastinCOFE.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddItem.xaml
    /// </summary>
    public partial class AddItem : Window
    {
        Product addproduct = new Product();
        public AddItem()
        {
            InitializeComponent();
            typeprod.ItemsSource = HELP.Context.TypeOfProduct.ToList();
            //  typeprod.ItemsSource = HELP.Context.TypeOfProduct.ToList();
            //  type.ItemsSource = Context.Gender.ToList();
            typeprod.SelectedIndex = 1;

            //     type.DisplayMemberPath = (type.ItemsSource as UserType).NameTypeOfUser;
            // type.SelectedIndex= 0;
            typeprod.DisplayMemberPath = "NameTypeOfProduct";

        }

        private void photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            if (openFile.ShowDialog() == true)
            {
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri(openFile.FileName));
                photo.Background = brush;
                addproduct.Imagen = brush.ToString();
                // openFile.Source= new BitmapImage(new Uri(openFile.FileName));
                //oopenFile.Source=new BitmapImage(new Uri(openFile.FileName));
                //  image = openFile.FileName;

            }

        }

        private void additem_Click(object sender, RoutedEventArgs e)
        {
            addproduct.NameOfProduct = nameofprod.Text;
            addproduct.Quantity = Convert.ToInt32(quant.Text);
            addproduct.Cost = Convert.ToInt32(cost.Text);
            addproduct.IDTypeOfProduct = (typeprod.SelectedItem as DB.TypeOfProduct).IDTypeOfProduct;
            HELP.Context.Product.Add(addproduct);

            HELP.Context.SaveChanges();
        }
    }
}