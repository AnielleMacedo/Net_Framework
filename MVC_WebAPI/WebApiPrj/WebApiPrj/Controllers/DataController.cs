using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPrj.Models;

namespace WebApiPrj.Controllers
{
    public class DataController : ApiController
    {
        public Matches Get(int id)
        {
            Matches resMatch;
            using (MyDbEntities db = new MyDbEntities())
            {
                resMatch = db.Matches.Where(match => match.Id == id).FirstOrDefault();
            }

            return resMatch;

        }

        public List<Matches> Get()
        {
            List<Matches> matches;
            using (MyDbEntities db = new MyDbEntities())
            {
                matches = db.Matches.ToList();
            }

            return matches;


            #region old code
            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            //{
            //    SqlCommand command = new SqlCommand("SELECT * FROM Matches", conn);
            //    conn.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    try
            //    {
            //        while (reader.Read())
            //        {
            //            SportMatch match = new SportMatch();
            //            match.Id = (int)reader["Id"];
            //            match.AwayScore = (int)reader["AwayScore"];
            //            match.HomeScore = (int)reader["HomeScore"];
            //            match.AwayTeam = reader["AwayTeam"].ToString();
            //            match.HomeTeam = reader["HomeTeam"].ToString();
            //            match.Day = DateTime.Parse(reader["Date"].ToString());

            //            matches.Add(match);
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //    finally
            //    {
            //        reader.Close();
            //    }
            //}

            //return matches;
            #endregion
        }

        [Route("api/data/getStadium/{matchId}")]
        public MatchStadium GetStadiumFromMatch(int matchId)
        {
            MatchStadium resMatch;
            using (MyDbEntities db = new MyDbEntities())
            {
                resMatch = db.Matches
                            .Join(db.Stadium,
                            match => match.StadiumId,
                            stadium => stadium.Id,
                            (match, stadium) => new MatchStadium()
                            {
                                    MatchId = match.Id,
                                    AwayScore = match.AwayScore,
                                    AwayTeam = match.AwayTeam,
                                    HomeScore = match.HomeScore,
                                    HomeTeam = match.HomeTeam,
                                    Date = match.Date,
                                    Name = stadium.Name,
                                    Venue = stadium.Venue
                            })
                            .Where(x => x.MatchId == matchId)
                            .FirstOrDefault();

            }
            return resMatch;

        }

        [Route("customApi/test/{awayTeamId}/{homeTeamId}")]
        public string GetStadiumFromMatch(int awayTeamId, int homeTeamId)
        {
            return "Numero Inserito: " + awayTeamId;
        }


        //creare tabella con dei giocatori 
        //ci sarà una terza tabella di collegamento (N:N) 
        //con giocatore/partita in cui ha segnato

        //api -> nome e cognome di un giocatore, restituire anagrafica + n° gol segnati
    }
}
