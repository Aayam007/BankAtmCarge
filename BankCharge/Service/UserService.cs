using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BankCharge.Models;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace BankCharge.Service
{
    public class UserService : IUserService
    {
        private readonly IConfiguration configuration;


        public UserService(IConfiguration config)
        {
            this.configuration = config;
        }

        public int New(UserDetail userDetail)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                DynamicParameters parameters = new DynamicParameters();


                parameters.Add("@AppId", userDetail.AppId);
                parameters.Add("@Name", userDetail.BankName);
                parameters.Add("@CardType", userDetail.CardType);
                parameters.Add("@CardNumber", userDetail.CardNumber);



                rowAffected = con.Execute("InsertUserDetails", parameters, commandType: CommandType.StoredProcedure);
            }

            return rowAffected;
        }
    }
}
