using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace GeoFoto
{
  public partial class FotoForm : Form
  {
    public FotoForm()
    {
      InitializeComponent();
    }


    private void DirFormButton_Click(object sender, EventArgs e)
    {
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        string dir = folderBrowserDialog.SelectedPath;
        FotoAlbum.PrzeszukajKatalog(dir);

        FotoGridView.AutoGenerateColumns = true;
        FotoGridView.DataSource = FotoAlbum.MojAlbum;
        FotoGridView.Columns[0].Width = FotoGridView.Width / 2;

        UstawGeotagibutton.Enabled = true;
        GeoOnlycheckBox.Enabled = true;
      }
    }

    private void OdczytanyGeotag(string fname)
    {
      try
      {
        if (FotoFormStripProgressBar.ProgressBar != null) FotoFormStripProgressBar.Value++;
        FotoFormStripLabel.Text = "Czytam geotag: " + fname;
        FotoGridView?.Refresh();
      }
      catch (NullReferenceException) { }
    }
    private async void UstawGeotagibutton_Click(object sender, EventArgs e)
    {
      UstawGeotagibutton.Enabled = false;
      FotoFormStripProgressBar.Maximum = FotoAlbum.MojAlbum.Count;
      FotoFormStripProgressBar.Value = 0;

      System.Console.WriteLine($"Watek:{System.Threading.Thread.CurrentThread.ManagedThreadId}");

      await FotoAlbum.CzytajGeotagi(OdczytanyGeotag);

      KoordynatyGroupBox.Enabled = true;
      FotoFormStripLabel.Text = "Done";
    }

    private void GeoOnlycheckBox_CheckedChanged(object sender, EventArgs e)
    {
      if (GeoOnlycheckBox.Checked)
      {
        FotoGridView.DataSource = (from f in FotoGridView.DataSource as List<Fotka>
                                   where f.Lat.Length > 1
                                   select f).ToList();

        FotoGridView.Refresh();
      }
      else
      {
        FotoGridView.DataSource = FotoAlbum.MojAlbum;
        FotoGridView.Refresh();
      }
    }




    private void LatBox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete) e.SuppressKeyPress = true;
    }
    private void LonBox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete) e.SuppressKeyPress = true;
    }
    private void DystansBox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete) e.SuppressKeyPress = true;
    }

    private double? CheckIsValidNumeric(char key, TextBox box)
    {
      try
      {
        string s;
        if (key == 0x08)     //backspace;
        {
          if ((box.SelectionStart > 0) && (box.SelectionLength == 0))
            s = box.Text.Remove(box.SelectionStart - 1, 1).ToString();
          else
            s = box.Text.Remove(box.SelectionStart, box.SelectionLength).ToString();
        }
        else
          s = box.Text.Remove(box.SelectionStart, box.SelectionLength).Insert(box.SelectionStart, key.ToString());
        if (s.Length > 0) return double.Parse(s);
        else return 0;
      }
      catch (System.FormatException) { return null; }
    }
    private void LatBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      double? d = CheckIsValidNumeric(e.KeyChar, LatBox);
      if ((d < -90) || (d > 90) || (d == null)) e.Handled = true;
    }
    private void LonBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      double? d = CheckIsValidNumeric(e.KeyChar, LonBox);
      if ((d < -180) || (d > 180) || (d == null)) e.Handled = true;
    }
    private void DystansBox_KeyPress(object sender, KeyPressEventArgs e)
    {

      double? d = CheckIsValidNumeric(e.KeyChar, DystansBox);
      if ((d < 0) || (d > 20036.5) || (d == null)) e.Handled = true;
    }



    private void FotoGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      string f = FotoGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
      FotoFormStripLabel.Text = f;

      if (FotoBox.Image != null) FotoBox.Image.Dispose();
      FotoBox.Image = System.Drawing.Image.FromFile(f);
    }

    private void SerchButton_Click(object sender, EventArgs e)
    {
      try
      {
        if ((LonBox.Text != "") && (LatBox.Text != "") && (DystansBox.Text != ""))
        {
          GeoOnlycheckBox.Enabled = false;
          FotoGridView.DataSource = (from f in FotoAlbum.MojAlbum
                                     where f.Lat.Length > 1
                                     where f.Lon.Length > 1
                                     where f.Odleglosc(double.Parse(LonBox.Text), double.Parse(LatBox.Text)) < double.Parse(DystansBox.Text)
                                     select f).ToList();
        }
      }
      catch (System.FormatException) { MessageBox.Show("Niewłaściwe dane"); }
    }


  }
}
