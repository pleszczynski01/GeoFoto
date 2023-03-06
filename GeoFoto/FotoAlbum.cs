using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GeoFoto
{
  public static class FotoAlbum
  {
    private static readonly List<Fotka> mojAlbum = new List<Fotka>();

    public static List<Fotka> MojAlbum { get { return mojAlbum; } }

    internal static void PrzeszukajKatalog(string dir)
    {
      DirectoryInfo dirInfo = new DirectoryInfo(dir);
      if (dirInfo.Exists)
      {
        FileSystemInfo[] pliki = dirInfo.GetFileSystemInfos();

        foreach (FileSystemInfo plik in pliki)
        {
          if (plik.Attributes == FileAttributes.Directory)
          {
            PrzeszukajKatalog(plik.FullName);
          }
          else
          {
            switch (plik.Extension.ToLower())
            {
              case ".jpg":
                mojAlbum.Add(new FotkaJPG(plik.FullName));
                break;
              case ".gif":
                mojAlbum.Add(new FotkaGIF(plik.FullName));
                break;
            }
          }
        }
      }
    }

    internal static async Task CzytajGeotagi(Action<string> whenDone = null)

    {
      System.Console.WriteLine($"Watek:{System.Threading.Thread.CurrentThread.ManagedThreadId}");

      foreach (Fotka fotka in mojAlbum)
      {
        await Task.Run(fotka.CzytajGeotag);
        whenDone?.Invoke(fotka.Name);
      }
    }
  }
}

