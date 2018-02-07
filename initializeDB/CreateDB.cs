
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using PersonalHomeGenNHibernate.CAD.PersonalHome;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGenNHibernate.CEN.PersonalHome;

namespace initializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                VariableEN variable = new VariableEN ();
                IVariableCAD _IVarCAD = new VariableCAD ();
                VariableCEN varCEN = new VariableCEN (_IVarCAD);

                PackEN pack = new PackEN ();
                IPackCAD _IPackCAD = new PackCAD ();
                PackCEN packCEN = new PackCEN (_IPackCAD);

                int idVAR1 = varCEN.Crear ("Tarima laminada", "Muy bonita", 120.23, "imagen", 10, "miniatura");
                int idVAR2 = varCEN.Crear ("Tarima flotante", "Muy fea", 100.10, "imagen", 10, "miniatura");

                int idPack1 = packCEN.Crear ("Pack A", "Familia A", "Descripci?n Pack A", "rojo", "PAA");
                int idPack2 = packCEN.Crear ("Pack B", "Familia A", "Descripci?n Pack B", "azul", "PAB");

                IList<int> variables = new List<int>();
                variables.Add (idVAR1);
                variables.Add (idVAR2);

                //packCEN.AsignarVariable(idPack1, variables);
                //packCEN.AsignarVariable(idPack2, variables);

                IList<int> packs = new List<int>();
                packs.Add (idPack1);
                packs.Add (idPack2);

                varCEN.AsignarPack (idVAR1, packs);
                varCEN.AsignarPack (idVAR2, packs);

                IAdminCAD _IAdminCAD = new AdminCAD();
                AdminCEN adminCEN = new AdminCEN(_IAdminCAD);

                adminCEN.CrearAdmin("tigran@safzero.com", "12345", "Tigran");

                /*List<PersonalHomeGenNHibernate.EN.Mediaplayer.MusicTrackEN> musicTracks = new List<PersonalHomeGenNHibernate.EN.Mediaplayer.MusicTrackEN>();
                 * PersonalHomeGenNHibernate.EN.Mediaplayer.UserEN userEN = new PersonalHomeGenNHibernate.EN.Mediaplayer.UserEN();
                 * PersonalHomeGenNHibernate.EN.Mediaplayer.ArtistEN artistEN = new PersonalHomeGenNHibernate.EN.Mediaplayer.ArtistEN();
                 * PersonalHomeGenNHibernate.EN.Mediaplayer.MusicTrackEN musicTrackEN = new PersonalHomeGenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * PersonalHomeGenNHibernate.CEN.Mediaplayer.ArtistCEN artistCEN = new PersonalHomeGenNHibernate.CEN.Mediaplayer.ArtistCEN();
                 * PersonalHomeGenNHibernate.CEN.Mediaplayer.UserCEN userCEN = new PersonalHomeGenNHibernate.CEN.Mediaplayer.UserCEN();
                 * PersonalHomeGenNHibernate.CEN.Mediaplayer.MusicTrackCEN musicTrackCEN = new PersonalHomeGenNHibernate.CEN.Mediaplayer.MusicTrackCEN();
                 * PersonalHomeGenNHibernate.CEN.Mediaplayer.PlayListCEN playListCEN = new PersonalHomeGenNHibernate.CEN.Mediaplayer.PlayListCEN();
                 *
                 *              //Add Users
                 * userEN.Email = "user@user.com";
                 * userEN.Name = "user";
                 * userEN.Surname = "userSurname";
                 * userEN.Password = "user";
                 * userCEN.New_(userEN.Name, userEN.Surname, userEN.Email, userEN.Password);
                 *
                 * //Add Music Track1
                 * musicTrackEN.Id = "http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "Beer Beer Beer Beer Beer Beer ..";
                 * musicTrackEN.Name = "Beer Beer Beer";
                 * musicTrackEN.Company = "Company";
                 * musicTrackEN.Cover = "http://www.tomasabraham.com.ar/cajadig/2007/images/nro18-2/beer1.jpg";
                 * musicTrackEN.Price = 20;
                 * musicTrackEN.Rating = 5;
                 * musicTrackEN.CommunityRating = 5;
                 * musicTrackEN.Duration = 200;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 * musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Add Music Track2
                 * musicTrackEN = new PersonalHomeGenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * musicTrackEN.Id = "http://www.goear.com/files/sst2/mp3files/01122006/681dabd7c2c03aad5f10a13abaa61f95.mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "";
                 * musicTrackEN.Name = "Chariots of Fire";
                 * musicTrackEN.Company = "Company 2";
                 * musicTrackEN.Cover = "http://www.tupelicula.es/imagenes/pelisonline/628.jpg";
                 * musicTrackEN.Price = 10;
                 * musicTrackEN.Rating = 3;
                 * musicTrackEN.CommunityRating = 2;
                 * musicTrackEN.Duration = 220;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 *              musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Add Music Track3
                 * musicTrackEN = new PersonalHomeGenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * musicTrackEN.Id = "http://www.goear.com/files/sst5/mp3files/12062009/833734cbbb8d43bb5393c18793783e6d.mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "";
                 * musicTrackEN.Name = "I Gotta Feeling";
                 * musicTrackEN.Company = "Company 3";
                 * musicTrackEN.Cover = "http://www.nuncamas.org/images_post/0981248470.jpg";
                 * musicTrackEN.Price = 14;
                 * musicTrackEN.Rating = 4;
                 * musicTrackEN.CommunityRating = 5;
                 * musicTrackEN.Duration = 180;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 *              musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Add Music Track4
                 * musicTrackEN = new PersonalHomeGenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * musicTrackEN.Id = "http://www.goear.com/files/sst5/mp3files/31052010/50c15dc1018ea9dcec455d7b78e7889c.mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "";
                 * musicTrackEN.Name = "Waka Waka World Cup 2010";
                 * musicTrackEN.Company = "Company 4";
                 * musicTrackEN.Cover = "http://carris.files.wordpress.com/2010/03/logosudafrica2010.jpg";
                 * musicTrackEN.Price = 22;
                 * musicTrackEN.Rating = 5;
                 * musicTrackEN.CommunityRating = 5;
                 * musicTrackEN.Duration = 189;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 *              musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Add PlayList 1
                 * int idPlayList = playListCEN.New_("List1", "This is my playList 1", "Rock", userEN);
                 * //Define tracks to Add to PlayList 1
                 * List<String> tracks = new List<string>();
                 * tracks.Add("http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3");
                 * tracks.Add("http://www.goear.com/files/sst5/mp3files/12062009/833734cbbb8d43bb5393c18793783e6d.mp3");
                 * tracks.Add("http://www.goear.com/files/sst5/mp3files/31052010/50c15dc1018ea9dcec455d7b78e7889c.mp3");
                 * //Add Songs to PlayList 1
                 * playListCEN.AddMusicTrack(idPlayList, tracks);
                 *
                 * //Add PlayList 2
                 * idPlayList = playListCEN.New_("List2", "This is my playList 2", "Pop", userEN);
                 * //Define tracks to Add to PlayList 2
                 * tracks = new List<string>();
                 * tracks.Add("http://www.goear.com/files/sst2/mp3files/01122006/681dabd7c2c03aad5f10a13abaa61f95.mp3");
                 * tracks.Add("http://www.goear.com/files/sst5/mp3files/12062009/833734cbbb8d43bb5393c18793783e6d.mp3");
                 * tracks.Add("http://www.goear.com/files/sst5/mp3files/31052010/50c15dc1018ea9dcec455d7b78e7889c.mp3");
                 * //Add Songs to PlayList 2
                 * playListCEN.AddMusicTrack(idPlayList, tracks);
                 *
                 * //Add PlayList 2
                 * idPlayList = playListCEN.New_("List2", "This is my playList 2", "Pop", userEN);
                 * //Define tracks to Add to PlayList 2
                 * tracks = new List<string>();
                 * tracks.Add("http://www.goear.com/files/sst2/mp3files/01122006/681dabd7c2c03aad5f10a13abaa61f95.mp3");
                 * tracks.Add("http://www.goear.com/files/sst5/mp3files/12062009/833734cbbb8d43bb5393c18793783e6d.mp3");
                 * tracks.Add("http://www.goear.com/files/sst5/mp3files/31052010/50c15dc1018ea9dcec455d7b78e7889c.mp3");
                 * //Add Songs to PlayList 2
                 * playListCEN.AddMusicTrack(idPlayList, tracks);
                 *
                 * //Add PlayList 3
                 * idPlayList = playListCEN.New_("List3", "This is my playList 3", "Pop", userEN);
                 * //Define tracks to Add to PlayList 3
                 * tracks = new List<string>();
                 * tracks.Add("http://www.goear.com/files/sst2/mp3files/01122006/681dabd7c2c03aad5f10a13abaa61f95.mp3");
                 * tracks.Add("http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3");
                 * tracks.Add("http://www.goear.com/files/sst5/mp3files/31052010/50c15dc1018ea9dcec455d7b78e7889c.mp3");
                 * //Add Songs to PlayList 3
                 * playListCEN.AddMusicTrack(idPlayList, tracks);
                 *
                 *
                 * //Define Artist 1
                 * List<PersonalHomeGenNHibernate.EN.Mediaplayer.ArtistEN> artists = new List<PersonalHomeGenNHibernate.EN.Mediaplayer.ArtistEN>();
                 * artistEN.Id = 1;
                 * artistEN.Name = "Youth of Britain";
                 * artists.Add(artistEN);
                 * artistCEN.New_(artistEN.Id, artistEN.Name);
                 * tracks = new List<string>();
                 * tracks.Add("http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3");
                 * artistCEN.AsignTrack(artistEN.Id, tracks);
                 * //Define Artist 2
                 * artistEN = new PersonalHomeGenNHibernate.EN.Mediaplayer.ArtistEN();
                 * artistEN.Id = 2;
                 * artistEN.Name = "Vangelis";
                 * artists.Add(artistEN);
                 * artistCEN.New_(artistEN.Id, artistEN.Name);
                 * tracks = new List<string>();
                 * tracks.Add("http://www.goear.com/files/sst2/mp3files/01122006/681dabd7c2c03aad5f10a13abaa61f95.mp3");
                 * artistCEN.AsignTrack(artistEN.Id, tracks);
                 * //Define Artist 3
                 * artistEN = new PersonalHomeGenNHibernate.EN.Mediaplayer.ArtistEN();
                 * artistEN.Id = 3;
                 * artistEN.Name = "Black Eyed Peas";
                 * artists.Add(artistEN);
                 * artistCEN.New_(artistEN.Id, artistEN.Name);
                 * tracks = new List<string>();
                 * tracks.Add("http://www.goear.com/files/sst5/mp3files/12062009/833734cbbb8d43bb5393c18793783e6d.mp3");
                 * artistCEN.AsignTrack(artistEN.Id, tracks);
                 * //Define Artist 4
                 * artistEN = new PersonalHomeGenNHibernate.EN.Mediaplayer.ArtistEN();
                 * artistEN.Id = 4;
                 * artistEN.Name = "Shakira";
                 * artists.Add(artistEN);
                 * artistCEN.New_(artistEN.Id, artistEN.Name);
                 * tracks = new List<string>();
                 * tracks.Add("http://www.goear.com/files/sst5/mp3files/31052010/50c15dc1018ea9dcec455d7b78e7889c.mp3");
                 * artistCEN.AsignTrack(artistEN.Id, tracks);
                 *
                 * //Define Album
                 * //PersonalHomeGenNHibernate.CEN.Mediaplayer.AlbumCEN albumCEN = new PersonalHomeGenNHibernate.CEN.Mediaplayer.AlbumCEN();
                 * //albumCEN.New_("Album 1", "This is a Album 1", artists, musicTracks);*/
                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                throw ex;
        }
}
}
}
