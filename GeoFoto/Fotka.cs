using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace GeoFoto
{
  public class Fotka
  {
    protected double _lat, _lon;
    protected string _name;
    protected static int unsuported = 0;
    public Fotka(string fileName)
    {
      _name = fileName;
      _lat = 361;
      _lon = 361;
    }

    public string Name { get { return _name; } }
    public string Lat { get { return _lat == 361 ? "-" : $"{_lat:F6}"; } }
    public string Lon { get { return _lat == 361 ? "-" : $"{_lon:F6}"; } }
    virtual public void CzytajGeotag() { }

    public double Odleglosc(double lon, double lat)
    {
      if ((_lat == 361) || (_lon == 361)) return -1;

      double lon1r, lon2r, lat1r, lat2r;

      lon1r = _lon * Math.PI / 180;
      lon2r = lon * Math.PI / 180;
      lat1r = _lat * Math.PI / 180;
      lat2r = lat * Math.PI / 180;

      return Math.Acos(Math.Sin(lat1r) * Math.Sin(lat2r) + Math.Cos(lat1r) * Math.Cos(lat2r) * Math.Cos(lon1r - lon2r)) * 6371;
    }
  }

  public class FotkaJPG : Fotka
  {
    public FotkaJPG(string fileName) : base(fileName) { }

    public override void CzytajGeotag()
    {
      using (Image theImage = new Bitmap(_name))
      {
        double d, m, s;
        double we = 0, ns = 0;
        int u;
        PropertyItem[] propItems = theImage.PropertyItems;
        System.Console.WriteLine($"{_name}:{System.Threading.Thread.CurrentThread.ManagedThreadId}");
        u = 0;
        foreach (PropertyItem item in propItems)
        {
          switch (item.Id)
          {
            case 1:
              ns = (item.Value[0] == 0x4e) || (item.Value[0] == 0x63) ? 1 : -1;   //N
              u++;
              break;
            case 2:
              if ((item.Type == 5) && (item.Len == 24))
              {
                d = (double)BitConverter.ToInt32(item.Value, 0) / BitConverter.ToInt32(item.Value, 4);
                m = (double)BitConverter.ToInt32(item.Value, 8) / BitConverter.ToInt32(item.Value, 12);
                s = (double)BitConverter.ToInt32(item.Value, 16) / BitConverter.ToInt32(item.Value, 20);
                _lat = d + m / 60 + s / 3600;
              }
              u++;
              break;
            case 3:
              we = (item.Value[0] == 0x57) || (item.Value[0] == 0x77) ? -1 : 1;  //W
              u++;
              break;
            case 4:
              if ((item.Type == 5) && (item.Len == 24))
              {
                d = (double)BitConverter.ToInt32(item.Value, 0) / BitConverter.ToInt32(item.Value, 4);
                m = (double)BitConverter.ToInt32(item.Value, 8) / BitConverter.ToInt32(item.Value, 12);
                s = (double)BitConverter.ToInt32(item.Value, 16) / BitConverter.ToInt32(item.Value, 20);
                _lon = d + m / 60 + s / 3600;
              }
              u++;
              break;
          }
        }
        if (u == 4)
        {
          _lat *= ns;
          _lon *= we;
        }
        else
          unsuported++;
      }
    }
  }

  public class FotkaGIF : Fotka
  {
    public FotkaGIF(string fileName) : base(fileName) { }
    public override void CzytajGeotag() { unsuported++; }
  }
}
