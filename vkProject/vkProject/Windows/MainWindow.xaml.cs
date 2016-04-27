﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Threading.Tasks;
using VkAPI;

namespace vkProject
{

	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
            WebGetter brouser = new WebGetter();
            brouser.ShowDialog();
            access_token = brouser.access_token;
            user_id = brouser.user_id;
        }
		string  access_token;
		int     user_id;

		private void tb_stat_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			tb_posts.Checked = false;
			tb_stat.Checked = true;
		}
		
		private void tb_posts_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
			{
			tb_posts.Checked = true;
			tb_stat.Checked = false;
		}

		private void mainwindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (Global.temporary != null)
			{
				foreach(var file in Global.temporary)
					File.Delete(file);
			}
		}
	}
}