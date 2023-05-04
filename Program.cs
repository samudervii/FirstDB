﻿using SQLite;

Console.WriteLine("Hello World");

SQLiteConnection cnl = new SQLiteConnection("chinook.db");
var tblArtist = cnl.Query<Artist>("select * from artists");
Console.WriteLine( $"In questa tabella ci sono {tblArtist.Count} record!");

public class Artist
{
    public int ArtistId{get; set;}
    public string Name{get; set;}
}
