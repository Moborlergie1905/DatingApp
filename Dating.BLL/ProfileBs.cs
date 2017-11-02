using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dating.BOL;
using System.Data.SqlClient;
using System.Data;

namespace Dating.BLL
{
    public class ProfileBs
    {
        ConnectDB connection;
        string conString;

        public ProfileBs()
        {
            connection = new ConnectDB();
            conString = connection.SetConnection;
        }

        public IEnumerable<Profile> GetAll
        {
            get
            {
                List<Profile> profiles = new List<Profile>();

                using (SqlConnection con = new SqlConnection(conString))
                {
                    SqlCommand cmd = new SqlCommand("FetchAllProfile", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            Profile profile = new Profile();
                            profile.ID = Convert.ToInt32(rdr["ID"]);
                            profile.FirstName = rdr["FirstName"].ToString();
                            profile.LastName = rdr["LastName"].ToString();
                            profile.Email = rdr["Email"].ToString();
                            profile.Gender = rdr["Gender"].ToString();
                            profile.DOB = Convert.ToDateTime(rdr["DOB"]);
                            profile.Country = rdr["Country"].ToString();
                            profile.City = rdr["City"].ToString();
                            profile.Province = rdr["Province"].ToString();
                            profile.Marital = rdr["Marital"].ToString();
                            profile.Height = rdr["Height"].ToString();
                            profile.Weight = rdr["Weight"].ToString();
                            profile.BodyType = rdr["BodyType"].ToString();
                            profile.HaveChild = rdr["Has_Children"].ToString();
                            profile.WantChild = rdr["Want_Children"].ToString();
                            profile.Education = rdr["Education"].ToString();
                            profile.Ethnicity = rdr["Ethnicity"].ToString();
                            profile.Occupation = rdr["Occupation"].ToString();
                            profile.RelationshipType = rdr["Relationship"].ToString();
                            profile.Religion = rdr["Religion"].ToString();
                            profile.Mobile = rdr["Mobile"].ToString();
                            profile.Nickname = rdr["Nickname"].ToString();
                            profile.Smoke = rdr["Smoke"].ToString();
                            profile.Drink = rdr["Drink"].ToString();
                            profile.Desc = rdr["Self_Desc"].ToString();
                            profile.IsActivated = rdr["Is_Activated"].ToString();
                            profiles.Add(profile);
                        }
                        
                    }

                    return profiles;
                }
            }
        }

        public Profile GetById(int Id)
        {
            Profile profile = new Profile(); 
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("GetProfileById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@Id";
                paramId.Value = Id;
                cmd.Parameters.Add(paramId);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {                    
                    profile.FirstName = rdr["FirstName"].ToString();
                    profile.LastName = rdr["LastName"].ToString();
                    profile.Email = rdr["Email"].ToString();
                    profile.Gender = rdr["Gender"].ToString();
                    profile.DOB = Convert.ToDateTime(rdr["DOB"]);
                    profile.Country = rdr["Country"].ToString();
                    profile.City = rdr["City"].ToString();
                    profile.Province = rdr["Province"].ToString();
                    profile.Marital = rdr["Marital"].ToString();
                    profile.Height = rdr["Height"].ToString();
                    profile.Weight = rdr["Weight"].ToString();
                    profile.BodyType = rdr["BodyType"].ToString();
                    profile.HaveChild = rdr["Has_Children"].ToString();
                    profile.WantChild = rdr["Want_Children"].ToString();
                    profile.Education = rdr["Education"].ToString();
                    profile.Ethnicity = rdr["Ethnicity"].ToString();
                    profile.Occupation = rdr["Occupation"].ToString();
                    profile.RelationshipType = rdr["Relationship"].ToString();
                    profile.Religion = rdr["Religion"].ToString();
                    profile.Mobile = rdr["Mobile"].ToString();
                    profile.Nickname = rdr["Nickname"].ToString();
                    profile.Smoke = rdr["Smoke"].ToString();
                    profile.Drink = rdr["Drink"].ToString();
                    profile.Desc = rdr["Self_Desc"].ToString();
                    profile.IsActivated = rdr["Is_Activated"].ToString();
                }
            }
            return profile;
        }

        public void Insert(Profile profile)
        {           
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("spInsertProfile", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraFirstName = new SqlParameter();
                paraFirstName.ParameterName = "@firstName";
                paraFirstName.Value = profile.FirstName;
                cmd.Parameters.Add(paraFirstName);

                SqlParameter paraLastLame = new SqlParameter();
                paraLastLame.ParameterName = "@lastName";
                paraLastLame.Value = profile.LastName;
                cmd.Parameters.Add(paraLastLame);

                SqlParameter paraGender = new SqlParameter();
                paraGender.ParameterName = "@gender";
                paraGender.Value = profile.Gender;
                cmd.Parameters.Add(paraGender);

                SqlParameter paraDob = new SqlParameter();
                paraDob.ParameterName = "@dob";
                paraDob.Value = profile.DOB;
                cmd.Parameters.Add(paraDob);

                SqlParameter paraMarital = new SqlParameter();
                paraMarital.ParameterName = "@marital";
                paraMarital.Value = profile.Marital;
                cmd.Parameters.Add(paraMarital);

                SqlParameter paraEmail = new SqlParameter();
                paraEmail.ParameterName = "@email";
                paraEmail.Value = profile.Email;
                cmd.Parameters.Add(paraEmail);

                SqlParameter paraPassword = new SqlParameter();
                paraPassword.ParameterName = "@password";
                paraPassword.Value = profile.Password;
                cmd.Parameters.Add(paraPassword);

                SqlParameter paraCountry = new SqlParameter();
                paraCountry.ParameterName = "@country";
                paraCountry.Value = profile.Country;
                cmd.Parameters.Add(paraCountry);

                SqlParameter paraProvince = new SqlParameter();
                paraProvince.ParameterName = "@province";
                paraProvince.Value = profile.Province;
                cmd.Parameters.Add(paraProvince);

                SqlParameter paraCity = new SqlParameter();
                paraCity.ParameterName = "@city";
                paraCity.Value = profile.City;
                cmd.Parameters.Add(paraCity);

                SqlParameter paraEducation = new SqlParameter();
                paraEducation.ParameterName = "@education";
                paraEducation.Value = profile.Education;
                cmd.Parameters.Add(paraEducation);

                SqlParameter paraOccupation = new SqlParameter();
                paraOccupation.ParameterName = "@occupation";
                paraOccupation.Value = profile.Occupation;
                cmd.Parameters.Add(paraOccupation);

                SqlParameter paraEthnicity = new SqlParameter();
                paraEthnicity.ParameterName = "@ethnicity";
                paraEthnicity.Value = profile.Ethnicity;
                cmd.Parameters.Add(paraEthnicity);

                SqlParameter paraReligon = new SqlParameter();
                paraReligon.ParameterName = "@religion";
                paraReligon.Value = profile.Religion;
                cmd.Parameters.Add(paraReligon);

                SqlParameter paraHeight = new SqlParameter();
                paraHeight.ParameterName = "@height";
                paraHeight.Value = profile.Height;
                cmd.Parameters.Add(paraHeight);

                SqlParameter paraWeight = new SqlParameter();
                paraWeight.ParameterName = "@weight";
                paraWeight.Value = profile.Weight;
                cmd.Parameters.Add(paraWeight);

                SqlParameter paraBodyType = new SqlParameter();
                paraBodyType.ParameterName = "@body_type";
                paraBodyType.Value = profile.BodyType;
                cmd.Parameters.Add(paraBodyType);

                SqlParameter paraHasChild = new SqlParameter();
                paraHasChild.ParameterName = "@has_child";
                paraHasChild.Value = profile.HaveChild;
                cmd.Parameters.Add(paraHasChild);

                SqlParameter paraWantChild = new SqlParameter();
                paraWantChild.ParameterName = "@want_child";
                paraWantChild.Value = profile.WantChild;
                cmd.Parameters.Add(paraWantChild);

                SqlParameter paraDrink = new SqlParameter();
                paraDrink.ParameterName = "@drink";
                paraDrink.Value = profile.Drink;
                cmd.Parameters.Add(paraDrink);

                SqlParameter paraSmoke = new SqlParameter();
                paraSmoke.ParameterName = "@smoke";
                paraSmoke.Value = profile.Smoke;
                cmd.Parameters.Add(paraSmoke);

                SqlParameter paraRelationship = new SqlParameter();
                paraRelationship.ParameterName = "@relationship_type";
                paraRelationship.Value = profile.RelationshipType;
                cmd.Parameters.Add(paraRelationship);

                SqlParameter paraNickname = new SqlParameter();
                paraNickname.ParameterName = "@nickname";
                paraNickname.Value = profile.Nickname;
                cmd.Parameters.Add(paraNickname);

                SqlParameter paraMobile = new SqlParameter();
                paraMobile.ParameterName = "@mobile";
                paraMobile.Value = profile.Mobile;
                cmd.Parameters.Add(paraMobile);

                SqlParameter paraDesc = new SqlParameter();
                paraDesc.ParameterName = "@description";
                paraDesc.Value = profile.Desc;
                cmd.Parameters.Add(paraDesc);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Profile profile)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("UpdateProfile", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParaId = new SqlParameter();
                ParaId.ParameterName = "@Id";
                ParaId.Value = profile.ID;
                cmd.Parameters.Add(ParaId);

                SqlParameter paraFirstName = new SqlParameter();
                paraFirstName.ParameterName = "@firstName";
                paraFirstName.Value = profile.FirstName;
                cmd.Parameters.Add(paraFirstName);

                SqlParameter paraLastLame = new SqlParameter();
                paraLastLame.ParameterName = "@lastName";
                paraLastLame.Value = profile.LastName;
                cmd.Parameters.Add(paraLastLame);

                SqlParameter paraGender = new SqlParameter();
                paraGender.ParameterName = "@gender";
                paraGender.Value = profile.Gender;
                cmd.Parameters.Add(paraGender);

                SqlParameter paraDob = new SqlParameter();
                paraDob.ParameterName = "@dob";
                paraDob.Value = profile.DOB;
                cmd.Parameters.Add(paraDob);

                SqlParameter paraMarital = new SqlParameter();
                paraMarital.ParameterName = "@marital";
                paraMarital.Value = profile.Marital;
                cmd.Parameters.Add(paraMarital);

                SqlParameter paraEmail = new SqlParameter();
                paraEmail.ParameterName = "@email";
                paraEmail.Value = profile.Email;
                cmd.Parameters.Add(paraEmail);

                SqlParameter paraPassword = new SqlParameter();
                paraPassword.ParameterName = "@password";
                paraPassword.Value = profile.Password;
                cmd.Parameters.Add(paraPassword);

                SqlParameter paraCountry = new SqlParameter();
                paraCountry.ParameterName = "@country";
                paraCountry.Value = profile.Country;
                cmd.Parameters.Add(paraCountry);

                SqlParameter paraProvince = new SqlParameter();
                paraProvince.ParameterName = "@province";
                paraProvince.Value = profile.Province;
                cmd.Parameters.Add(paraProvince);

                SqlParameter paraCity = new SqlParameter();
                paraCity.ParameterName = "@city";
                paraCity.Value = profile.City;
                cmd.Parameters.Add(paraCity);

                SqlParameter paraEducation = new SqlParameter();
                paraEducation.ParameterName = "@education";
                paraEducation.Value = profile.Education;
                cmd.Parameters.Add(paraEducation);

                SqlParameter paraOccupation = new SqlParameter();
                paraOccupation.ParameterName = "@occupation";
                paraOccupation.Value = profile.Occupation;
                cmd.Parameters.Add(paraOccupation);

                SqlParameter paraEthnicity = new SqlParameter();
                paraEthnicity.ParameterName = "@ethnicity";
                paraEthnicity.Value = profile.Ethnicity;
                cmd.Parameters.Add(paraEthnicity);

                SqlParameter paraReligon = new SqlParameter();
                paraReligon.ParameterName = "@religion";
                paraReligon.Value = profile.Religion;
                cmd.Parameters.Add(paraReligon);

                SqlParameter paraHeight = new SqlParameter();
                paraHeight.ParameterName = "@height";
                paraHeight.Value = profile.Height;
                cmd.Parameters.Add(paraHeight);

                SqlParameter paraWeight = new SqlParameter();
                paraWeight.ParameterName = "@weight";
                paraWeight.Value = profile.Weight;
                cmd.Parameters.Add(paraWeight);

                SqlParameter paraBodyType = new SqlParameter();
                paraBodyType.ParameterName = "@body_type";
                paraBodyType.Value = profile.BodyType;
                cmd.Parameters.Add(paraBodyType);

                SqlParameter paraHasChild = new SqlParameter();
                paraHasChild.ParameterName = "@has_child";
                paraHasChild.Value = profile.HaveChild;
                cmd.Parameters.Add(paraHasChild);

                SqlParameter paraWantChild = new SqlParameter();
                paraWantChild.ParameterName = "@want_child";
                paraWantChild.Value = profile.WantChild;
                cmd.Parameters.Add(paraWantChild);

                SqlParameter paraDrink = new SqlParameter();
                paraDrink.ParameterName = "@drink";
                paraDrink.Value = profile.Drink;
                cmd.Parameters.Add(paraDrink);

                SqlParameter paraSmoke = new SqlParameter();
                paraSmoke.ParameterName = "@smoke";
                paraSmoke.Value = profile.Smoke;
                cmd.Parameters.Add(paraSmoke);

                SqlParameter paraRelationship = new SqlParameter();
                paraRelationship.ParameterName = "@relationship_type";
                paraRelationship.Value = profile.RelationshipType;
                cmd.Parameters.Add(paraRelationship);

                SqlParameter paraNickname = new SqlParameter();
                paraNickname.ParameterName = "@nickname";
                paraNickname.Value = profile.Nickname;
                cmd.Parameters.Add(paraNickname);

                SqlParameter paraMobile = new SqlParameter();
                paraMobile.ParameterName = "@mobile";
                paraMobile.Value = profile.Mobile;
                cmd.Parameters.Add(paraMobile);

                SqlParameter paraDesc = new SqlParameter();
                paraDesc.ParameterName = "@description";
                paraDesc.Value = profile.Desc;
                cmd.Parameters.Add(paraDesc);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("DeleteProfile", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@Id";
                paramId.Value = Id;
                cmd.Parameters.Add(paramId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Profile> DefaultMatches(int Id)
        {

            List<Profile> matches = new List<Profile>();
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("getSearchCriteria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@Id";
                paramId.Value = Id;
                cmd.Parameters.Add(paramId);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Profile match = new Profile();
                    match.ID = Convert.ToInt32(rdr["ID"]);
                    match.FirstName = rdr["FrstName"].ToString();
                    match.LastName = rdr["LastName"].ToString();
                    match.Gender = rdr["Gender"].ToString();
                    match.Age = Convert.ToInt32(rdr["Age"]);

                    matches.Add(match);
                }
                return matches;
            }
        }

    }
}
