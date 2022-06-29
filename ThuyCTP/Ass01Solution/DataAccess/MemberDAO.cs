using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        private static MemberDAO instance = null;
       // private static readonly object instanceLock = new object();
       private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        //==============================
        //Initialize member list 
       
        public IEnumerable<MemberObject> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID, MemberName, Email, Password, City, Country FROM MemberObject";
            var cars = new List<MemberObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    cars.Add(new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                         Email= dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5),
                    });
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

            return cars;
        }
        //----------------------------------------------------------------
        public MemberObject GetMemberByID(int memberID)
        {
            MemberObject car = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID, MemberName, Email, Password, City, Country " +
                "From MemberObject Where MemberID = @MemberID";
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    car = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return car;
        }
//================
      


       public MemberObject GetMemberByName(string memberName)
        {
            MemberObject car = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID, MemberName, Email, Password, City, Country " +
                "From MemberObject Where MemberName LIKE @MemberName";
            try
            {
                var param = dataProvider.CreateParameter("@MemberName", 16, memberName, DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    car = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return car;
        }
        //-----------------------------------------------------------------
        //Add a new member
        public void AddNew(MemberObject member)
        {
            try
            {
                MemberObject pro = GetMemberByID(member.MemberID);
                if (pro == null)
                {
                    string SQLInsert = "Insert MemberObject values(@MemberID,@MemberName,@Email,@Password,@City,@Country)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberName", 50, member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 4, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 5, member.Country, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member is already exits");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //Update a member
        public void Update(MemberObject member)
        {
            try
            {
                MemberObject c = GetMemberByID(member.MemberID);
                if (c != null)
                {
                    string SQLUpdate = "Update Cars Set MemberName= @MemberName, Email = @Email," +
                        "Password=@Password, City=@City, Country=@Country WHERE MemberID = @MemberID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberName", 50, member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 4, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 5, member.Country, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("There member does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //------------------------------------------------------------------
        //Remove a member
        public void Remove(int MemberID)
        {
            try
            {
                MemberObject car = GetMemberByID(MemberID);
                if (car != null)
                {
                    string SQLDelete = "Delete Cars WHERE MemberID= @MemberID";
                    var param = dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("There car does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
        public List<MemberObject> GetMemberByCityAndCountry(string city, string country)
        {
            List<MemberObject> FList = new List<MemberObject>();
           /* for (int i = 1; i <= MemberList.Count; i++)
            {
                if (MemberList[i - 1].City == city && MemberList[i - 1].Country == country) { FList.Add(MemberList[i - 1]); }
            }*/
            return FList;
        }
    }

}