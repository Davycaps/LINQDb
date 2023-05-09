Guida per l'utilizzo del programma

1)Come creare un file dotnet<br />
  aprire il terminale e digitare:<br />
```
dotnet new console
```
2)Come aggiungere la libreria "SQLITE"<br />
digitare nel terminale:
```
dotnet add package sqlite-net-pcl
``` 
3)Link per poter scaricare il file:"chinook.db"<br />
  https://www.sqlitetutorial.net/sqlite-sample-database/




4)Come visualizzare a schermo il file DataBase:<br />
  cercare tra le estensioni "SQLite Viewer" e scaricarlo<br />

![image](https://user-images.githubusercontent.com/116790994/236402712-b6be1f6b-2eb5-40e6-915c-8c5ccf16b5c5.png)

Il codice utilizzato:
```
﻿// 27/4/23
//connessione al database

using SQLite;

SQLiteConnection cn1 = new SQLiteConnection("chinook.db");

var tblArtists = cn1.Query<Artist>("select * from artists");

Console.WriteLine( $"in questa tabella ci sono {tblArtists.Count} record");

//4/5/23
var temporanea = tblArtists.OrderByDescending(x => x.Name).Max( y = y.ArtistId );
console.WriteLine( $"{temporanea}");

foreach( var artista in tblArtist )
{
    console.WriteLine( $"{artista.Name}");
}

console.WriteLine( $"{temporanea}");
//fine main... inizio dichiarazioni classi-----------------------
public class Artist
{
    public int ArtistId{get;set;}
    public string Name{get;set;}
}
```

