using System;
using System.Collections.Generic;
using System.Text;
using LibraryManager.Entities;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManager.Repositories
{
    public class SqlMemberRepository : IMemberRepository
    {
        private readonly string _connectionString;

        public SqlMemberRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        //no check if input args are null
        public IEnumerable<Member> SelectMembers(string filterName, string filterValue)
        {
            string MemberQuery;
            if (filterName == "")
            {
                MemberQuery = "SELECT [Id], [PassportId], [PhotoId], [FirstName], [SecondName], [DateOfMembership], [Phone], [Address], [Email], [Deleted] FROM [dbo].[tblMember] WHERE [Deleted] <> 1";
            }
            else
            {
                MemberQuery = String.Format("SELECT [Id], [PassportId], [PhotoId], [FirstName], [SecondName], [DateOfMembership], [Phone], [Address], [Email], [Deleted] FROM [dbo].[tblMember] WHERE [{0}] LIKE '%{1}%' AND [Deleted] <> 1", filterName, filterValue);
            }

            List<Member> memberList = new List<Member>();
            Member member;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = MemberQuery;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            member = new Member();
                            member.PassportId = (string)reader["PassportId"];
                            member.FirstName = (string)reader["FirstName"];
                            member.SecondName = (string)reader["SecondName"];
                            member.DateOfMembership = ((DateTime)reader["DateOfMembership"]).ToString();                 
                            member.Phone = (string)reader["Phone"];
                            member.Address = (string)reader["Address"];
                            member.Email = (string)reader["Email"];
                            member.Deleted = (bool)reader["Deleted"];
                            member.Photo = (byte[])reader["PhotoId"];
                         
                            memberList.Add(member);
                        }                        
                    }
                }
            }

            return memberList;
        }
        public IEnumerable<MemberIdInfo> SelectMembersIdInfo(string filterName, string filterValue)
        {
            string MemberQuery;
            if (filterName == "")
            {
                MemberQuery = "SELECT [Id], [PassportId], [PhotoId], [FirstName], [SecondName], [DateOfMembership], [Phone], [Address], [Email], [Deleted] FROM [dbo].[tblMember] WHERE [Deleted] <> 1";
            }
            else
            {
                MemberQuery = String.Format("SELECT [Id], [PassportId], [PhotoId], [FirstName], [SecondName], [DateOfMembership], [Phone], [Address], [Email], [Deleted] FROM [dbo].[tblMember] WHERE [{0}] LIKE '%{1}%' AND [Deleted] <> 1", filterName, filterValue);
            }

            List<MemberIdInfo> memberList = new List<MemberIdInfo>();
            MemberIdInfo member;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = MemberQuery;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            member = new MemberIdInfo();
                            member.PassportId = (string)reader["PassportId"];
                            member.FirstName = (string)reader["FirstName"];
                            member.SecondName = (string)reader["SecondName"];
                            member.DateOfMembership = ((DateTime)reader["DateOfMembership"]).ToString();

                            memberList.Add(member);
                        }
                    }
                }
            }

            return memberList;
        }
        public void AddMember(Member memberToAdd)
        {
            if(memberToAdd == null)
            {
                throw new Exception("No member to add");
            }

            string memberInsertQuery = "IF NOT EXISTS (SELECT [PassportId] FROM [dbo].[tblMember] WHERE [PassportId] = @PassportId) INSERT INTO [dbo].[tblMember]([PassportId], [PhotoId], [FirstName], [SecondName],[DateOfMembership], [Phone], [Address], [Email],[Deleted]) VALUES(@PassportId, @PhotoId, @FirstName, @SecondName, @DateOfMembership, @Phone, @Address, @Email, @Deleted); ";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = memberInsertQuery;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@PassportId", memberToAdd.PassportId);
                    command.Parameters.AddWithValue("@FirstName", memberToAdd.FirstName);
                    command.Parameters.AddWithValue("@SecondName", memberToAdd.SecondName);
                    command.Parameters.AddWithValue("@DateOfMembership", memberToAdd.DateOfMembership.ToString());
                    command.Parameters.AddWithValue("@Email", memberToAdd.Email);
                    command.Parameters.AddWithValue("@Phone", memberToAdd.Phone);
                    command.Parameters.AddWithValue("@Address", memberToAdd.Address);
                    command.Parameters.AddWithValue("@PhotoId", memberToAdd.Photo);
                    command.Parameters.AddWithValue("@Deleted", 0); //0 not deleted, 1 - deleted
                    
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EditMember(Member memberToEdit, string passport)
        {
            if (memberToEdit == null)
            {
                throw new Exception("No member to edit");
            }

            string memberInsertQuery;

            if (passport == memberToEdit.PassportId)
            {
                memberInsertQuery = "UPDATE [dbo].[tblMember] SET [PassportId] = @Passport ,[PhotoId] = @PhotoId,[FirstName] = @FirstName, [SecondName] = @SecondName, [DateOfMembership] = @DateOfMembership, [Phone] = @Phone, [Address] = @Address, [Email] = @Email, [Deleted] = @Deleted WHERE [PassportId] = @OldPassport";
            }
            else
            {
                memberInsertQuery = "IF NOT EXISTS (SELECT [PassportId] FROM [dbo].[tblMember] WHERE [PassportId] = @OldPassport) UPDATE [dbo].[tblMember] SET [PassportId] = @Passport ,[PhotoId] = @PhotoId,[FirstName] = @FirstName, [SecondName] = @SecondName, [DateOfMembership] = @DateOfMembership, [Phone] = @Phone, [Address] = @Address, [Email] = @Email, [Deleted] = @Deleted WHERE [PassportId] = @OldPassport";
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = memberInsertQuery;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@OldPassport", memberToEdit.PassportId);

                    command.Parameters.AddWithValue("@Passport", memberToEdit.PassportId);
                    command.Parameters.AddWithValue("@FirstName", memberToEdit.FirstName);
                    command.Parameters.AddWithValue("@SecondName", memberToEdit.SecondName);
                    command.Parameters.AddWithValue("@DateOfMembership", memberToEdit.DateOfMembership.ToString());
                    command.Parameters.AddWithValue("@Email", memberToEdit.Email);
                    command.Parameters.AddWithValue("@Phone", memberToEdit.Phone);
                    command.Parameters.AddWithValue("@Address", memberToEdit.Address);
                    command.Parameters.AddWithValue("@PhotoId", memberToEdit.Photo);
                    command.Parameters.AddWithValue("@Deleted", memberToEdit.Deleted);                    

                    command.ExecuteNonQuery();
                }
            }
        }
        public MemberId GetMemberIdByPassport(string passport)
        {
            if (passport == "")
            {
                //use more specific exception
                throw new Exception("There is no passport information");
            }

            string memberInsertQuery = "SELECT TOP 1 [Id] FROM [dbo].[tblMember] WHERE [PassportId] = @Passport AND [Deleted] <> 1";
            MemberId member = new MemberId();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = memberInsertQuery;
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@Passport", passport);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            member.Id = (int)reader["Id"];
                        }
                    }
                }
            }

            return member;
        }
        public Member GetMemberByPassport(string passport)
        {
            if(passport == "")
            {
                throw new Exception("There is no passport information");
            }

            string memberInsertQuery = "SELECT [Id], [PassportId], [PhotoId], [FirstName], [SecondName], [DateOfMembership], [Phone], [Address], [Email], [Deleted] FROM [dbo].[tblMember] WHERE [PassportId] = @Passport AND [Deleted] <> 1";
            Member member = new Member();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = memberInsertQuery;
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@Passport", passport);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {                            
                            member.PassportId = (string)reader["PassportId"];
                            member.FirstName = (string)reader["FirstName"];
                            member.SecondName = (string)reader["SecondName"];
                            member.DateOfMembership = ((DateTime)reader["DateOfMembership"]).ToString();
                            member.Phone = (string)reader["Phone"];
                            member.Address = (string)reader["Address"];
                            member.Email = (string)reader["Email"];
                            member.Deleted = (bool)reader["Deleted"];
                            member.Photo = (byte[])reader["PhotoId"];
                        }                        
                    }
                }                
            }

            return member;
        }
    }
}
