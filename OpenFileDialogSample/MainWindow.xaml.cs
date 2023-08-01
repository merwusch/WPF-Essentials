﻿using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OpenFileDialogSample
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow:Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void btnOpenFile_Click(object sender, RoutedEventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
      if( openFileDialog.ShowDialog() == true )
        txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
    }

    private void btnOpenFiles_Click(object sender, RoutedEventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Multiselect = true;
      openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
      openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      if( openFileDialog.ShowDialog() == true )
      {
        foreach( string filename in openFileDialog.FileNames )
          lbFiles.Items.Add(System.IO.Path.GetFileName(filename));
      }
    }
  }
}
