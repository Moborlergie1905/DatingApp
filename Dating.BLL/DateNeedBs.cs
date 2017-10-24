using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dating.BOL;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Dating.BLL
{
    public class DateNeedBs
    {
        ConnectDB connection;
        string conString;

        public DateNeedBs()
        {
            connection = new ConnectDB();
            conString = connection.SetConnection;
        }

        public void Insert(DateRegister date)
        {
            using(SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("InsertDateNeed", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMinAge = new SqlParameter();
                paraMinAge.ParameterName = "@ageMin";
                paraMinAge.Value = date.AgeMin;
                cmd.Parameters.Add(paraMinAge);

                SqlParameter paraMaxAge = new SqlParameter();
                paraMaxAge.ParameterName = "@ageMax";
                paraMaxAge.Value = date.AgeMax;
                cmd.Parameters.Add(paraMaxAge);

                SqlParameter paraLocation = new SqlParameter();
                paraLocation.ParameterName = "@location";
                paraLocation.Value = date.City;
                cmd.Parameters.Add(paraLocation);

                SqlParameter paraEthnicity = new SqlParameter();
                paraEthnicity.ParameterName = "@ethnicity";
                paraEthnicity.Value = date.Ethnicity;
                cmd.Parameters.Add(paraEthnicity);

                SqlParameter paraReligion = new SqlParameter();
                paraReligion.ParameterName = "@religion";
                paraReligion.Value = date.Religion;
                cmd.Parameters.Add(paraReligion);

                SqlParameter paraEducation = new SqlParameter();
                paraEducation.ParameterName = "@education";
                paraEducation.Value = date.Education;
                cmd.Parameters.Add(paraEducation);

                SqlParameter paraRelation = new SqlParameter();
                paraRelation.ParameterName = "@relationshipType";
                paraRelation.Value = date.RelationshipType;
                cmd.Parameters.Add(paraRelation);

                SqlParameter paraBodyType = new SqlParameter();
                paraBodyType.ParameterName = "@bodyType";
                paraBodyType.Value = date.BodyType;
                cmd.Parameters.Add(paraBodyType);

                SqlParameter paraHeight = new SqlParameter();
                paraHeight.ParameterName = "@height";
                paraHeight.Value = date.Height;
                cmd.Parameters.Add(paraHeight);

                SqlParameter paraWeight = new SqlParameter();
                paraWeight.ParameterName = "@weight";
                paraWeight.Value = date.Weight;
                cmd.Parameters.Add(paraWeight);

                SqlParameter paraHasChild = new SqlParameter();
                paraHasChild.ParameterName = "@hasChild";
                paraHasChild.Value = date.HasChild;
                cmd.Parameters.Add(paraHasChild);

                SqlParameter paraWantChild = new SqlParameter();
                paraWantChild.ParameterName = "@wantChild";
                paraWantChild.Value = date.WantChild;
                cmd.Parameters.Add(paraWantChild);

                SqlParameter paraSmoke = new SqlParameter();
                paraSmoke.ParameterName = "@smoke";
                paraSmoke.Value = date.Smoke;
                cmd.Parameters.Add(paraSmoke);

                SqlParameter paraDrink = new SqlParameter();
                paraDrink.ParameterName = "@drink";
                paraDrink.Value = date.Drink;
                cmd.Parameters.Add(paraDrink);
            }
        }

        public void Update(DateRegister date)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("UpdateDateNeed", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParaId = new SqlParameter();
                ParaId.ParameterName = "@id";
                ParaId.Value = date.ID;
                cmd.Parameters.Add(ParaId);

                SqlParameter paraMinAge = new SqlParameter();
                paraMinAge.ParameterName = "@ageMin";
                paraMinAge.Value = date.AgeMin;
                cmd.Parameters.Add(paraMinAge);

                SqlParameter paraMaxAge = new SqlParameter();
                paraMaxAge.ParameterName = "@ageMax";
                paraMaxAge.Value = date.AgeMax;
                cmd.Parameters.Add(paraMaxAge);

                SqlParameter paraLocation = new SqlParameter();
                paraLocation.ParameterName = "@location";
                paraLocation.Value = date.City;
                cmd.Parameters.Add(paraLocation);

                SqlParameter paraEthnicity = new SqlParameter();
                paraEthnicity.ParameterName = "@ethnicity";
                paraEthnicity.Value = date.Ethnicity;
                cmd.Parameters.Add(paraEthnicity);

                SqlParameter paraReligion = new SqlParameter();
                paraReligion.ParameterName = "@religion";
                paraReligion.Value = date.Religion;
                cmd.Parameters.Add(paraReligion);

                SqlParameter paraEducation = new SqlParameter();
                paraEducation.ParameterName = "@education";
                paraEducation.Value = date.Education;
                cmd.Parameters.Add(paraEducation);

                SqlParameter paraRelation = new SqlParameter();
                paraRelation.ParameterName = "@relationshipType";
                paraRelation.Value = date.RelationshipType;
                cmd.Parameters.Add(paraRelation);

                SqlParameter paraBodyType = new SqlParameter();
                paraBodyType.ParameterName = "@bodyType";
                paraBodyType.Value = date.BodyType;
                cmd.Parameters.Add(paraBodyType);

                SqlParameter paraHeight = new SqlParameter();
                paraHeight.ParameterName = "@height";
                paraHeight.Value = date.Height;
                cmd.Parameters.Add(paraHeight);

                SqlParameter paraWeight = new SqlParameter();
                paraWeight.ParameterName = "@weight";
                paraWeight.Value = date.Weight;
                cmd.Parameters.Add(paraWeight);

                SqlParameter paraHasChild = new SqlParameter();
                paraHasChild.ParameterName = "@hasChild";
                paraHasChild.Value = date.HasChild;
                cmd.Parameters.Add(paraHasChild);

                SqlParameter paraWantChild = new SqlParameter();
                paraWantChild.ParameterName = "@wantChild";
                paraWantChild.Value = date.WantChild;
                cmd.Parameters.Add(paraWantChild);

                SqlParameter paraSmoke = new SqlParameter();
                paraSmoke.ParameterName = "@smoke";
                paraSmoke.Value = date.Smoke;
                cmd.Parameters.Add(paraSmoke);

                SqlParameter paraDrink = new SqlParameter();
                paraDrink.ParameterName = "@drink";
                paraDrink.Value = date.Drink;
                cmd.Parameters.Add(paraDrink);
            }
        }
    }
}
