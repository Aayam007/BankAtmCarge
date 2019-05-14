using BankCharge.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BankCharge.Service
{
    public class PatnerService : IPatnerService
    {
        private readonly IConfiguration configuration;


        public PatnerService(IConfiguration config)
        {
            this.configuration = config;
        }

        public IEnumerable<Patner> GetPatners()
        {
            List<Patner> patnerList = new List<Patner>();

            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                patnerList = con.Query<Patner>("GetPatnerBanks").ToList();
            }

            return patnerList;
        }
        public IEnumerable<Patner> GetPatnerSearch(string search)
        {
            List<Patner> patnerList = new List<Patner>();

            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                patnerList = con.Query<Patner>("select * from PatnerBank where Name like '" + search + "%'").ToList();
            }

            return patnerList;
        }

        public Patner GetPatnerById(int? id)
        {
            Patner patner = new Patner();
            if (id == null)
                return patner;

            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Id", id);
                patner = con.Query<Patner>("GetPatnerBankByID", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return patner;
        }

        public int New(Patner patner)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                DynamicParameters parameters = new DynamicParameters();

               
                parameters.Add("@BankId", patner.BankId);
                parameters.Add("@PatnerId", patner.PatnerId);



                rowAffected = con.Execute("InsertPatnerBank", parameters, commandType: CommandType.StoredProcedure);
            }

            return rowAffected;
        }
        public int EditPatner(Patner patner)
        {
            int rowAffected = 0;

            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                DynamicParameters parameters = new DynamicParameters();
               
               
                parameters.Add("@BankId", patner.BankId);
                parameters.Add("@PatnerId", patner.PatnerId);



                rowAffected = con.Execute("UpdatePatnerBank", parameters, commandType: CommandType.StoredProcedure);
            }
            return rowAffected;
        }
        public int DeletePatner(int id)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                rowAffected = con.Execute("DeletePatnerBank", parameters, commandType: CommandType.StoredProcedure);

            }
            return rowAffected;
        }


    }
}
