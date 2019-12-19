using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using Repository.Poco;

namespace Repository.SqlRepository
{
    public interface ISqlQuery
    {
        IEnumerable<MatchPoco> ListOfMatches(DateTime startDateMatch);
    }
    public class SqlQuery : ISqlQuery
    {

        public IEnumerable<MatchPoco> ListOfMatches(DateTime startDateMatch)
        {
            var connectionString = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var sql = $"select m.OfficialMatchName,m.CompetitionName,m.RoundName,m.datematch,m.DateMatchTimeString " +
                          $"from FLV_match m " +
                          $"where TypeTeam <> 8 and DateMatch > '{startDateMatch}' and statusCompetition = 1 " +
                          $"order by DateMatch asc ";

                IEnumerable<MatchPoco> listOfMatches = connection.Query<MatchPoco>(sql);
                return listOfMatches;
            }


        }


    }
}
