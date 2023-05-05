// 27/4/23
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