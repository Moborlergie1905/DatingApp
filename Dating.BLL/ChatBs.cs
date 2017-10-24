using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dating.BOL;
using System.Data.SqlClient;
using System.Data;

namespace Dating.BLL
{
    public class ChatBs
    {
        ConnectDB connection;
        string conString;

        public ChatBs()
        {
            connection = new ConnectDB();
            conString = connection.SetConnection;
        }

        public IEnumerable<Message> GetAll
        {            
            get
            {                
                List<Message> messages = new List<Message>();

                using(SqlConnection con = new SqlConnection(conString))
                {
                    SqlCommand cmd = new SqlCommand("GetAllChats", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    Message message = new Message();
                    while (rdr.Read())
                    {
                        message.ID = Convert.ToInt32(rdr["ID"]);
                        message.ProfileID = Convert.ToInt32(rdr["Sender"]);
                        message.Recipient = Convert.ToInt32("Receiver");
                        message.MsgContent = rdr["Msg"].ToString();
                        message.TimeSent = Convert.ToDateTime(rdr["TimeSent"]);

                        messages.Add(message);
                    }
                    return messages;
                }

            }
        }

        public Message GetPerChat(int sender, int receiver)
        {
            Message message = new Message();
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "LoadChat";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraSender = new SqlParameter();
                paraSender.ParameterName = "@sender";
                paraSender.Value = sender;
                cmd.Parameters.Add(paraSender);

                SqlParameter paraReceiver = new SqlParameter();
                paraReceiver.ParameterName = "@receiver";
                paraReceiver.Value = receiver;
                cmd.Parameters.Add(paraReceiver);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    message.ID = Convert.ToInt32(rdr["ID"]);
                    message.ProfileID = Convert.ToInt32(rdr["Sender"]);
                    message.Recipient = Convert.ToInt32("Receiver");
                    message.MsgContent = rdr["Msg"].ToString();
                    message.TimeSent = Convert.ToDateTime(rdr["TimeSent"]);
                }               
            }
            return message;
                    
        }

        public void Insert(Message message)
        {
            using(SqlConnection con = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand("SendChat", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraSender = new SqlParameter();
                paraSender.ParameterName = "@sender";
                paraSender.Value = message.ProfileID;
                cmd.Parameters.Add(paraSender);


            }
        }
    }
}
